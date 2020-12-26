let UNspan = document.getElementById("UserNameSpan");
let UserPP = document.getElementById("ProfilePicture");

PageMethods.getUserInfo(OnSuccess);

function OnSuccess(response, userContext, methodName) {
    let UserInfo = JSON.parse(response);
    UNspan.innerHTML = UserInfo[0]["UserEmail"];
    UserPP.setAttribute("src", UserInfo[0]["ProfilePicture"]);
}


