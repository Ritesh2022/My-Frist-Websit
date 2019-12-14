using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication3
{
    public partial class Sesstion3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user"] != null)
            {
                Response.Write("welcom sesstion3 " +  Session["user"].ToString());
            }
            else
            {
                Response.Redirect("sesstion1.aspx");
            }
        }
    }
}