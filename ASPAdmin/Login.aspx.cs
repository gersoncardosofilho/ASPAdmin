using ASPAdmin.Connection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

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
            HttpClient client = new HttpClient();

            client.BaseAddress = new Uri(_apiUrl);
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

            
            


        }
    }
}