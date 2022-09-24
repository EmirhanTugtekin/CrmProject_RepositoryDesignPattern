using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_Layer
{
    public class Customer
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }
        public string Surname { get; set; }
        public string Phone { get; set; }
        public DateTime Birth { get; set; }
        public string Gender { get; set; }
        public string Mail { get; set; }
        public string Password { get; set; }
    }
}
