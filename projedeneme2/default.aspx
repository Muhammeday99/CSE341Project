<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="projedeneme2.Default" %>

<!DOCTYPE html>
<html>

<head>
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0, shrink-to-fit=no">
    <title>Login - 5M Macro</title>
    <meta name="description" content="In this software project we will make a project process tracking system for companies. The &quot;tracking&quot; means in this project is:

⦁	Progress for work 
⦁	Paying fees to various clients
⦁	Work done by company employees

A company uses this software will easily track their process by using features of this software mentioned above.">
    <link rel="stylesheet" href="assets/bootstrap/css/bootstrap.min.css">
    <link rel="stylesheet" href="https://fonts.googleapis.com/css?family=Nunito:200,200i,300,300i,400,400i,600,600i,700,700i,800,800i,900,900i">
    <link rel="stylesheet" href="assets/fonts/fontawesome-all.min.css">
    <link rel="stylesheet" href="assets/fonts/font-awesome.min.css">
    <link rel="stylesheet" href="assets/fonts/fontawesome5-overrides.min.css">
</head>

<body class="bg-gradient-primary" style="background: rgb(49,115,163);color: rgb(0,85,164);">
    
    <div class="container">
        <div class="row justify-content-center">
            <div class="col-md-9 col-lg-12 col-xl-11 offset-xl-0">
                <div class="card shadow-lg o-hidden border-0 my-5">
                    <div class="card-body p-0">
                        <div class="row">
                            <div class="col-lg-5 col-xl-5 offset-lg-0 d-none d-lg-flex">
                                <div class="flex-grow-1 bg-login-image" style="background-image: url(&quot;assets/img/dogs/image3.jpeg&quot;);"></div>
                            </div>
                            <div class="col-lg-7 col-xl-7">
                                <div class="p-5">
                                    <div class="text-center">
                                        <h4 class="text-dark mb-4">Login Screen</h4>
                                    </div>
                                    <form class="user" runat="server">
                                        <div class="form-group"><asp:TextBox class="form-control form-control-user" type="email" id="InputEmail" aria-describedby="emailHelp" placeholder="Enter Email Address..." name="email" runat="server"> </asp:TextBox></div>
                                        <div class="form-group"><asp:TextBox class="form-control form-control-user" type="password" id="InputPassword" placeholder="Password" name="password" runat="server"></asp:TextBox></div>
                                        <div class="form-group">
                                            <div class="custom-control custom-checkbox small">
                                                <div class="form-check"><input class="form-check-input custom-control-input" type="checkbox" id="formCheck-1"><label class="form-check-label custom-control-label" for="formCheck-1">Remember Me</label></div>
                                            </div>
                                        </div><asp:Button class="btn btn-primary btn-block text-white btn-user" type="submit" OnClick="LoginButton_Click" style="background: rgb(49,115,163);color: rgb(0,85,164);" text="Login" runat="server"/>
                                        <asp:Label ID="statusLabel" Text="deneme" runat="server"></asp:Label>
                                        <hr>
                                    </form>
                                    <div class="text-center"><a class="small" href="forgot-password.html" style="color: rgb(0,85,164);">Forgot Password?</a></div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <script src="assets/js/jquery.min.js"></script>
    <script src="assets/bootstrap/js/bootstrap.min.js"></script>
    <script src="assets/js/chart.min.js"></script>
    <script src="assets/js/bs-init.js"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/jquery-easing/1.4.1/jquery.easing.js"></script>
    <script src="assets/js/theme.js"></script>
</body>

</html>