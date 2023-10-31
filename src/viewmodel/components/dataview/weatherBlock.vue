<template>
    <div class="weatherBlock">
        <div class="weatherTop">
            <img class="weatherIcon" src="../../../view/images/bewolktIcon.jpg" alt="Onweer">
            <div class="weatherInfo">
                <h3>Bewolkt</h3>
                <p>Neerslag verwacht over 5 minuten</p>
            </div>
        </div>
        <div class="weatherBottom">
            <p>Temperatuur: 21°C </p>
            <p>Luchtvochtigheid: 78%</p> 
            <p>Kans op neerslag: 43%</p>
            <p>Kans op neerslag: 43%</p>



        </div>
    </div>
</template>

<style scoped>

.weatherBlock{
width: 100%;
left: 500px; /* verwijder dit */
background: #EEF1F6;
border-radius: 16px;
margin: 0 auto; 
padding: 4% 0;
}
.weatherTop{
    display: flex;
    justify-content: space-evenly;
}

.weatherTop img{
    height: 10%;
    width: 22%;
    margin: 10px;
}
.weatherInfo{
    margin: 8px 10px;
}
.weatherInfo h3{
    margin: 0px;
}
.weatherInfo p{
    margin: 0px;
}

.weatherBottom{
    margin: 0px 10px;
}

.weatherBottom p{
    margin: 4px;
    min-height: 10%;
    font-size: 12px;
}

</style>