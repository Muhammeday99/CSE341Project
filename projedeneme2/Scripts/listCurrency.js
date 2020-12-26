let Xmlhttp = new XMLHttpRequest();
let ExchangeList;
let sizeList = document.getElementById("CurrencyListSize");
let listPage = document.getElementById("listPage").getElementsByTagName("li");
let Index = 0;
Xmlhttp.onreadystatechange = function () {
    
    if (this.readyState == 4 && this.status == 200)
    {
        ExchangeList = JSON.parse(this.responseText);
        listElements(ExchangeList);
        sizeList.onchange = () => {
            
            let size = sizeList.options[sizeList.selectedIndex].value;
            
            listElements(ExchangeList, size);
        }
    }
}

Xmlhttp.open("GET", "../DovizKurTanim/ExchangeList.json", true);
Xmlhttp.send();


function nextPage() {
    let next = listPage[listPage.length-1].getElementsByTagName("a");
    next.onclick = () => {
        let size = sizeList.options[sizeList.selectedIndex].value;

        listElements(ExchangeList,size,)
    }
}

function listElements(ExchangeList, size = ExchangeList.length,startIndex=0)
{
    let tablebody = document.getElementById("CurrencyDataTable").getElementsByTagName("tbody")[0];
    tablebody.innerHTML = "";
    console.log(size);

    for (let i = startIndex; i < size; i++)
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

