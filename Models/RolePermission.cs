namespace _23210202037.Models
{
    public class RolePermission
    {
        public int RoleId { get; set; }
        public int PermissionId { get; set; }

        public Role Role { get; set; } = new Role();
        public Permission Permission { get; set; } = new Permission();
    }
}