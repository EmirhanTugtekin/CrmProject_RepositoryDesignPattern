using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_Layer
{
    public class AppUser:IdentityUser<int> //IdentityUser bu 4 property'i getirmediği için bu AppUser sınıfını ekledik 
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Gender { get; set; }
        public string ImageUrl { get; set; }
    }
}
