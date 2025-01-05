document.addEventListener("DOMContentLoaded", function() {
    const ctx = document.getElementById('districtChart').getContext('2d');
    const isDarkMode = document.body.classList.contains('dark-mode');

    const backgroundColor = isDarkMode ? 'rgba(255, 255, 255, 0.2)' : 'rgba(75, 192, 192, 0.2)';
    const borderColor = isDarkMode ? 'rgba(255, 255, 255, 1)' : 'rgba(75, 192, 192, 1)';

    const chartData = {
        labels: districtNames,
        datasets: [{
            label: 'Nüfus',
            data: districtPopulations,
            backgroundColor: backgroundColor,
            borderColor: borderColor,
            borderWidth: 1
        }]
    };

    const chartOptions = {
        scales: {
            y: {
                beginAtZero: true,
                ticks: {
                    color: isDarkMode ? '#ffffff' : '#333333'
                }
            },
            x: {
                ticks: {
                    color: isDarkMode ? '#ffffff' : '#333333'
                }
            }
        },
        plugins: {
            legend: {
                labels: {
                    color: isDarkMode ? '#ffffff' : '#333333'
                }
            }
        }
    };

    const districtChart = new Chart(ctx, {
        type: 'bar',
        data: chartData,
        options: chartOptions
    });

    // Tema değiştiğinde grafiği güncelle
    const themeSwitcher = document.querySelector('.theme-toggle button');
    themeSwitcher.addEventListener('click', () => {
        setTimeout(() => {
            const isDark = document.body.classList.contains('dark-mode');
            chartOptions.scales.y.ticks.color = isDark ? '#ffffff' : '#333333';
            chartOptions.scales.x.ticks.color = isDark ? '#ffffff' : '#333333';
            chartOptions.plugins.legend.labels.color = isDark ? '#ffffff' : '#333333';
            chartData.datasets[0].backgroundColor = isDark ? 'rgba(255, 255, 255, 0.2)' : 'rgba(75, 192, 192, 0.2)';
            chartData.datasets[0].borderColor = isDark ? 'rgba(255, 255, 255, 1)' : 'rgba(75, 192, 192, 1)';
            districtChart.update();
        }, 500); // Tema geçiş animasyonunu bekleyin
    });
});
