<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="SmartSchool.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Login</title>
    <link href="Bootstrap/bootstrap.min.css" rel="stylesheet" />
    <link href="Bootstrap/Style.css" rel="stylesheet" />
</head>
<body style ="background-image:url('Image/Background.jpg')">
    <form id="form1" runat="server">
    <div class="panel-img">
        <img src="Image/Panel.png" />
    </div>

        <div>
            <div style="position:absolute; z-index:1;" id="layerl">
                <div class="modal-body" style="margin:30px 0px 0px 400px;">
                    <div class ="row">
                        <div class="col-xs-12">
                            <div>
                                <asp:Label ID="Label1" runat="server" Text="Username" Font-Bold="True"></asp:Label>
                            </div>
                            <div>
                                <asp:TextBox ID="txtUsername" runat="server" Height="30" Width="250" ToolTip="Enter your Username"></asp:TextBox>
                            </div>
                            <br />
                            <div>
                                <asp:Label ID="Label2" runat="server" Text="Password" Font-Bold="True"></asp:Label>
                            </div>
                            <div>
                                <asp:TextBox ID="txtPassword" runat="server" Height="30" Width="250" TextMode="Password" ToolTip="Password"></asp:TextBox>
                                <asp:Label ID="lblMessage" runat="server" ForeColor="#CC0000"></asp:Label>
                            </div>
                            <br />
                            <div>
                                <asp:Button ID="btnLogin" runat="server" Text="Login" BackColor="#00BF60" BorderColor="#00B359" ForeColor="White" OnClick="btnLogin_Click" />
                            </div>
                            <asp:HyperLink ID="hlForgotpassword" runat="server" Font-Italic="True" ForeColor="#800040" NavigateUrl="~/ForgotPassword.aspx">Forgot password?</asp:HyperLink>
                        </div>
                    </div>
                </div>
            </div>
        </div>

    </form>
</body>
</html>
