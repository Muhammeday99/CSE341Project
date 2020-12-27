let ProjectsInfo;
let sizeList = document.getElementById("ListSize");
let listPage = document.getElementById("listPage").getElementsByTagName("li");
let next = listPage[listPage.length - 1].getElementsByTagName("a")[0];
let prev = listPage[0].getElementsByTagName("a")[0];
let info = document.getElementById("dataTable_info");
let Index = 0;
PageMethods.getProjectsInfo(OnSuccess);

function OnSuccess(response) {
    ProjectsInfo = JSON.parse(response);
    console.log(ProjectsInfo);
    sizeList.options[0].value = ProjectsInfo.length;
    info.innerHTML = "Showing " + Number(Index + 1) + " to " + ProjectsInfo.length + " of " + ProjectsInfo.length;
    listProjects(ProjectsInfo);
}

sizeList.onchange = () => {
    let size = Number(sizeList.options[sizeList.selectedIndex].value);
    if (size > ProjectsInfo.length) size = ProjectsInfo.length;
    Index = 0;
    info.innerHTML = "Showing " + Number(Index + 1) + " to " + Number(Index + size) + " of " + ProjectsInfo.length;
    listElements(ProjectsInfo, size, Index);
}

next.onclick = () => {
    let size = Number(sizeList.options[sizeList.selectedIndex].value);
    if (size > ProjectsInfo.length) size = ProjectsInfo.length;
    Index = Index + Number(size);
    if (Index >= ProjectsInfo.length) {
        Index = Index - Number(size);
    }
    let end = Index + size;
    if (end > ProjectsInfo.length) {
        end = ProjectsInfo.length;
    }

    info.innerHTML = "Showing " + Number(Index + 1) + " to " + Number(end) + " of " + ProjectsInfo.length;
    listElements(ProjectsInfo, size, Index);
}
prev.onclick = () => {
    let size = Number(sizeList.options[sizeList.selectedIndex].value);
    if (size > ProjectsInfo.length) size = ProjectsInfo.length;
    Index = Index - Number(size);
    if (Index < 0) {
        Index = 0;
    }
    info.innerHTML = "Showing " + Number(Index + 1) + " to " + Number(Index + size) + " of " + ProjectsInfo.length;
    listElements(ProjectsInfo, size, Index);
}

function listProjects(Projectslist, size = Projectslist.length, startIndex=0) {
    let Tbody = document.getElementById("ProjectsTable").getElementsByTagName("tbody")[0];
    Tbody.innerHTML = "";
    let finishIndex = Number(size) + Number(startIndex)
    if (finishIndex > ProjectsInfo.length) {
        finishIndex = ProjectsInfo.length;
    }
    for (let i = startIndex; i < finishIndex; i++) {
        Project = Projectslist[i];
        let row = Tbody.insertRow();
        for (let e in Project) {
            if (e != "id") {
                let cell = row.insertCell();
                let element = Project[e];
                let node = document.createTextNode(element);
                cell.appendChild(node);
            }
        }
    }
}