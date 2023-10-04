<%@ Page Title="Shop" Language="C#" MasterPageFile="~/Forms/frmTemplate.Master" AutoEventWireup="true" CodeBehind="frmShop.aspx.cs" Inherits="MagicTableTopGamingWebsite.Forms.frmShop" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 135px;
            height: 255px;
        }
        .auto-style2 {
            height: 255px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="content">
    <div class="shopItem">
        <img src="Images/MTG-March-Of-The-Machine-Set-Booster-Box.jpg" class="auto-style2">
        <asp:TextBox ID="TextBox3" runat="server" Enabled="False" Font-Bold="True" Width="290px">March of the Machine Set Booster Box</asp:TextBox>
        <asp:TextBox ID="TextBox4" runat="server" Enabled="False" Font-Bold="True" Width="290px">£114.99</asp:TextBox>
        <p>
            <asp:Button ID="Button1" runat="server" OnClick="btnBuy1_Click" Text="Buy" />
        </p>
    </div>
    <div class="shopItem">
        <img src="Images/ultra-pro-matte-red-100.jpg" class="auto-style1">
        <asp:TextBox ID="TextBox1" runat="server" Enabled="False" Font-Bold="True" Width="290px">Ultra Pro Matte Red Card Sleeves</asp:TextBox>
        <asp:TextBox ID="TextBox2" runat="server" Enabled="False" Font-Bold="True" Width="290px">£10.99</asp:TextBox>
        <p>
            <asp:Button ID="btnBuy2" runat="server" OnClick="btnBuy2_Click" Text="Buy" />
        </p>
    </div>
        <div class="shopItem">
        <img src="Images/Old-Hat-Play-Mat.jpg" class="auto-style2">
        <asp:TextBox ID="TextBox5" runat="server" Enabled="False" Font-Bold="True" Width="290px">Old Hat Play Mat</asp:TextBox>
        <asp:TextBox ID="TextBox6" runat="server" Enabled="False" Font-Bold="True" Width="290px">£20.99</asp:TextBox>
        <p>
            <asp:Button ID="btnBuy3" runat="server" OnClick="btnBuy3_Click" Text="Buy" />
        </p>
    </div>
        </div>
    <div class="content">
        <div class="shopItem">
        <img src="Images/Mana-Crypt.jpg" class="auto-style2">
        <asp:TextBox ID="TextBox7" runat="server" Enabled="False" Font-Bold="True" Width="290px">Mana Crypt</asp:TextBox>
        <asp:TextBox ID="TextBox8" runat="server" Enabled="False" Font-Bold="True" Width="290px">£120.99</asp:TextBox>
        <p>
            <asp:Button ID="btnBuy4" runat="server" OnClick="btnBuy4_Click" Text="Buy" />
        </p>
        </div>
        <div class="shopItem">
        <img src="Images/The-Ur-Dragon.jpg" class="auto-style2">
        <asp:TextBox ID="TextBox9" runat="server" Enabled="False" Font-Bold="True" Width="290px">The Ur-Dragon</asp:TextBox>
        <asp:TextBox ID="TextBox10" runat="server" Enabled="False" Font-Bold="True" Width="290px">£80.00</asp:TextBox>
        <p>
            <asp:Button ID="btnBuy5" runat="server" OnClick="btnBuy5_Click" Text="Buy" />
        </p>
        </div>
        <div class="shopItem">
        <img src="Images/Atraxa-Praetors-Voice.jpg" class="auto-style2">
        <asp:TextBox ID="TextBox11" runat="server" Enabled="False" Font-Bold="True" Width="290px">Atraxa, Preators' Voice</asp:TextBox>
        <asp:TextBox ID="TextBox12" runat="server" Enabled="False" Font-Bold="True" Width="290px">£34.99</asp:TextBox>
        <p>
            <asp:Button ID="btnBuy6" runat="server" OnClick="btnBuy6_Click" Text="Buy" />
        </p>
        </div>
        </div>
</asp:Content>
