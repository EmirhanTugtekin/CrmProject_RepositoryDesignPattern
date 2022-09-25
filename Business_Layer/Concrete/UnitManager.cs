using Business_Layer;
using DataAccess_Layer.Abstract;
using Entity_Layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Layer
{
    public class UnitManager : IUnitService
    {
        IUnitDal _unitDal;

        public UnitManager(IUnitDal unitDal)
        {
            _unitDal = unitDal;//Bu sınıfı çağırdığımız gibi dal arka planda hazır oluyor. Dep. inj. nın en önemli faydası
        }

        public void TDelete(Unit t)
        {
            _unitDal.Delete(t);
        }

        public Unit TGetByID(int id)
        {
            return _unitDal.GetByID(id);
        }

        public List<Unit> TGetListAll()
        {
            return _unitDal.GetListAll();
        }

        public void TInsert(Unit t)
        {
            _unitDal.Insert(t);
        }

        public void TUpdate(Unit t)
        {
            _unitDal.Update(t);
        }

    }
}
