function AddNewRow(RowNum) {
    
}

let RowNum = 1;

let addButton = document.getElementById("NewContentBtn");
addButton.setAttribute("href", "javascript:void(0)");
addButton.onclick = () => {
    let Tbody = document.getElementById("DetailTable").getElementsByTagName("tbody")[0];


    let Row = Tbody.getElementsByTagName("tr")[RowNum].cloneNode(true);
    
    //let Rows = [];
    //Rows.push(Row);

    
    RowNum++;
    Row.setAttribute("id", "Content" + RowNum);
    let cn = Row.childNodes;
    console.log(cn[0]);
    Tbody.appendChild(Row);
    
};

