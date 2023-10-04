using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.IO;

namespace MagicTableTopGamingWebsite.Forms
{
    public partial class frmDiscussion : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            loadBlog();
        }

        protected void btnSend_Click(object sender, EventArgs e)
        {
            string user = "Guest";
            if (User.Identity.IsAuthenticated) {
                user = User.Identity.Name;
            }
            txtBlog.Text += user + " >> " + DateTime.UtcNow.ToShortTimeString() + " << : " + txtEntry.Text + "\n";
            File.WriteAllText(Server.MapPath("~/Files/txtBlog.txt"), txtBlog.Text);
            txtEntry.Text = "";
        }

        protected void loadBlog() {
            String[] strBlog = File.ReadAllLines(Server.MapPath("~/Files/txtBlog.txt"));
            txtBlog.Text = "";

            foreach(String line in strBlog)
            {
                txtBlog.Text += line;
                txtBlog.Text += "\n";
            }
        }
    }
}