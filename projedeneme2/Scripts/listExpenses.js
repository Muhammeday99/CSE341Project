let expenseName = document.getElementById("ExpenseName");
let expenseCode = document.getElementById("ExpenseCode");
let expenseDate = document.getElementById("ExpenseDate");
let expenseAmount = document.getElementById("ExpenseAmount");
let sizeList = document.getElementById("sizeList");
let listPage = document.getElementById("listPage").getElementsByTagName("li");
let prev = listPage[0].getElementsByTagName("a")[0];
let next = listPage[listPage.length - 1].getElementsByTagName("a")[0];
let info = document.getElementById("dataTable_info");
let expenseList;


PageMethods.getExpenses(OnSuccess);

function OnSuccess(response) {
    expenseList = JSON.parse(response);
    sizeList.options[0].value = 10;
    listExpenses(expenseList);
}

sizeList.onchange = () => {
    let size = Number(sizeList.options[sizeList.selectedIndex].value);
    if (size > expenseList.length) size = expenseList.length;
    Index = 0;
    info.innerHTML = "Showing " + Number(Index + 1) + " to " + Number(Index + size) + " of " + expenseList.length;
    listExpenses(expenseList, size, Index);
}

next.onclick = () => {
    let size = Number(sizeList.options[sizeList.selectedIndex].value);
    if (size > expenseList.length) size = expenseList.length;
    Index = Index + Number(size);
    if (Index >= expenseList.length) {
        Index = Index - Number(size);
    }
    let end = Index + size;
    if (end > expenseList.length) {
        end = expenseList.length;
    }

    info.innerHTML = "Showing " + Number(Index + 1) + " to " + Number(end) + " of " + expenseList.length;
    listExpenses(expenseList, size, Index);
}

prev.onclick = () => {
    let size = Number(sizeList.options[sizeList.selectedIndex].value);
    if (size > expenseList.length) size = expenseList.length;
    Index = Index - Number(size);
    if (Index < 0) {
        Index = 0;
    }
    info.innerHTML = "Showing " + Number(Index + 1) + " to " + Number(Index + size) + " of " + expenseList.length;
    listExpenses(expenseList, size, Index);
}

function listExpenses(expenses, size = expenses.length, startIndex = 0) {
    let Tbody = document.getElementById("expenseTable").getElementsByTagName("tbody")[0];
    Tbody.innerHTML = "";
    let finishIndex = Number(size) + Number(startIndex)
    if (finishIndex > expenses.length) {
        finishIndex = expenses.length;
    }

    for (let i = startIndex; i < finishIndex; i++) {
        expense = expenses[i];
        Trow = Tbody.insertRow();
        for (let e in expense) {
            if (e != "Id") {
                let Tcell = Trow.insertCell();
                let value = expense[e];
                if (e == "ExpenseDate") {
                    let date = new Date(value);
                    value = date.getDate() + '/' + (date.getMonth() + 1) + '/' + date.getFullYear();
                }
                let node = document.createTextNode(value);
                Tcell.appendChild(node);
            }
        }
        let Tcell = Trow.insertCell();
        let btn = document.createElement("button");
        btn.setAttribute("id", "delete" + i);
        btn.addEventListener("click", () => {
            Tbody.deleteRow(i);
        })
        //btn.type = "submit";
        btn.innerHTML = "Sil?";
        btn.setAttribute("class", "btn btn-warning btn-sm");
        Tcell.appendChild(btn);
        
    }
    
}
