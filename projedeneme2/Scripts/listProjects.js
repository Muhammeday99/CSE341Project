let ProjectsInfo;
PageMethods.getProjectsInfo(OnSuccess);

function OnSuccess(response) {
    console.log(response);
    ProjectsInfo = JSON.parse(response);
    console.log(ProjectsInfo);
    listProjects(ProjectsInfo);
    

}

function listProjects(Projectslist, size = Projectslist.length, start=0) {
    let Tbody = document.getElementById("ProjectsTable").getElementsByTagName("tbody")[0];
    Tbody.innerHTML = "";
    for (let i = start; i < size; i++) {
        Project = Projectslist[i];
        let row = Tbody.insertRow();
        for (let e in Project) {
            let cell = row.insertCell();
            //if (Project[e] == "")
            let element = Project[e];
            let node = document.createTextNode(element);
            cell.appendChild(node);
        }
    }
}