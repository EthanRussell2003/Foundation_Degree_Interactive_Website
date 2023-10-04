<%@ Page Title="Admin" Language="C#" MasterPageFile="~/Forms/frmTemplate.Master" AutoEventWireup="true" CodeBehind="frmAdmin.aspx.cs" Inherits="MagicTableTopGamingWebsite.Forms.Admin.frmAdmin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1 style="text-align: center; color: white;">All Orders</h1>
   <asp:Panel ID="pnlOrders" runat="server" style="color: white; text-align: center;">
       </asp:Panel>
    <p class="whiteCenter">
    <asp:Button ID="btnLogout" runat="server" OnClick="btnLogout_Click" Text="Logout" /> 
    </p>
</asp:Content>
