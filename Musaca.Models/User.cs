﻿using Musaca.Models.Enums;

namespace Musaca.Models
{
    public class User
    {
        public string Id { get; set; }

        public string Username { get; set; }

        public string Password { get; set; }

        public string Email { get; set; }

        public Role Role{ get; set; }
    }
}
