<%@ Page Title="Login" Language="C#" MasterPageFile="~/Forms/frmTemplate.Master" AutoEventWireup="true" CodeBehind="frmLogin.aspx.cs" Inherits="MagicTableTopGamingWebsite.Forms.frmLogin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="content">
    <div class="login">
        <h1 style="color: white;">Login</h1>
        <p>
            <strong><label style="color: white; text-align: left;">Username: &nbsp;</label></strong> <asp:TextBox ID="txtUsername" runat="server"></asp:TextBox>
        </p>
        <p>
            <strong><label style="color: white; text-align: left;">Password: &nbsp;</label></strong> <asp:TextBox ID="txtPassword" runat="server" type="password"></asp:TextBox> 
        </p>
        <asp:Label ID="lblOutput" runat="server" Text="" style="color: white;"></asp:Label> <br>
        <br><asp:Button ID="btnLogin" runat="server" OnClick="btnLogin_Click" Text="Login" />
    </div>
    <div class="register">
        <h1 style="color: white;">Register</h1>
        <p>
            <strong><label style="color: white; text-align: left;">Username: &nbsp;</label></strong> <asp:TextBox ID="txtRegUsername" runat="server"></asp:TextBox>
        </p>
        <p>
            <strong><label style="color: white; text-align: left;">Password: &nbsp;</label></strong> <asp:TextBox ID="txtRegPassword" runat="server" type="password"></asp:TextBox>
        </p>
        <asp:Label ID="lblRegOutput" runat="server" Text="" style="color: white;"></asp:Label> <br>
        <br><asp:Button ID="btnRegister" runat="server" OnClick="btnRegister_Click" Text="Register" />
    </div>
        </div>
</asp:Content>