using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_Layer
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }


        [StringLength(50)]
        public string Name { get; set; }


        [StringLength(50)]
        public string Surname { get; set; }


        public DateTime Birth { get; set; }


        [StringLength(5)]
        public string Gender { get; set; }


        [StringLength(70)]
        public string Mail { get; set; }


        [StringLength(50)]
        public string Password { get; set; }
    }
}
