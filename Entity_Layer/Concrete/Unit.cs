using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_Layer
{
    public class Unit
    {
        [Key]
        public int UnitId { get; set; }
        [StringLength(50)]
        public string UnitName { get; set; }
        [StringLength(200)]
        public string UnitDescription { get; set; }
        public bool UnitStatus { get; set; }
    }
}
