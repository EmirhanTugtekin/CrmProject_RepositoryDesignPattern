using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_Layer
{
    public class Product
    {
        public int Id { get; set; }


        public string Name { get; set; }


        public double PurchasePrice { get; set; }


        public double SalePrice { get; set; }


        public string Image { get; set; }


        public int Stock { get; set; }


        public string Code { get; set; }


        //-----------Relations--------------
        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
