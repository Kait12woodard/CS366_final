//Home page Snorlax Animation
$(document).ready(function(){
    $("#snorlax").click(function(){
        $(this).attr("src", "/Images/SnorlaxWave.png");
    })
});

//Validates Buddy Form Inputs Client side
function validate(pokemon, weight, food, nickname)
{
    var error= "";
    
    var isChecked = Array.from(pokemon).some(box => box.checked)
    if(isChecked === false)
    {
        error= "Please select a pokemon"
        alert(error);
        return false;
    }
    if(weight.value > 1000 || weight.value < 1)
    {
        error="Please enter a valid weight between 1 to 1000";
        alert(error);
        return false;
    }
    if(food.value.length < 2 || food.value.length > 100)
    {
        error="Please enter a valid Favorite Food between 2-100 characters long";
        alert(error);
        return false;
    }
    if(nickname.value.length < 2 || nickname.value.length > 100)
    {
        error="Please enter a valid Nickname between 2-100 characters long";
        alert(error);
        return false;
    }
}

$("#Convert_lbs").hide();
$("#avoidFood").hide();

document.getElementById("Convert_kilo").addEventListener("click", function() {
    const stringWeight = document.getElementById("Weight_to_convert");
    const blsWeight = parseFloat(stringWeight.innerText);
    const kiloWeight = blsWeight * 0.453592;
    stringWeight.innerText = kiloWeight.toFixed(2);
    const label = document.getElementById("WeightLabel");
    label.innerText = "Kilograms"
    $("#Convert_kilo").hide();
    $("#Convert_lbs").show();
});

document.getElementById("Convert_lbs").addEventListener("click", function() {
    const stringWeight = document.getElementById("Weight_to_convert");
    const blsWeight = parseFloat(stringWeight.innerText);
    const kiloWeight = blsWeight * 2.2046;
    stringWeight.innerText = kiloWeight.toFixed(2);
    const label = document.getElementById("WeightLabel");
    label.innerText = "Pounds"
    $("#Convert_lbs").hide();
    $("#Convert_kilo").show();
});

//Based on Pokemon displays recommended food and foods to avoid
$(document).ready(function() {
    const pokemon = $("#PokemonType").text();
    var recommendCount = 0;
    var avoidCount = 0;
    var recommendFood = [];
    var avoidFood = [];

    if(pokemon === "Mimikyu")
    {
        recommendFood = ["Basil", "Jalapenos", "Onions"];
        avoidFood = ["Apples", "Hamburgers", "Fried Fillet"];
    } else if(pokemon === "Eevee")
    {
        recommendFood = ["Bananas", "Fried Fillet", "Tofu"];
        avoidFood = ["Pickles", "Strawberrys", "Herbed Sausage"];
    } else if(pokemon === "Gengar")
    {
        recommendFood = ["Ketchup", "Kiwis", "Green Bell Peppers"];
        avoidFood = ["Fried Fillet", "Strawberrys", "Pinapples"];
    } else if(pokemon === "Charizard")
    {
        recommendFood = ["Peanut Butter", "Apples", "Kiwis"];
        avoidFood = ["Jalapenos", "Mustard", "Chili Sauce"];
    } else if(pokemon === "Lapras")
    {
        recommendFood = ["Cucumbers", "Apples", "Herbed Sausage"];
        avoidFood = ["Horseradishs", "Bacon", "Bananas"];
    }
    $("#RecommendButton").click(function(){
        $("#recFood").append(recommendFood[recommendCount]+ "<br>");
        recommendCount++;
        if(recommendCount === 3) 
        {
            $("#RecommendButton").hide();
        }
    });  

    $("#AvoidButton").click(function(){
        $("#avoidFood").append(avoidFood[avoidCount]+ "<br>");
        avoidCount++;
        $("#avoidFood").show();
        if(avoidCount === 3) 
        {
            $("#AvoidButton").hide();
        }
    }); 
});

//Displays image based on pokemon and weight
$(document).ready(function() {
    const pokemon = $("#PokemonType").text();
    var weightStatus = $("#Health").text();
    weightStatus = weightStatus.slice(15);
    var image = "";
    var alt = "";

    if(pokemon === "Mimikyu")
    {
        if(weightStatus === "Overweight")
        {
            image = "MimikyuChunky.png";
            alt = "Chunky Mimikyu";
        } else if(weightStatus === "Underweight")
        {
            image = "MimikyuThin.png";
            alt = "Thin Mimikyu";
        } else
        {
            image = "MimikyuReg.png";
            alt = "Regular Mimikyu";
        }
    } else if(pokemon === "Eevee")
    {
        if(weightStatus === "Overweight")
        {
            image = "EeveeChunky.png";
            alt = "Chunky Eevee";
        } else if(weightStatus === "Underweight")
        {
            image = "EeveeThin.png";
            alt = "Eevee Thin";
        } else
        {
            image = "EeveeReg.png";
            alt = "Regular Eevee";
        }
    } else if(pokemon === "Gengar")
    {
        if(weightStatus === "Overweight")
        {
            image = "GengarChunky.png";
            alt = "Chunky Gengar";
        } else if(weightStatus === "Underweight")
        {
            image = "GengarThin.png";
            alt = "Thin Gengar";
        } else
        {
            image = "GengarReg.png";
            alt = "Regular Gengar";
        }
    } else if(pokemon === "Charizard")
    {
        if(weightStatus === "Overweight")
        {
            image = "CharizardChunky.png";
            alt = "Chunky Charizard";
        } else if(weightStatus === "Underweight")
        {
            image = "CharizardThin.png";
            alt = "Thin Charizard";
        } else
        {
            image = "CharizardReg.png";
            alt = "Regular Charizard";
        }
    } else if(pokemon === "Lapras")
    {
        if(weightStatus === "Overweight")
        {
            image = "LaprasChunky.png";
            alt = "Chunky Lapras";
        } else if(weightStatus === "Underweight")
        {
            image = "LaprasThin.png";
            alt = "Thin Lapras";
        } else
        {
            image = "LaprasReg.png";
            alt = "Regular Lapras";
        }
    }

    $("#PokemonImage").append("<img id='HealthImage' src= '/Images/"+ image + "' alt= '" + alt +"'>");
});



