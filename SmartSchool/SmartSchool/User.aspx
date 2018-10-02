<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="User.aspx.cs" Inherits="SmartSchool.User" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style ="background-image:url('Image/Background-4.jpeg')">
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="lblAccess" runat="server" Text=""></asp:Label>
        <asp:Button ID="btnLogOut" runat="server" Text="Logout" OnClick="btnLogOut_Click" />
    </div>
    <div>
        <center>
            <table>
                <br />
                <br />
                <br />
                <br />
                <br />
                <tr>
                    <asp:Button ID="btnStudents" runat="server" Text="Students" Height="30" Width="100" OnClick="btnStudents_Click"></asp:Button>
                    <asp:Button ID="btnTeachers" runat="server" Text="Teachers" Height="30" Width="100" OnClick="btnTeachers_Click"></asp:Button>
                    <asp:Button ID="btnNotice" runat="server" Text="Notice" Height="30" Width="100" OnClick="btnNotice_Click"></asp:Button>
                </tr>
            </table>
        </center>
    </div>
    </form>
</body>
</html>
