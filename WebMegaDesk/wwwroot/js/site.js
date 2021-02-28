// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

function MakeMaterialChange() {
    var sl = document.querySelector(".material-selector")
    MakeMaterialChangeCard(sl.options[sl.selectedIndex].innerText);
}

function MakeMaterialChangeCard(material) {
    document.querySelector(".material-pine").classList.remove("border-primary"); 
    document.querySelector(".material-laminate").classList.remove("border-primary");
    document.querySelector(".material-veneer").classList.remove("border-primary");
    document.querySelector(".material-oak").classList.remove("border-primary");
    document.querySelector(".material-rosewood").classList.remove("border-primary"); 
    document.querySelector(".material-pine").classList.remove("selected-border");
    document.querySelector(".material-laminate").classList.remove("selected-border");
    document.querySelector(".material-veneer").classList.remove("selected-border");
    document.querySelector(".material-oak").classList.remove("selected-border");
    document.querySelector(".material-rosewood").classList.remove("selected-border"); 
    //add it to the calling one
    document.querySelector(".material-" + material.toLowerCase()).classList.add("border-primary"); 
    document.querySelector(".material-" + material.toLowerCase()).classList.add("selected-border"); 

    var sl = document.querySelector(".material-selector");
    for (var i = 0; i < sl.options.length; i++) {
        if (sl.options[i].innerText == material) {
            sl.options[i].selected = true;
        }
    }
}