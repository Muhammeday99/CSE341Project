var tablebody = document.getElementById("dataTable").getElementsByTagName("tbody")[0];

let tRow = tablebody.insertRow();

let newcell = tRow.insertCell();

let text = document.createTextNode("Hello");

newcell.appendChild(text);

newcell = tRow.insertCell();
text = document.createTextNode("There");

newcell.appendChild(text);