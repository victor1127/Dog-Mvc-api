
function DisplayBreedInfo(name, imgUrl, history, breedId) {

    document.getElementById("breed-img").src = imgUrl;
    document.getElementById("breed-name").innerHTML = name;

    let breedDrescription = document.getElementById("breed-description");

    if (history == "") breedDrescription.innerHTML = "Sorry, there is no description for this one, but i bet he is cute.";
    else breedDrescription.innerHTML = history;


    var index = breedArray.findIndex((x => x.id == breedId));

    if (index == -1) {
        alert("Object not found");
    }

    document.getElementById("sub-header").innerHTML="Other sub-breeds"
    document.getElementById("sub-1").innerHTML = breedArray[index + 1].name;
    document.getElementById("sub-2").innerHTML = breedArray[index + 2].name;
    document.getElementById("sub-3").innerHTML = breedArray[index + 3].name;

}

