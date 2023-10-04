<%@ Page Title="Home" Language="C#" MasterPageFile="~/Forms/frmTemplate.Master" AutoEventWireup="true" CodeBehind="frmHome.aspx.cs" Inherits="MagicTableTopGamingWebsite.Forms.frmHome" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" href="https://unpkg.com/swiper@7/swiper-bundle.min.css"/>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="swiper">
            <div class="swiper-wrapper">
                <div class="swiper-slide"><img src="Images/march-of-the-machine-aftermath-preorder.jpg"></div>
                <div class="swiper-slide"><img src="Images/march-of-the-machine.jpg"></div>
                <div class="swiper-slide"><img src="Images/mtg-play-mats.jpg"></div>
                <div class="swiper-slide"><img src="Images/mtg-card-sleeves.jpg"></div>
            </div>
            <div class="swiper-pagination"></div>
            <div class="swiper-button-prev"></div>
            <div class="swiper-button-next"></div>
    </div>
    <div>
    <h1 style="text-align: center; color: white; margin: 40px auto;"> WELCOME TO MAGIC TABLE TOP GAMING </h1>
    <p class="whiteCenter">We are a small community hoping to grow into greater heights. Products are available from our <a href="frmShop.aspx"><Strong>Shop</Strong></a>. 
        To view account information visit our <a href="frmLogin.aspx"><Strong>Login</Strong></a> page. To learn more about us visit our <a href="frmAbout.aspx"><Strong>About Us</Strong></a> page.
            And if you wish to talk to some like-minded people visit our <a href="frmDiscussion.aspx"><Strong>Discussion</Strong></a> page!</p>
    <p class="whiteCenter">Thank you for the support!</p>
    </div>
    <script src="https://unpkg.com/swiper@7/swiper-bundle.min.js"></script>
    <script>
        var swiper = new Swiper('.swiper', {
            centeredSlides: true,
            slidesPerView: 'auto',
            loop: true,

            autoplay: {
                delay: 3000,
                disableOnInteraction: false,
            },

            pagination: {
                el: '.swiper-pagination',
                clickable: true,
            },

            navigation: {
                nextEl: '.swiper-button-next',
                prevEl: '.swiper-button-prev',
            },
        });
    </script>
</asp:Content>
