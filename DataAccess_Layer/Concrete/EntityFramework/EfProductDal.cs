using DataAccess_Layer.Abstract;
using DataAccess_Layer;
using Entity_Layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace DataAccess_Layer.EntityFramework
{
    public class EfProductDal : GenericRepo<Product>, IProductDal
    {
        public List<Product> GetListProductWithCategory()
        {
            using (var context = new Context())
            {
                return context.Products.Include(x => x.Category).ToList();
            }
        }
    }
}
