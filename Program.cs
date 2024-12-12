using dotenv.net;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using _23210202037.Data;
using _23210202037.Models;

var builder = WebApplication.CreateBuilder(args);

// .env dosyasındaki çevresel değişkenleri yükleyin
DotEnv.Load();

// Çevresel değişkenlerden veritabanı bağlantı dizesini oluşturun
var connectionString = $"Server={Environment.GetEnvironmentVariable("DB_HOST")};" +
                       $"Database={Environment.GetEnvironmentVariable("DB_NAME")};" +
                       $"User={Environment.GetEnvironmentVariable("DB_USER")};" +
                       $"Password={Environment.GetEnvironmentVariable("DB_PASSWORD")};" +
                       $"SslMode=Preferred;"; // MySQL için SSL modu

// Servisleri ekleyin
builder.Services.AddControllersWithViews();
builder.Services.AddRazorPages(); // Razor Pages hizmetini ekleyin

// DbContext'i ekleyin ve bağlantı dizesini kullanın
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString))
);

// Identity hizmetlerini ekleyin (özel User ve Role sınıfları ile)
builder.Services.AddIdentity<User, Role>(options => options.SignIn.RequireConfirmedAccount = false)
    .AddEntityFrameworkStores<ApplicationDbContext>()
    .AddDefaultTokenProviders();

// Cookie ayarlarını yapılandırın
builder.Services.ConfigureApplicationCookie(options =>
{
    options.LoginPath = "/Account/Login";
    options.AccessDeniedPath = "/Account/AccessDenied";
});

var app = builder.Build();

// Rolleri ve kullanıcıları eklemek için yöntem çağırın
using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;
    var roleManager = services.GetRequiredService<RoleManager<Role>>(); // Doğru türü kullanın
    var userManager = services.GetRequiredService<UserManager<User>>();
    await SeedData.Initialize(roleManager, userManager);
}

// Middleware'ler
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication(); // Authentication middleware
app.UseAuthorization();

// Özel rotaları tanımlayın
app.MapControllerRoute(
    name: "login",
    pattern: "Login",
    defaults: new { controller = "Account", action = "Login" });

app.MapControllerRoute(
    name: "register",
    pattern: "Register",
    defaults: new { controller = "Account", action = "Register" });

// Default rotayı ekleyin
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

// Razor Pages rotalarını ekleyin
app.MapRazorPages();

app.Run();