const lastSVG = document.getElementById("lastSVG");
const searchInput = document.getElementById("searchInput");

searchInput.addEventListener("input", () =>{
    if(searchInput.value){
        lastSVG.classList.add("active");
    } else{
        lastSVG.classList.remove("active");
    }
}

)