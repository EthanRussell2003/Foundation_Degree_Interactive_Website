<%@ Page Title=" Cart" Language="C#" MasterPageFile="~/Forms/frmTemplate.Master" AutoEventWireup="true" CodeBehind="frmCart.aspx.cs" Inherits="MagicTableTopGamingWebsite.Forms.frmCart" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script type ="text/javascript">
    function emptyCart() {
                var reply = confirm("Cart must have items to checkout");
                return reply;
        }
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p class="whiteCenter">
    <asp:Label ID="lblOrderSummary" runat="server" CssClass="demoInfo"></asp:Label>
    </p>
    <asp:Panel ID="pnlOrders" runat="server" style="color: white; text-align: center;">
    </asp:Panel>
    <p class="whiteCenter">
        <asp:Label ID="lblTotalCost" runat="server" CssClass="cartInfo"></asp:Label>
    </p>
    <p class="whiteCenter">
        <asp:Button ID="btnClear" runat="server" Text="Clear Basket" onclick="btnClear_Click" CssClass="demoInfo" OnClientClick="return areyousure()"/>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnCheckout" runat="server" OnClick="btnCheckout_Click" Text="Checkout" CssClass="demoInfo" OnClientClick="return checkout()"/>
    </p>
</asp:Content>
