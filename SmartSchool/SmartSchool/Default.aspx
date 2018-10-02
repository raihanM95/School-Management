<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="SmartSchool._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <center>
        <h1>
            <asp:Label ID="Label1" runat="server" Text="Welcome"></asp:Label>
        </h1>
    </center>
    
    <asp:Image ID="Image1" runat="server" Height="700px" ImageUrl="~/Image/arseniy-chebynkin-school1.jpg" Width="1170px"/>
    
</asp:Content>
