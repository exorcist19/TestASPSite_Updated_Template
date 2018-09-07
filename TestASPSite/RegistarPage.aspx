<%@ Page Title="" Language="C#" MasterPageFile="~/master.Master" AutoEventWireup="true" CodeBehind="RegistarPage.aspx.cs" Inherits="TestASPSite.RegistarPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Body" runat="server">
    <%--Error container--%>
    <asp:Label  runat="server" ID="output" Text="Click Me" style="color: white;" />
    
    <%--username fields--%>
    <label style="color: white;"> Username: </label>
    <input runat="server" style="color: white;" type="text" ID="username" value="" placeholder="username" />
    
    <%--password fields--%>
    <label style="color: white;"> Password: </label>
    <input runat="server" style="color: white;" type="password" ID="password" value="" placeholder="*********" />
    
    <%--confimation fields--%>
    <label style="color: white;"> Confirmation: </label>
    <input runat="server" style="color: white;" type="password" ID="confirmation" value="" placeholder="*********" />
    
    <style>
        .myButton {
            .Body_myButton
            background-color: white;
            color: white;
            font-size: 20px;
        }

        input {
            color: white;
        }

    </style>
    
    <%--submit button--%>
    <asp:Button runat="server" class=".Body_myButton" onClick="BtnHandle" Text="Click Me" />
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainFooter" runat="server">
</asp:Content>
