<template>
    <div class="dataview">
        <div class="logo"></div>
        <div class="dropdown"></div>
        <div class="datablocks">
            <div class="dataViewCircle">
            </div>
            <div class="blockWrapper">
                <div class="peopleCounter"></div>
                <div class="block instroom"></div>
                <div class="block uitstroom"></div>
                <div class="block trend"></div>
            </div>
        </div>
        <div class="graph">

        </div>
    </div>
</template><script>
import { defineComponent } from 'vue';

export default defineComponent(
    {
        name: "Example",
    }
)
</script>
<style lang="scss">
@import '../../view/scss/root.scss';
    .dataview{
        width: 70%;
        height: 100%;
        display: grid;
        grid-template-columns: 1fr 1fr;
        grid-template-rows: 1fr 3fr 2fr;
        grid-template-areas: 
        "logo dropdown"
        "datablocks datablocks"
        "graph graph"
        ;
        .logo{
            grid-area: logo;
            border: red 2px solid;

        }
        .dropdown{
            grid-area: dropdown;
            border: red 2px solid;

        }
        .datablocks{
            grid-area: datablocks;
            border: red 2px solid;
            display: grid;
            gap: 1rem;
            grid-template-columns: 1fr 3fr;
            grid-template-areas: "dataviewcircle blockwrapper";
            .dataViewCircle{
                grid-area: dataviewcircle;
                background: $primary;
            }
            .blockWrapper{
                grid-area: blockwrapper;
                display: grid;
                gap: 1rem;
                grid-template-columns: repeat(3, 1fr);
                grid-template-rows: minmax(auto, 1fr) auto;
                grid-template-areas: 
                "aantal aantal aantal"
                "instroom uitstroom trend"
                ;
                .peopleCounter{
                    grid-area: aantal;
                    background-color: aquamarine;
                    height: 100%;
                    width: 100%;
                }
                .instroom{
                    grid-area: instroom;
                    background-color: aqua;
                }
                .uitstroom{
                    grid-area: uitstroom;
                    background-color:bisque;  
                }
                .trend{
                    grid-area: trend;
                    background-color:teal;
                }
                .instroom, .uitstroom, .trend{
                    aspect-ratio: 1 / 1;
                }
            }
        }
        .graph{
            grid-area: graph;
            border: red 2px solid;

        }
    }
</style>