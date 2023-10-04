using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MagicTableTopGamingWebsite.App_Code;
using System.Collections;

namespace MagicTableTopGamingWebsite.Forms
{
    public partial class frmShop : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Page.MaintainScrollPositionOnPostBack = true;
        }

        protected void btnBuy1_Click(object sender, EventArgs e)
        {
            Trace.Warn("Adding an item to the cart");
            CartItem cartItem = new CartItem();
            cartItem.setCost(114.99);
            cartItem.setItemName("March of the Machine Set Booster Box");
            ArrayList arrCart = (ArrayList)Session["CART"];
            arrCart.Add(cartItem);
            Session.Add("CART", arrCart);
        }

        protected void btnBuy2_Click(object sender, EventArgs e)
        {
            Trace.Warn("Adding an item to the cart");
            CartItem cartItem = new CartItem();
            cartItem.setCost(10.99);
            cartItem.setItemName("Ultra Pro Matte Red Card Sleeves");
            ArrayList arrCart = (ArrayList)Session["CART"];
            arrCart.Add(cartItem);
            Session.Add("CART", arrCart);
        }

        protected void btnBuy3_Click(object sender, EventArgs e)
        {
            Trace.Warn("Adding an item to the cart");
            CartItem cartItem = new CartItem();
            cartItem.setCost(20.99);
            cartItem.setItemName("Old Hat Play Mat");
            ArrayList arrCart = (ArrayList)Session["CART"];
            arrCart.Add(cartItem);
            Session.Add("CART", arrCart);
        }

        protected void btnBuy4_Click(object sender, EventArgs e)
        {
            Trace.Warn("Adding an item to the cart");
            CartItem cartItem = new CartItem();
            cartItem.setCost(120.99);
            cartItem.setItemName("Mana Crypt");
            ArrayList arrCart = (ArrayList)Session["CART"];
            arrCart.Add(cartItem);
            Session.Add("CART", arrCart);
        }

        protected void btnBuy5_Click(object sender, EventArgs e)
        {
            Trace.Warn("Adding an item to the cart");
            CartItem cartItem = new CartItem();
            cartItem.setCost(80.00);
            cartItem.setItemName("The Ur-Dragon");
            ArrayList arrCart = (ArrayList)Session["CART"];
            arrCart.Add(cartItem);
            Session.Add("CART", arrCart);
        }

        protected void btnBuy6_Click(object sender, EventArgs e)
        {
            Trace.Warn("Adding an item to the cart");
            CartItem cartItem = new CartItem();
            cartItem.setCost(34.99);
            cartItem.setItemName("Atraxa, Preators' Voice");
            ArrayList arrCart = (ArrayList)Session["CART"];
            arrCart.Add(cartItem);
            Session.Add("CART", arrCart);
        }
    }
}