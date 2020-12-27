let Xmlhttp = new XMLHttpRequest();
let ExchangeList;
let sizeList = document.getElementById("ListSize");
let listPage = document.getElementById("listPage").getElementsByTagName("li");
let next = listPage[listPage.length - 1].getElementsByTagName("a")[0];
let prev = listPage[0].getElementsByTagName("a")[0];
let info = document.getElementById("dataTable_info");
let Index = 0;
Xmlhttp.onreadystatechange = function () {
    
    if (this.readyState == 4 && this.status == 200)
    {
        ExchangeList = JSON.parse(this.responseText);
        sizeList.options[0].value = ExchangeList.length;
        info.innerHTML = "Showing " + Number(Index + 1) + " to " + ExchangeList.length + " of " + ExchangeList.length;
        listElements(ExchangeList);
        sizeList.onchange = () => {
            let size = Number(sizeList.options[sizeList.selectedIndex].value);
            if (size > ExchangeList.length) size = ExchangeList.length;
            Index = 0;
            info.innerHTML = "Showing " + Number(Index + 1) + " to " + Number(Index + size) + " of " + ExchangeList.length;
            listElements(ExchangeList, size, Index);
        }
        
        next.onclick = () => {
            let size = Number(sizeList.options[sizeList.selectedIndex].value);
            if (size > ExchangeList.length) size = ExchangeList.length;
            Index = Index + Number(size);
            if (Index >= ExchangeList.length) {
                Index = Index - Number(size);
            }
            let end = Index + size;
            if (end > ExchangeList.length) {
                end = ExchangeList.length;
            }

            info.innerHTML = "Showing " + Number(Index + 1) + " to " + Number(end) + " of " + ExchangeList.length;
            listElements(ExchangeList, size, Index);
        }
        prev.onclick = () => {
            let size = Number(sizeList.options[sizeList.selectedIndex].value);
            if (size > ExchangeList.length) size = ExchangeList.length;
            Index = Index - Number(size);
            if (Index < 0) {
                Index = 0;
            }
            info.innerHTML = "Showing " + Number(Index + 1) + " to " + Number(Index + size) + " of " + ExchangeList.length;
            listElements(ExchangeList, size, Index);
        }
    }
}

Xmlhttp.open("GET", "../DovizKurTanim/ExchangeList.json", true);
Xmlhttp.send();





function listElements(ExchangeList, size = ExchangeList.length,startIndex=0)
{
    let tablebody = document.getElementById("CurrencyDataTable").getElementsByTagName("tbody")[0];
    tablebody.innerHTML = "";
    console.log(size);
    console.log(startIndex);
    let finishIndex = Number(size) + Number(startIndex)
    if (finishIndex > ExchangeList.length) {
        finishIndex = ExchangeList.length;
    }
    console.log(finishIndex);
    for (let i = startIndex; i < finishIndex; i++)
    {
        let Element = ExchangeList[i];
        let Trow = tablebody.insertRow();
        for (let e in Element)
        {
            if (e == "Id") continue;
            let Tcell = Trow.insertCell();
            let value = Element[e];
            if (e == "CurrencyExchangeDate") {
                let date = new Date(value);
                value = date.getDate() + '/' + (date.getMonth() + 1) + '/' + date.getFullYear();
            }
            if (e == "CurrencyCode") {
                if (value == 1) value = "TRY";
                else if (value == 2) value = "USD";
                else if (value == 3) value = "EUR";
            }
            let text = document.createTextNode(value);

            Tcell.appendChild(text);
        }
    }
}

