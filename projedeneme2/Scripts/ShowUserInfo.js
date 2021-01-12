let UNspan = document.getElementById("UserNameSpan");
let UserPP = document.getElementById("ProfilePicture");

PageMethods.getUserInfo(OnSuccess);

function OnSuccess(response, userContext, methodName) {
    UNspan.innerHTML = response[0];
    UserPP.setAttribute("src", response[3]);
}


