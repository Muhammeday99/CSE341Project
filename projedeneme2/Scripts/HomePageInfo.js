/*
 Entity_Card_Count
 Total_Expense
 Invoice_Count
 Total_Invoice_Amount
 Project_Count
 Total_Project_Amount
 Todays_USD_ExchangeRate
 Worker_Count
 */
PageMethods.getCountInfo(OnSuccess);
PageMethods.getTotalAmounts(OnSuccess_TotalAmount);
PageMethods.getProjectNames(OnSuccess_ProjectNames);
getTodaysUSDExchangeRate();

function OnSuccess(response) {
    EntityCount = document.getElementById("Entity_Card_Count");
    InvoiceCount = document.getElementById("Invoice_Count");
    ProjectCount = document.getElementById("Project_Count");
    WorkerCount = document.getElementById("Worker_Count");

    EntityCount.innerHTML = response[0];
    InvoiceCount.innerHTML = response[1];
    ProjectCount.innerHTML = response[2];
    WorkerCount.innerHTML = response[3];
}

function OnSuccess_TotalAmount(response) {
    TotalInvoiceAmount = document.getElementById("Total_Invoice_Amount");
    TotalProjectAmount = document.getElementById("Total_Project_Amount");
    TotalExpense = document.getElementById("Total_Expense");

    TotalInvoiceAmount.innerHTML = response[0] + " TL";
    TotalProjectAmount.innerHTML = response[1] + " TL";
    TotalExpense.innerHTML = response[2] + " TL";
}

function OnSuccess_ProjectNames(response) {
    let list = document.getElementById("ProjectList");
    let elements = list.getElementsByTagName("li");

    for (let i = 0; i < elements.length; i++) {
        elements[i].getElementsByTagName("div")[0].getElementsByTagName("div")[0].getElementsByTagName("h6")[0].getElementsByTagName("strong")[0].innerHTML = response[i];
    }
}

function getTodaysUSDExchangeRate() {
    let api_url = 'https://api.exchangeratesapi.io/latest?base=USD';
    getApi(api_url);
}

async function getApi(api_url) {
    const response = await fetch(api_url);
    const data = await response.json();
    let USD = await data.rates.TRY;
    document.getElementById("Todays_USD_ExchangeRate").innerHTML = USD.toFixed(3);
}