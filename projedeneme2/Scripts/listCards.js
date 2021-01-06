let Xmlhttp = new XMLHttpRequest();
let EntityCards;
let sizeList = document.getElementById("ListSelect");
let listPage = document.getElementById("listPage").getElementsByTagName("li");
let next = listPage[listPage.length - 1].getElementsByTagName("a")[0];
let prev = listPage[0].getElementsByTagName("a")[0];
let info = document.getElementById("dataTable_info");

let Index = 0;
Xmlhttp.onreadystatechange = function () {
    if (this.readyState == 4 && this.status == 200) {
        EntityCards = JSON.parse(this.responseText);
        sizeList.options[0].value = EntityCards.length;
        listElements(EntityCards);
        info.innerHTML = "Showing " + Number(Index + 1) + " to " + EntityCards.length + " of " + EntityCards.length;
        sizeList.onchange = () => {
            let size = Number(sizeList.options[sizeList.selectedIndex].value);
            if (size > EntityCards.length) size = EntityCards.length;
            Index = 0;
            info.innerHTML = "Showing " + Number(Index + 1) + " to " + Number(Index + size) + " of " + EntityCards.length;
            listElements(EntityCards, size, Index);
        }
        next.onclick = () => {
            let size = Number(sizeList.options[sizeList.selectedIndex].value);
            if (size > EntityCards.length) size = EntityCards.length;
            Index = Index + Number(size);
            if (Index >= EntityCards.length) {
                Index = Index - Number(size);
            }
            let end = Index + size;
            if (end > EntityCards.length) {
                end = EntityCards.length;
            }
            info.innerHTML = "Showing " + Number(Index + 1) + " to " + Number(end) + " of " + EntityCards.length;
            listElements(EntityCards, size, Index);
        }
        prev.onclick = () => {
            let size = Number(sizeList.options[sizeList.selectedIndex].value);
            if (size > EntityCards.length) size = EntityCards.length;
            Index = Index - Number(size);
            if (Index < 0) {
                Index = 0;
            }
            info.innerHTML = "Showing " + Number(Index + 1) + " to " + Number(Index + size) + " of " + EntityCards.length;
            listElements(EntityCards, size, Index);
        }
    }
}

Xmlhttp.open("GET", "../CariKart/EntityCards.json", true);
Xmlhttp.send();




function listElements(EntityCards, size = EntityCards.length, startIndex = 0) {
    
    let tablebody = document.getElementById("dataTable").getElementsByTagName("tbody")[0];
    tablebody.innerHTML = "";
    //console.log(size);
    let finishIndex = Number(size) + Number(startIndex)
    if (finishIndex > EntityCards.length) {
        finishIndex = EntityCards.length;
    }
    for (let i = startIndex; i < finishIndex; i++) {
        if (i >= EntityCards.length) break;
        let EntityCard = EntityCards[i];
        let Trow = tablebody.insertRow();
        for (let e in EntityCard) {
            if (e != "Id") {
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
}

