﻿// Profil menüsünün slider değişince aşağıda kalma sorununu çözmek için
const profileButton = document.getElementById('profile-button');
const loginPartial = document.getElementById('login-partial');

profileButton.addEventListener('click', (e) => {
  e.stopPropagation();
  loginPartial.classList.toggle('d-none');
  loginPartial.classList.toggle('visible');
});

document.addEventListener('click', (e) => {
  if (!loginPartial.contains(e.target) && !profileButton.contains(e.target)) {
    loginPartial.classList.add('d-none');
    loginPartial.classList.remove('visible');
  }
});

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
        themeIcon.classList.remove("fa-moon");
        themeIcon.classList.add("fa-sun");
    }
});

// AOS (Animate On Scroll) Başlatma
AOS.init({
    duration: 1000,
    once: true
});

// GSAP Animasyonları
gsap.from(".logo", { 
    duration: 1, 
    y: 0, 
    ease: "bounce.out",
    delay: 0.2,
    onComplete: function() {
        document.querySelector(".logo").style.transform = "translateY(0)";
    }
});

gsap.from(".nav-link", { 
    duration: 1, 
    delay: 0.5, 
    y: 50, 
    opacity: 0, 
    stagger: 0.2, 
    ease: "power2.out" 
});

gsap.from(".social-icons a", { 
    duration: 1, 
    delay: 0.7, 
    y: 50, 
    opacity: 0, 
    stagger: 0.2, 
    ease: "power2.out" 
});