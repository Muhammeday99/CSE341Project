let Xmlhttp = new XMLHttpRequest();
let Accounts;
Xmlhttp.onreadystatechange = function () {
    if (this.readyState == 4 && this.status == 200) {
        Accounts = JSON.parse(this.responseText);
        listElements(Accounts);

    }
}

Xmlhttp.open("GET", "../AdminPage/Users.json", true);
Xmlhttp.send();

function listElements(Accounts) {
    for (let i = 0; i < Accounts.length; i++) {
        let imgUrl = Accounts[i].ProfilePicture;
        console.log(imgUrl);
        let imgId = "GridView1_ProfilePicture_" + i;
        let img = document.getElementById(imgId);
        img.setAttribute("src", imgUrl);
    }

    /*let tablebody = document.getElementById("CurrencyDataTable").getElementsByTagName("tbody")[0];
    for (let i = 0; i < Accounts.length; i++) {
        let element = Accounts[i];
        let Trow = tablebody.insertRow();
        for (let e in element) {
            let Tcell = Trow.insertCell();
            let value = element[e];
            let cellContent;
            if (e == "ProfilePicture") {
                cellContent = document.createElement("img");
                cellContent.setAttribute("src", value);

            } else {
                cellContent = document.createTextNode(value);
            }
            Tcell.appendChild(cellContent);
        }
    }*/
}