<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="SmartSchool.Register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>ForgotPassword</title>
    <link href="Bootstrap/bootstrap.min.css" rel="stylesheet" />
    <link href="Bootstrap/Style.css" rel="stylesheet" />
</head>
<body style ="background-image:url('Image/Background-3.jpg')">
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
                                <asp:Label ID="Label1" runat="server" Text="Email" Font-Bold="True"></asp:Label>
                            </div>
                            <div>
                                <asp:TextBox ID="txtREmail" runat="server" Height="30" Width="250" TextMode="Email" ToolTip="Enter your Email"></asp:TextBox>
                            </div>
                            <br />
                            <div>
                                <asp:Label ID="Label2" runat="server" Text="Username" Font-Bold="True"></asp:Label>
                            </div>
                            <div>
                                <asp:TextBox ID="txtRUsername" runat="server" Height="30" Width="250" ToolTip="Username"></asp:TextBox>
                            </div>
                            <br />
                            <div>
                                <asp:Label ID="Label3" runat="server" Text="Password" Font-Bold="True"></asp:Label>
                            </div>
                            <div>
                                <asp:TextBox ID="txtRPassword" runat="server" Height="30" Width="250" TextMode="Password" ToolTip="Password"></asp:TextBox>
                            </div>
                            <br />
                            <div>
                                <asp:Label ID="Label4" runat="server" Text="Confirm Password" Font-Bold="True"></asp:Label>
                            </div>
                            <div>
                                <asp:TextBox ID="txtRCPassword" runat="server" Height="30" Width="250" TextMode="Password" ToolTip="Confirm Password"></asp:TextBox>
                                <asp:Button ID="btnRegister" runat="server" Text="Register" Height="30px" Width="80px" BackColor="#9900FF" BorderColor="#990099" ForeColor="White" OnClick="btnRegister_Click"/>
                                
                            </div>
                            <div>
                                <asp:Label ID="lblMessage" runat="server" ForeColor="#CC0000"></asp:Label>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>

    </form>
</body>
</html>
