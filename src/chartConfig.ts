export const data = {
    labels: [
        "12:00",
        "13:00",
        "14:00",
        "15:00",
        "16:00",
        "17:00",
        "18:00",
        "19:00",
        "20:00",
        "21:00",
    ],
    datasets: [
        {
            label: "Totaal",
            backgroundColor: "#3244a8",
            borderColor: "#3244a8",
            hidden: true,
            pointRadius: 1,
            pointHitRadius: 25,
            data: [50, 60, 50, 40, 50, 60, 50, 40, 50, 60],
        },

        {
            label: "Instroom",
            backgroundColor: "#04A0B5",
            borderColor: "#04A0B5",
            pointRadius: 1,
            pointHitRadius: 25,
            data: [40, 89, 10, 40, 39, 80, 40, 50, 100, 70],
        },
        {
            label: "Uitstroom",
            backgroundColor: "#E03076",
            borderColor: "#E03076",
            pointRadius: 1,
            pointHitRadius: 25,
            data: [60, 49, 55, 80, 99, 10, 5, 8, 15, 40],
        },
    ],

};



export const options = {
    responsive: true,
    maintainAspectRatio: false,
    
};