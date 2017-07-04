using ASPAdmin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASPAdmin.Interfaces
{
    public interface IUser
    {
        Task<User> GetUserAsync(string userName, string userPassword);
    }
}
