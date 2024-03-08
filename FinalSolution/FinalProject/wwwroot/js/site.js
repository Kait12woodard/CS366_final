$(document).ready(function(){
    $("#snorlax").click(function(){
        $(this).attr("src", "/Images/SnorlaxWave.png");
    })
});

document.getElementById("Convert").addEventListener("click", function() {
    const stringWeight = document.getElementById("Weight_to_convert");
    const blsWeight = parseFloat(stringWeight.innerText);
    const kiloWeight = blsWeight * 0.453592;
    stringWeight.innerText = kiloWeight;
    const label = document.getElementById("WeightLabel");
    label.innerText = "kg"
});
