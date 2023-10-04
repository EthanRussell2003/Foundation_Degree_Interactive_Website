using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;
using MagicTableTopGamingWebsite.App_Code;
using System.Collections;

namespace MagicTableTopGamingWebsite.Forms
{
    public partial class frmLogin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (User.Identity.IsAuthenticated)
            {
                Response.Redirect("frmMember.aspx");
            }
        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            string user = txtRegUsername.Text;
            string pwd = txtRegPassword.Text;
            bool takenFlag = false;
            ArrayList arrUser = (ArrayList)Session["USER"];
            if (arrUser.Count != 0) {
                for (int users = 0; users < arrUser.Count; users++)
                {
                    User checkUser = (User)arrUser[users];
                    if (user.Equals(checkUser.getUsername()))
                    {
                        takenFlag = true;
                    }
                }
            }
            if (takenFlag == false) {
                User regUser = new User();
                if(user != "")
                {
                    if (user.Length >= 6)
                    {
                        regUser.setUsername(user);
                        if (pwd != "")
                        {
                            if (pwd.Length >= 6)
                            {
                                regUser.setPassword(pwd);
                                arrUser.Add(regUser);
                                Session.Add("USER", arrUser);
                                FormsAuthentication.RedirectFromLoginPage(user, true);
                            }
                            else
                            {
                                lblRegOutput.Text = "Password must be at least 6 characters";
                            }
                        }
                        else
                        {
                            lblRegOutput.Text = "Password required";
                        }
                    }
                    else
                    {
                        lblRegOutput.Text = "Username must be at least 6 characters";
                    }
                }
                else
                {
                    lblRegOutput.Text = "Username required";
                }
            }
            else
            {
                lblRegOutput.Text = "Username taken";
            }
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            string user = txtUsername.Text;
            string pwd = txtPassword.Text;
            ArrayList arrUser = (ArrayList)Session["USER"];

            for (int users = 0; users < arrUser.Count; users++)
            {
                User checkUser = (User)arrUser[users];
                try
                {
                    if (user.Equals(checkUser.getUsername()) && pwd.Equals(checkUser.getPassword()))
                    {
                        FormsAuthentication.RedirectFromLoginPage(user, true);
                    }
                    else if (user.Equals("Admin") && pwd.Equals("adminPassword"))
                    {
                        FormsAuthentication.RedirectFromLoginPage(user, true);
                    }
                }
                catch (Exception)
                {

                }
            }
            if (user.Equals("Admin") && pwd.Equals("adminPassword"))
            {
                FormsAuthentication.RedirectFromLoginPage(user, true);
            }
            lblOutput.Text = "Invalid login";
        }

    }
}
