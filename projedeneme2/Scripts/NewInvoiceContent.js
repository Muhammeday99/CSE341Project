let kdvPerc;

let addButton = document.getElementById("NewContentBtn");
addButton.setAttribute("href", "javascript:void(0)");

addButton.onclick = () => {
    let Tbody = document.getElementById("AddNewContent").getElementsByTagName("tbody")[0];

    let content = Tbody.rows[0];
    let contents = [];

    for (let i = 0; i < content.cells.length-1; i++) {
        contents.push(content.cells[i].childNodes[0].value);
    }
    addNewItem(contents);
};

let kdv = document.getElementById("KDVpercentage");

kdv.onchange = () => {
    kdvPerc = Number(kdv.options[kdv.selectedIndex].value);
    let amount = document.getElementById("Amount");
    let kdvAmount = document.getElementById("KDVamount");
    let total = document.getElementById("TotalAmount");

    kdvAmount.value = Number(amount.value) * kdvPerc / 100;
    total.value = Number(kdvAmount.value) + Number(amount.value);
}

function addNewItem(contents) {
    let ContentTable = document.getElementById("ContentTable").getElementsByTagName("tbody")[0];
    let row = ContentTable.insertRow();
    for (let i = 0; i < contents.length; i++) {
        let cell = row.insertCell();
        let node = document.createTextNode(contents[i]);
        cell.appendChild(node);
    }
}

