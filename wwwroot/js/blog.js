document.addEventListener("DOMContentLoaded", function() {
    const districts = [
        { name: "Ayvacık", population: 30000, img: "ayvacik.jpg", description: "Ayvacık, tarihi ve doğal güzellikleriyle ünlüdür." },
        { name: "Bayramiç", population: 20000, img: "bayramic.jpg", description: "Bayramiç, Kazdağları'nın eteklerinde yer alır." },
        { name: "Biga", population: 90000, img: "biga.jpg", description: "Biga, Çanakkale'nin en büyük ilçelerinden biridir." },
        { name: "Bozcaada", population: 2500, img: "bozcaada.jpg", description: "Bozcaada, Türkiye'nin üçüncü büyük adasıdır." },
        { name: "Çan", population: 50000, img: "can.jpg", description: "Çan, seramik ve çini üretimi ile ünlüdür." },
        { name: "Eceabat", population: 5000, img: "eceabat.jpg", description: "Eceabat, Gelibolu Yarımadası'nda yer alır." },
        { name: "Ezine", population: 40000, img: "ezine.jpg", description: "Ezine, peyniri ile ünlüdür." },
        { name: "Gelibolu", population: 45000, img: "gelibolu.jpg", description: "Gelibolu, tarihi savaş alanları ile bilinir." },
        { name: "Gökçeada", population: 8000, img: "gokceada.jpg", description: "Gökçeada, Türkiye'nin en büyük adasıdır." },
        { name: "Lapseki", population: 25000, img: "lapseki.jpg", description: "Lapseki, kirazı ile ünlüdür." },
        { name: "Yenice", population: 15000, img: "yenice.jpg", description: "Yenice, ormanları ve doğal güzellikleri ile bilinir." }
    ];

    const container = document.getElementById("districts-container");
    districts.forEach(d => {
        const card = document.createElement("div");
        card.className = "blog-district-card";
        card.innerHTML = `
            <img src="~/wwwroot/images/${d.img}" alt="${d.name}" />
            <h2>${d.name}</h2>
            <p>Nüfus: ${d.population.toLocaleString()}</p>
            <p>${d.description}</p>
        `;
        container.appendChild(card);
    });

    // Grafik
    const chartContainer = document.getElementById("chart-container");
    const chartCanvas = document.createElement("canvas");
    chartContainer.appendChild(chartCanvas);

    const ctx = chartCanvas.getContext("2d");
    const chartData = {
        labels: districts.map(d => d.name),
        datasets: [{
            label: 'Nüfus',
            data: districts.map(d => d.population),
            backgroundColor: 'rgba(75, 192, 192, 0.2)',
            borderColor: 'rgba(75, 192, 192, 1)',
            borderWidth: 1
        }]
    };

    new Chart(ctx, {
        type: 'bar',
        data: chartData,
        options: {
            scales: {
                y: {
                    beginAtZero: true
                }
            }
        }
    });
});
