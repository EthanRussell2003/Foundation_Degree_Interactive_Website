<%@ Page Title="Discussion" Language="C#" MasterPageFile="~/Forms/frmTemplate.Master" AutoEventWireup="true" CodeBehind="frmDiscussion.aspx.cs" Inherits="MagicTableTopGamingWebsite.Forms.frmDiscussion" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1 style="color: white; margin: 20px;">
        Discussion Rules:
    </h1>
    <ul style="color: white; margin-left: 40px;">
        <li>Be respectful to other users</li>
        <li>Don't post or ask for private details</li>
        <li>No profanity</li>
        <li>Have fun!</li>
    </ul>
    <asp:TextBox CssClass="blog" ID="txtBlog" runat="server" Font-Names="x-large" Height="330px" TextMode="MultiLine" Width="978px" ReadOnly="True"></asp:TextBox>
    <br>
    <asp:TextBox ID="txtEntry" runat="server" Font-Names="x-large" Height="28px" style="margin-left: 50px; margin-right: 15px; margin-bottom: 20px;"></asp:TextBox>
    <asp:Button ID="btnSend" runat="server" OnClick="btnSend_Click" Text="Send" style="margin-bottom: 20px;" />
</asp:Content>
