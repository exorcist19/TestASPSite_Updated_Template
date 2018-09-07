<%@ Page Title="" Language="C#" MasterPageFile="~/master.Master" AutoEventWireup="true" CodeBehind="DashboardPage.aspx.cs" Inherits="TestASPSite.DashboardPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Body" runat="server">
    <asp:Label runat="server" ID="output" Text="Going to change" /><br />
       
        <img src="https://api.adorable.io/avatars/280/<%= Request.Cookies.Get("authenticated").Values  %>@adorable.io" alt="avatar" />
        <div> Authenticated: <%= Request.Cookies.Get("authenticated").Values  %></div>
        <div> User ID: <%= Request.Cookies.Get("user_id").Values  %></div>
        
        
        
        
         <style>



        </style>



</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainFooter" runat="server">
</asp:Content>
