let Xmlhttp = new XMLHttpRequest();
let EntityCards;
let sizeList = document.getElementById("ListSelect");
Xmlhttp.onreadystatechange = function () {
    if (this.readyState == 4 && this.status == 200) {
        EntityCards = JSON.parse(this.responseText);
        listElements(EntityCards);
        sizeList.onchange = () => {

            let size = sizeList.options[sizeList.selectedIndex].value;

            listElements(EntityCards, size);
        }
        
    }
}

Xmlhttp.open("GET", "../CariKart/EntityCards.json", true);
Xmlhttp.send();




function listElements(EntityCards, size = EntityCards.length) {
    
    let tablebody = document.getElementById("dataTable").getElementsByTagName("tbody")[0];
    tablebody.innerHTML = "";
    //console.log(size);
    for (let i = 0; i < size; i++) {
        if (i >= EntityCards.length) break;
        let EntityCard = EntityCards[i];
        let Trow = tablebody.insertRow();
        for (let e in EntityCard) {
            let Tcell = Trow.insertCell();
            let value = EntityCard[e];
            if (e == "entityKind") {
                if (value == true) {
                    value = "Legal Entity";
                } else {
                    value = "Person";
                }
            } else if (e == "entityType") {
                if (value == true) {
                    value = "Client";
                } else {
                    value = "Supplier";
                }
            }

            let text = document.createTextNode(value);

            Tcell.appendChild(text);
        }
    }
}

