using RoomRoost.BusinessLayer.Abstract;
using RoomRoost.DataAccessLayer.Abstract;
using RoomRoost.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoomRoost.BusinessLayer.Concrete
{
    public class AboutManager : IAboutService
    {
        private readonly IAboutDal _aboutDal;
        public AboutManager(IAboutDal aboutDal)
        {
            _aboutDal=aboutDal;
        }
        public void TAdd(About t)
        {
            _aboutDal.Insert(t);
        }

        public void TDelete(About t)
        {
            _aboutDal.Delete(t);

        }

        public List<About> TGetAll()
        {
            return _aboutDal.GetAll();
        }

        public About TGetById(int id)
        {
           return _aboutDal.GetByID(id);

        }

        public void TUpdate(About t)
        {
            _aboutDal.Update(t);
        }
    }
}
