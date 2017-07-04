using ASPAdmin.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ASPAdmin.Models;
using System.Threading.Tasks;
using System.Net.Http;

namespace ASPAdmin.Connection
{
    public class DataService : IUser
    {
        #region Properties

        private HttpClient client;
        private string apiUrl = "http://gersondeveloper-com.umbler.net/api/UsersASPs";
        public User user { get; set; }

        #endregion

        public DataService()
        {
            client = new HttpClient();
            client.MaxResponseContentBufferSize = 256000;
            client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Basic");
        }


        public async Task<User> GetUserAsync(string userName, string userPassword)
        {
            try
            {
                var response = await client.GetAsync(apiUrl);
            }
            catch (Exception)
            {

                throw;
            } 
        }
    }
}