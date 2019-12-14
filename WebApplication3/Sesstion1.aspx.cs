using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication3
{
    public partial class Sesstion1 : System.Web.UI.Page
    {
        String a, b;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnResotre_Click(object sender, EventArgs e)
        {
            if (ViewState["user"] != null)
            {
                txtUser.Text = ViewState["user"].ToString();
            }
            if (ViewState["pass"] !=null)
            {
                txtPassword.Text = ViewState["pass"].ToString();
            }
            a = txtUser.Text;
            b = txtPassword.Text;
        } 

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            // Session.Add("User", txtUser.Text);
            //Session["user"] = txtUser.Text;
            //Session["pwd"] = txtPassword.Text;
            //Response.Redirect("Sesstion2.aspx");
            //ViewState["user"]= txtUser.Text;
            //ViewState["pass"]= txtPassword.Text;
            // txtUser.Text = string.Empty;
            // txtPassword.Text = string.Empty;
            Response.Write("sesstion2.aspx?");

        }
    }
}