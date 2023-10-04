using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MagicTableTopGamingWebsite.App_Code;
using System.Text;
using System.Collections;

namespace MagicTableTopGamingWebsite.Forms
{
    public partial class frmCart : System.Web.UI.Page
    {
        public double totalCost = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                displayDetails();
            }
            catch (Exception ex)
            {
                Response.Redirect("frmHome.aspx");
            }
        }

        private void displayDetails()
        {
            this.pnlOrders.Controls.Clear();
            totalCost = 0;
            ArrayList arrCart = (ArrayList)Session["CART"];
            int totalItems = arrCart.Count;

            this.lblOrderSummary.Text = totalItems + " items in your cart";

            for (int loop = 0; loop < totalItems; loop++)
            {
                StringBuilder sb = new StringBuilder();

                CartItem cartItem = (CartItem)arrCart[loop];

                Label itemLabel = new Label();
                if(loop == 0)
                {
                    itemLabel.CssClass = "cartInfo";
                    sb.Append("<br>");
                    sb.Append("Name : " + cartItem.getItemName() + "<br>");
                    sb.Append("Cost : £" + cartItem.getCost() + "<br>");
                    itemLabel.Text = sb.ToString();
                }
                else
                {
                    itemLabel.CssClass = "cartInfo";
                    sb.Append("<br>---------------------------------------------------------------------<br>");
                    sb.Append("<br>");
                    sb.Append("Name : " + cartItem.getItemName() + "<br>");
                    sb.Append("Cost : £" + cartItem.getCost() + "<br>");
                    itemLabel.Text = sb.ToString();
                }
                totalCost += cartItem.getCost();
                this.pnlOrders.Controls.Add(itemLabel);
            }
            this.lblTotalCost.Text = "<br><br>Total cost : £" + totalCost;
        }

        protected void btnClear_Click(object sender, EventArgs e)
        {
            ArrayList arrCart = (ArrayList)Session["CART"];
            arrCart.Clear();
            Session["CART"] = arrCart;
            displayDetails();
        }

        protected void btnCheckout_Click(object sender, EventArgs e)
        {
            if (totalCost > 0)
            {
                if (User.Identity.IsAuthenticated)
                {
                    Order order = new Order();
                    order.setUser(User.Identity.Name);
                    order.setTotal(totalCost);
                    ArrayList arrOrder = (ArrayList)Session["ORDER"];
                    arrOrder.Add(order);
                    Session.Add("ORDER", arrOrder);
                    ArrayList arrCart = (ArrayList)Session["CART"];
                    arrCart.Clear();
                    Session["CART"] = arrCart;

                    displayDetails();
                }
                else
                {
                    Order order = new Order();
                    order.setUser("Guest");
                    order.setTotal(totalCost);
                    ArrayList arrOrder = (ArrayList)Session["ORDER"];
                    arrOrder.Add(order);
                    Session.Add("ORDER", arrOrder);
                    ArrayList arrCart = (ArrayList)Session["CART"];
                    arrCart.Clear();
                    Session["CART"] = arrCart;

                    displayDetails();
                }
            }
            else
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "emptyCart", "emptyCart();", true);
            }
        }
    }
}