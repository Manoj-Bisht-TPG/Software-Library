<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeBehind="Default.aspx.cs" Inherits="NTierWebUI._Default" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <h2>
        Demo logging
    </h2>
    <p>
        <asp:Button Text="Divided by zero" runat="server" OnClick="Unnamed1_Click" />
    </p>
    <p>
        <asp:Label ID="Label1" runat="server" Font-Bold="True" ForeColor="#33CC33"></asp:Label>
    </p>
</asp:Content>
