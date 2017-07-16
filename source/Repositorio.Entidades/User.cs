using System;

namespace Repository.Entities
{
    public class User
    {
        public int IdUser { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public bool IsActive { get; set; }
        public int  ProfileId { get; set; }
        public DateTime RegisterDate { get; set; }

    }
}
