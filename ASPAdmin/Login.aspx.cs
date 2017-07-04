using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASPAdmin
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                Session.Abandon();
            }
            if (Request.QueryString["info"] != null)
            {
                string message = Request.QueryString["info"].ToString();
                if (message == "0")
                {
                    Response.Write("<strong>Favor logar no sistema</strong>");
                }
            }
        }
    }
}