let Xmlhttp = new XMLHttpRequest();
let EntityCards;
Xmlhttp.onreadystatechange = function () {
    if (this.readyState == 4 && this.status == 200) {
        EntityCards = JSON.parse(this.responseText); 
    }
}

Xmlhttp.open("GET", "../CariKart/EntityCards.json", true);
Xmlhttp.send();

let tablebody = document.getElementById("dataTable").getElementsByTagName("tbody")[0];

let Trow = tablebody.insertRow();

let Tcell = Trow.insertCell();

let text = document.createTextNode("Hello");

Tcell.appendChild(text);