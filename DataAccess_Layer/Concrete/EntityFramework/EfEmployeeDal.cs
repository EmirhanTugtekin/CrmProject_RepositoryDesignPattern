using DataAccess_Layer.Abstract;
using Entity_Layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess_Layer.EntityFramework
{
    public class EfEmployeeDal : GenericRepo<Employee>, IEmployeeDal
    {
        
    }
}
