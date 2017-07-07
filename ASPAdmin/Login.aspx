<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="ASPAdmin.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <link href="Content/SignIn.css" rel="stylesheet" />
    <title>ASP Admin</title>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">

            <div class="form-signin">
                <h1 style="text-align:center">Administração  ASP</h1>

               
            </div>

            <div class="form-signin">
               
                <label for="inputEmail" class="sr-only">Email address</label>
                <asp:TextBox runat="server" ID="txtUsername" TextMode="Email" CssClass="form-control" placeholder="Email"/>
                <label for="inputPassword" class="sr-only">Password</label>
                <asp:TextBox runat="server" ID="txtUserpassword" TextMode="Password" CssClass="form-control" placeholder="Senha"/>
                
                <asp:Button Text="LOGIN" runat="server" ID="btnLogin" OnClick="btnLogin_Click" CssClass="btn btn-lg btn-primary btn-block" />

            </div>

        </div>
        <!-- /container -->
    </form>

    <script src="Scripts/jquery-1.10.2.min.js"></script>
    <script src="Scripts/bootstrap.min.js"></script>

</body>
</html>
