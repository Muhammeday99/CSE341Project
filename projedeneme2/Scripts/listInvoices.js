let invoices;
let sizeList = document.getElementById("ListSelect");
let listPage = document.getElementById("listPage").getElementsByTagName("li");
let next = listPage[listPage.length - 1].getElementsByTagName("a")[0];
let prev = listPage[0].getElementsByTagName("a")[0];
let info = document.getElementById("dataTable_info");

PageMethods.getInvoices(OnSuccess);

function OnSuccess(response) {
    invoices = JSON.parse(response);
    sizeList.options[0].value = invoices.length;
    listElements(invoices);
}

sizeList.onchange = () => {
    let size = Number(sizeList.options[sizeList.selectedIndex].value);
    if (size > invoices.length) size = invoices.length;
    Index = 0;
    info.innerHTML = "Showing " + Number(Index + 1) + " to " + Number(Index + size) + " of " + invoices.length;
    listElements(invoices, size, Index);
}

next.onclick = () => {
    let size = Number(sizeList.options[sizeList.selectedIndex].value);
    if (size > invoices.length) size = invoices.length;
    Index = Index + Number(size);
    if (Index >= invoices.length) {
        Index = Index - Number(size);
    }
    let end = Index + size;
    if (end > invoices.length) {
        end = invoices.length;
    }
    info.innerHTML = "Showing " + Number(Index + 1) + " to " + Number(end) + " of " + invoices.length;
    listElements(invoices, size, Index);
}
prev.onclick = () => {
    let size = Number(sizeList.options[sizeList.selectedIndex].value);
    if (size > invoices.length) size = invoices.length;
    Index = Index - Number(size);
    if (Index < 0) {
        Index = 0;
    }
    info.innerHTML = "Showing " + Number(Index + 1) + " to " + Number(Index + size) + " of " + invoices.length;
    listElements(invoices, size, Index);
}

function listElements(invoiceList, size = invoiceList.length, startIndex = 0) {
    let tablebody = document.getElementById("dataTable").getElementsByTagName("tbody")[0];
    tablebody.innerHTML = "";
    //console.log(size);
    let finishIndex = Number(size) + Number(startIndex)
    if (finishIndex > invoices.length) {
        finishIndex = invoices.length;
    }
    for (let i = startIndex; i < finishIndex; i++) {
        if (i >= invoiceList.length) break;
        let invoice = invoiceList[i];
        let Trow = tablebody.insertRow();
        for (let e in invoice) {
            if (e != "id") {
                let Tcell = Trow.insertCell();
                let value = invoice[e];
                if (e == "CurrencyId") {
                    if (value == "1") {
                        value = "TRY";
                    } else if (value == "2") {
                        value = "USD";
                    } else if (value == "3") {
                        value = "EUR";
                    }
                }
                if (e == "InvoiceDate" || e == "PaymentDate") {
                    let date = new Date(value);
                    value = date.getDate() + '/' + (date.getMonth() + 1) + '/' + date.getFullYear();
                }
                let text = document.createTextNode(value);

                Tcell.appendChild(text);
            }
        }
        let Tcell = Trow.insertCell();
        let amount = Number(invoice["Amount"]);
        let KDVP = Number(invoice["KDVpercentage"]) * 0.01;
        let KDV = amount * KDVP;
        let total = amount + KDV;
        let text = document.createTextNode(total);

        Tcell.appendChild(text);
    }
}