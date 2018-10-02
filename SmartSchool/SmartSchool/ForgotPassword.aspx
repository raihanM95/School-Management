<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ForgotPassword.aspx.cs" Inherits="SmartSchool.ForgotPassword" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>ForgotPassword</title>
    <link href="Bootstrap/bootstrap.min.css" rel="stylesheet" />
    <link href="Bootstrap/Style.css" rel="stylesheet" />
</head>
<body style ="background-image:url('Image/Background-2.jpg')">
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
                                <asp:TextBox ID="txtFEmail" runat="server" Height="30" Width="250" TextMode="Email" ToolTip="Enter your Email"></asp:TextBox>
                                <asp:Label ID="lblEmailMessage" runat="server" ForeColor="#CC0000"></asp:Label>
                            </div>
                            <br />
                            <div>
                                <asp:Label ID="Label2" runat="server" Text="Password" Font-Bold="True"></asp:Label>
                            </div>
                            <div>
                                <asp:TextBox ID="txtFPassword" runat="server" Height="30" Width="250" TextMode="Password" ToolTip="Password"></asp:TextBox>
                            </div>
                            <br />
                            <div>
                                <asp:Label ID="Label3" runat="server" Text="Confirm Password" Font-Bold="True"></asp:Label>
                            </div>
                            <div>
                                <asp:TextBox ID="txtFCPassword" runat="server" Height="30" Width="250" TextMode="Password" ToolTip="Confirm Password"></asp:TextBox>
                                <asp:Label ID="lblPassMessage" runat="server" ForeColor="#CC0000"></asp:Label>
                            </div>
                            <br />
                            <asp:Button ID="btnFSubmit" runat="server" Text="Submit" Height="30px" Width="250px" BackColor="#00BF60" BorderColor="#00B359" ForeColor="White" OnClick="btnFSubmit_Click" />
                        </div>
                    </div>
                </div>
            </div>
        </div>

    </form>
</body>
</html>
