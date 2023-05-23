using RoomRoost.BusinessLayer.Abstract;
using RoomRoost.DataAccessLayer.Abstract;
using RoomRoost.DataAccessLayer.EntityFramework;
using RoomRoost.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoomRoost.BusinessLayer.Concrete
{
    public class ServiceManager : IServiceService
    {
        private readonly IServiceDal _serviceDal;
        public ServiceManager(IServiceDal serviceDal)
        {
            _serviceDal = serviceDal;
        }
        public void TAdd(Service t)
        {
            _serviceDal.Insert(t);
        }

        public void TDelete(Service t)
        {
            _serviceDal.Delete(t);
        }

        public List<Service> TGetAll()
        {
            return _serviceDal.GetAll();
        }

        public Service TGetById(int id)
        {
            return _serviceDal.GetByID(id);
        }

        public void TUpdate(Service t)
        {
            _serviceDal.Update(t);
        }
    }
}
