// Slider Animation
const slides = document.querySelector(".slides");
const slideCount = document.querySelectorAll(".slide").length;

let index = 0; // Başlangıç indeksi

function slideTransition() {
  index++;
  if (index >= slideCount) {
    index = 0; // Baştan başla
  }
  slides.style.transform = `translateX(-${index * 100}%)`;
}

setInterval(slideTransition, 4000); // Her 4 saniyede bir slayt değiştir
