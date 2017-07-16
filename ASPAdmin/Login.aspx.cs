using System;
using System.Web.UI;

namespace ASPAdmin
{
    public partial class Login : System.Web.UI.Page
    {
        string _apiUrl = "http://gersondeveloper-com.umbler.net/api/UsersASPs/login";

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

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            
            
         

        }
    }
}