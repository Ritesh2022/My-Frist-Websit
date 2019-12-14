using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication3
{
    public partial class Sesstion2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user"] != null)
            {
                Response.Write("wel-come to session" + Session["user"].ToString());
            }
            else
            {
                Response.Redirect("sesstion1.aspx");
            }

        }
    }
}