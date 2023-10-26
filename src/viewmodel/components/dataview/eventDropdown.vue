<template>
    <div class="eventDropdown">
        <h2 class="eventDropdownarrow">&#129171;<span class="eventText">Kies evenement</span></h2> <!--verwijder &#129171 en zet daar <i class='bx bx-chevron-down' ></i> van boxicons-->
        <ul class="dropdownOptions">
            <li>optie 1</li>
            <li>optie 2</li>
            <li>optie 3</li>
        </ul>
    </div>
</template>

<style scoped>
    .eventDropdown {
        display: flex;
        flex-direction: column;
        align-items: flex-start;
        padding: 8px 16px;
        border-radius: 16px;
        width: 200px;
        height: 30px;
        background-color: rgb(153, 153, 153);  /* verander kleur*/
        cursor: pointer;
    }

    .eventDropdownarrow {
        font-family: 'Manrope';
        font-style: normal;
        font-weight: 600;
        font-size: 19px;
        line-height: 30px;
        color: #000000;
        margin: 0;
    }

    .dropdownOptions {
        list-style: none;
        padding: 0;
        margin: 0;
        display: none;
        background-color: rgb(153, 153, 153); /* verander kleur*/
        border-top: none;
        border-bottom-left-radius: 16px;
        border-bottom-right-radius: 16px;
    }

    .eventDropdown:hover .dropdownOptions {
        display: block;
    }

    .dropdownOptions li {
        padding: 8px;
        font-family: 'Manrope';
        font-style: normal;
        font-weight: 400;
        font-size: 16px;
        color: #000000;
    }

    .dropdownOptions li:hover {
        background-color: rgba(0, 0, 0, 0.1);
    }

    span{
        margin-left: 30px;
    }
</style>
