$(document).ready(function(){
    $("#snorlax").click(function(){
        $(this).attr("src", "/Images/SnorlaxWave.png");
    })
});

$("#Convert_lbs").hide();

document.getElementById("Convert_kilo").addEventListener("click", function() {
    const stringWeight = document.getElementById("Weight_to_convert");
    const blsWeight = parseFloat(stringWeight.innerText);
    const kiloWeight = blsWeight * 0.453592;
    stringWeight.innerText = kiloWeight.toFixed(2);
    const label = document.getElementById("WeightLabel");
    label.innerText = "kg"
    $("#Convert_kilo").hide();
    $("#Convert_lbs").show();
});

document.getElementById("Convert_lbs").addEventListener("click", function() {
    const stringWeight = document.getElementById("Weight_to_convert");
    const blsWeight = parseFloat(stringWeight.innerText);
    const kiloWeight = blsWeight * 2.2046;
    stringWeight.innerText = kiloWeight.toFixed(2);
    const label = document.getElementById("WeightLabel");
    label.innerText = "lbs"
    $("#Convert_lbs").hide();
    $("#Convert_kilo").show();
});

$(document).ready(function() {
    const pokemon = $("#PokemonType").text();
    var count = 0;
    var food = [];

    if(pokemon === "Mimikyu")
    {
        food = ["Basil", "Jalapenos", "Onions"]
    } else if(pokemon === "Eevee")
    {
        food = ["Bananas", "Fried Fillet", "Tofu"]
    } else if(pokemon === "Gengar")
    {
        food = ["Ketchup", "Kiwis", "Green Bell Peppers"]
    } else if(pokemon === "Charizard")
    {
        food = ["Peanut Butter", "Apples", "Kiwis"]
    } else if(pokemon === "Lapras")
    {
        food = ["Cucumbers", "Apples", "Herbed Sausage"]
    }
    $("#RecommendButton").click(function(){
        $("#recFood").append(food[count]+ "<br>");
        count++;
        if(count === 3) 
        {
            $("#RecommendButton").hide();
        }
    });  
});

$(document).ready(function() {
    const pokemon = $("#PokemonType").text();
    var count = 0;
    var food = [];

    if(pokemon === "Mimikyu")
    {
        food = ["Apples", "Hamburgers", "Fried Fillet"]
    } else if(pokemon === "Eevee")
    {
        food = ["Pickles", "Strawberrys", "Herbed Sausage"]
    } else if(pokemon === "Gengar")
    {
        food = ["Fried Fillet", "Strawberrys", "Pinapples"]
    } else if(pokemon === "Charizard")
    {
        food = ["Jalapenos", "Mustard", "Chili Sauce"]
    } else if(pokemon === "Lapras")
    {
        food = ["Horseradishs", "Bacon", "Bananas"]
    }
    $("#AvoidButton").click(function(){
        $("#avoidFood").append(food[count]+ "<br>");
        count++;
        if(count === 3) 
        {
            $("#AvoidButton").hide();
        }
    });  
});

