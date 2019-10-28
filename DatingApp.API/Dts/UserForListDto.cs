using System;

namespace DatingApp.API.Dts
{
    public class UserForListDto
    {
        
        public int id { get; set; }
        public string username { get; set; }
        public int Age { get; set; }
        public DateTime Created { get; set; }
        public DateTime LastActive { get; set; }
        public string gender { get; set; }
        public string knownAs { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string PhotoUrl { get; set; }
    }
}