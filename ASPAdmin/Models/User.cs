﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASPAdmin.Models
{
    public class User
    {
        public int IdUser { get; set; }
        public string UserName { get; set; }
        public string UserPassword { get; set; }
        public bool IsActive { get; set; }
    }
}