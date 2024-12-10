// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
// Tema değiştirme fonksiyonu
// Tema değiştirme fonksiyonu
function toggleTheme() {
    var body = document.body;
    var themeIcon = document.getElementById("theme-icon");
    body.classList.toggle("dark-mode");
    if (body.classList.contains("dark-mode")) {
        themeIcon.classList.remove("fa-sun");
        themeIcon.classList.add("fa-moon");
        localStorage.setItem("theme", "dark");
    } else {
        themeIcon.classList.remove("fa-moon");
        themeIcon.classList.add("fa-sun");
        localStorage.setItem("theme", "light");
    }
    themeIcon.classList.add("icon-transition");
    setTimeout(function() {
        themeIcon.classList.remove("icon-transition");
    }, 300);
}

// Sayfa yüklendiğinde tema tercihini uygula
document.addEventListener("DOMContentLoaded", function() {
    var theme = localStorage.getItem("theme");
    var body = document.body;
    var themeIcon = document.getElementById("theme-icon");
    if (theme === "dark") {
        body.classList.add("dark-mode");
        themeIcon.classList.remove("fa-sun");
        themeIcon.classList.add("fa-moon");
    } else {
        body.classList.remove("dark-mode");
        themeIcon.classList.remove("fa-moon");
        themeIcon.classList.add("fa-sun");
    }
});