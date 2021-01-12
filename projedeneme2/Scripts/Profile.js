let Email = document.getElementById("Email");
let name = document.getElementById("UserName");
let surname = document.getElementById("UserSurname");
let PPictureUpload = document.getElementById("PPUpload");
let PPicture = document.getElementById("PPOverview");
let status = document.getElementById("UserStatus");



PageMethods.getUserInfo(OnSuccess)

function OnSuccess(response) {
    console.log(response);

    name.value = response[0];
    surname.value = response[1];
    Email.value = response[2];
    PPicture.setAttribute("src", response[3]);
    status.value = response[4] == "False" ? "Employee" : "Administrator";
}

PPictureUpload.onchange = () => {
    PPicture.src = URL.createObjectURL(PPictureUpload.files[0]);
}