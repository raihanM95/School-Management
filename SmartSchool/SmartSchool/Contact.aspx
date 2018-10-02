<%@ Page Title="Contact" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="SmartSchool.Contact" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %>.</h2>
    <address>
        Sylhet<br />
        Habiganj,51/A<br />
        <abbr>Phone:</abbr>
        425.555.0100
    </address>

    <address>
        <strong>Email:</strong><a href="mailto:sm@gmail.com">sm@gmail.com</a><br />
    </address>
</asp:Content>
