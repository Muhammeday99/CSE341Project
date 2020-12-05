let Xmlhttp = new XMLHttpRequest();
let ExchangeList;
Xmlhttp.onreadystatechange = function () {
    if (this.readyState == 4 && this.status == 200)
    {
        ExchangeList = JSON.parse(this.responseText);
        listElements(ExchangeList);

    }
}

Xmlhttp.open("GET", "../DovizKurTanim/ExchangeList.json", true);
Xmlhttp.send();


function listElements(ExchangeList)
{
    let tablebody = document.getElementById("CurrencyDataTable").getElementsByTagName("tbody")[0];

    for (let i = 0; i < ExchangeList.length; i++)
    {
        let Element = ExchangeList[i];
        let Trow = tablebody.insertRow();
        for (let e in Element)
        {
            let Tcell = Trow.insertCell();
            let value = Element[e];

            let text = document.createTextNode(value);

            Tcell.appendChild(text);
        }
    }
}

