document.addEventListener('DOMContentLoaded', () => {
    // Sol Slider
    const leftSlides = document.querySelectorAll(".slider-left .slide");
    let leftIndex = 0;

    function showLeftSlide(index) {
        leftSlides.forEach((slide, i) => {
            slide.classList.remove('active', 'enter', 'enter-active');
            if (i === index) {
                slide.classList.add('active', 'enter');
                setTimeout(() => {
                    slide.classList.add('enter-active');
                }, 10); // Kısa bir gecikme ile CSS transition'ı tetikleyin
            }
        });
    }

    function leftSlideTransition() {
        leftIndex = (leftIndex + 1) % leftSlides.length;
        showLeftSlide(leftIndex);
    }

    // Başlangıçta ilk slaytı göster
    showLeftSlide(leftIndex);

    // Her 4 saniyede bir sol slider'ı değiştir
    setInterval(leftSlideTransition, 4000);

    // Sağ Slider
    const rightSlides = document.querySelectorAll(".slider-right .slide");
    let rightIndex = 0;

    function showRightSlide(index) {
        rightSlides.forEach((slide, i) => {
            slide.classList.remove('active', 'enter', 'enter-active');
            if (i === index) {
                slide.classList.add('active', 'enter');
                setTimeout(() => {
                    slide.classList.add('enter-active');
                }, 10); // Kısa bir gecikme ile CSS transition'ı tetikleyin
            }
        });
    }

    function rightSlideTransition() {
        rightIndex = (rightIndex + 1) % rightSlides.length;
        showRightSlide(rightIndex);
    }

    // Başlangıçta ilk slaytı göster
    showRightSlide(rightIndex);

    // Her 4 saniyede bir sağ slider'ı değiştir
    setInterval(rightSlideTransition, 4000);
});