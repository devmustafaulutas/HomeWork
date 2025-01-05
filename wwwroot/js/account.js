document.addEventListener('DOMContentLoaded', function () {
    const toggleSwitch = document.querySelector('.theme-switch input[type="checkbox"]');
    const currentTheme = localStorage.getItem('theme');

    if (currentTheme) {
        document.documentElement.setAttribute('data-theme', currentTheme);

        if (currentTheme === 'dark') {
            toggleSwitch.checked = true;
        }
    }

    toggleSwitch.addEventListener('change', function (e) {
        if (e.target.checked) {
            document.documentElement.setAttribute('data-theme', 'dark');
            localStorage.setItem('theme', 'dark');
        } else {
            document.documentElement.setAttribute('data-theme', 'light');
            localStorage.setItem('theme', 'light');
        }
    });

    document.getElementById('openRegister').addEventListener('click', function () {
        document.getElementById('card').style.transform = 'rotateY(180deg)';
    });

    document.getElementById('openLogin').addEventListener('click', function () {
        document.getElementById('card').style.transform = 'rotateY(0deg)';
    });
});
