using Entity_Layer;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_Layer
{
    public class Category
    {
        [Key]
        public int Id { get; set; }


        public string Name { get; set; }


        //-----------Relations--------------
        public List<Product> Products { get; set; }
    }
}
