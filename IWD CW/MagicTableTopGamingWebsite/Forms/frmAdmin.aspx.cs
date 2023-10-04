using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;
using MagicTableTopGamingWebsite.App_Code;
using System.Text;

namespace MagicTableTopGamingWebsite.Forms.Admin
{
    public partial class frmAdmin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            displayDetails();
        }

        protected void btnLogout_Click(object sender, EventArgs e)
        {
            FormsAuthentication.SignOut();
            Response.Redirect("frmLogin.aspx", true);
        }
        private void displayDetails()
        {
            this.pnlOrders.Controls.Clear();

            ArrayList arrOrder = (ArrayList)Session["ORDER"];
            int totalOrders = arrOrder.Count;

            //this.lblOrderSummary.Text = totalItems + " items in your cart";

            for (int loop = 0; loop < totalOrders; loop++)
            {
                StringBuilder sb = new StringBuilder();

                Order order = (Order)arrOrder[loop];
                Label itemLabel = new Label();
                if(loop == 0)
                {
                    itemLabel.CssClass = "cartInfo";
                    sb.Append("<br>");
                    sb.Append("Name : " + order.getUser() + "<br>");
                    sb.Append("Total : £" + order.getTotal() + "<br>");
                    itemLabel.Text = sb.ToString();
                    this.pnlOrders.Controls.Add(itemLabel);
                }
                else
                {
                    itemLabel.CssClass = "cartInfo";
                    sb.Append("<br>---------------------------------------------------------------------<br>");
                    sb.Append("<br>");
                    sb.Append("Name : " + order.getUser() + "<br>");
                    sb.Append("Total £: " + order.getTotal() + "<br>");
                    itemLabel.Text = sb.ToString();
                    this.pnlOrders.Controls.Add(itemLabel);
                }
            }
        }
    }
}