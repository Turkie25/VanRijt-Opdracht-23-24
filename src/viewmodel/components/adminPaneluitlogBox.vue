<template>
<div class="AdminBox">
    <div class='AdminInfo'>
        <img class='EventLogo' src='src\view\images\VanrijtLogo.jpg'>
        <div class='AdminData'>
            <h2 class='BedrijfsNaam'>VanRijt</h2>
            <h5 class='Role'>Admin</h5>
        </div>
    </div>
    <button class="modeButton">Dark Mode</button>
    <div class='line'></div>
    <button class="modeButton">Uitloggen</button>

    <!-- <h2 class="FestivalText">{{ EventNaam }}</h2>
     <div>
        <h3 class='In-Uit-stroomText'>Instroom: <span class='InstroomColor'>{{ Instroom }}</span></h3>
        <h3 class='In-Uit-stroomText'>Uitsroom: <span class='UitstroomColor'>{{ Uitstroom }}</span></h3>
     </div> -->
</div>
</template>



<style lang="scss">
@import '../../view/scss/root.scss';

/* Container Styles */
.AdminBox {
  display: flex;
  flex-direction: column;
  background-color: $offWhite; //color is nog verkeerd omdat achtergrond wit is en ik dus niet kon zien wat ik aan het maken was
  font-family: Manrope;

  color: black;
  height: 242px;
  width: 296px;
  filter: drop-shadow(-3px 2px 12px 6px rgba(2, 81, 92, 0.08));
  border-radius: 5%;
}

.AdminInfo {
    display: flex;
    align-items: center;
}

.AdminData {
    margin: 5% 30% 0 auto;
}

.EventLogo{
    height: 80px;
    width: 80px;
    border-radius: 50%;
    margin: 5% auto 0 5%;
}

.BedrijfsNaam {
    color: $primary;
}

.Role {
    color: $grayDark;
}

.modeButton{
    margin: 10% auto 0 10%;
    font-size: 20px;
}

.line {
    background-color: $grayDark;
    height: 2px;
    width: 238px;
    margin: 5% auto -5% 10%;
}
</style>