let Xmlhttp = new XMLHttpRequest();
let EntityCards;
Xmlhttp.onreadystatechange = function () {
    if (this.readyState == 4 && this.status == 200) {
        EntityCards = JSON.parse(this.responseText);
        listElements(EntityCards);
        
    }
}

Xmlhttp.open("GET", "../CariKart/EntityCards.json", true);
Xmlhttp.send();


function listElements(EntityCards) {
    let tablebody = document.getElementById("dataTable").getElementsByTagName("tbody")[0];

    for (let i = 0; i < EntityCards.length; i++) {
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

