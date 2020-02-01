﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CarRental.Domain.Models
{
    public class AppUser
    {
        public string Id { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string NormalizeUserName { get; set; }
        public string PasswordHash { get; set; }
    }

}
