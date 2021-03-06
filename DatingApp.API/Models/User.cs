using System;
using System.Collections.Generic;

namespace DatingApp.API.Models
{
    public class User
    {
      
        public int id { get; set; }
        public string username { get; set; }
        public byte[] passwordHash { get; set; }
        public byte[] passwordSalt { get; set; }
        public DateTime DateOfBirth { get; set; }
        public DateTime Created { get; set; }
        public DateTime LastActive { get; set; }
        public string gender { get; set; }
        public string knownAs { get; set; }
        public string Introduction { get; set; }
        public string LookingFor { get; set; }
        public string Interest { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public ICollection <Photo> Photos { get; set; }









    }
}