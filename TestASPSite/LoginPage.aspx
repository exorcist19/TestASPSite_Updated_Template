<%@ Page Title="" Language="C#" MasterPageFile="~/master.Master" AutoEventWireup="true" CodeBehind="LoginPage.aspx.cs" Inherits="TestASPSite.LoginPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Body" runat="server">
    <asp:Label  runat="server" ID="output" Text="Click Me" style="color: white;" />
    <label style="color: white;"> Username: </label>
    
    <input runat="server" style="color: white;" type="text" ID="username" value="" placeholder="bob dillian 123" />
    <label style="color: white;"> Password: </label>
    <input runat="server" style="color: white;" type="password" ID="password" value="" placeholder="*********" />
    <style>
        .myButton {
           
            background-color: white;
            color: white;
            font-size: 20px;
        }

       

    </style>
    <asp:Button runat="server" class=".Body_myButton" onClick="BtnHandle" Text="Click Me" />



</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainFooter" runat="server">
</asp:Content>
