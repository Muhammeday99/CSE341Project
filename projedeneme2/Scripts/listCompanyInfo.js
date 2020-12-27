let CompanyInfo;

PageMethods.getCompanyInfo(OnSuccess);

function OnSuccess(response) {
    CompanyInfo = JSON.parse(response);
    console.log(CompanyInfo);
    let tablebody = document.getElementById("CompanyInfoTable").getElementsByTagName("tbody")[0];
    let trs = tablebody.rows;
    let i = 1;
    for (let j = 0; j < trs.length;j++) {
        let tds = trs[j].cells;
        tds[1].innerHTML = CompanyInfo[0][Object.keys(CompanyInfo[0])[i++]]
    }
}