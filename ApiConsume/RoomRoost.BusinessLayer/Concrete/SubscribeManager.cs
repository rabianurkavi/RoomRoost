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
    public class SubscribeManager : ISubscribeService
    {
        private readonly ISubscribeDal _SubscribeDal;
        public SubscribeManager(ISubscribeDal SubscribeDal)
        {
            _SubscribeDal = SubscribeDal;
        }
        public void TAdd(Subscribe t)
        {
            _SubscribeDal.Insert(t);
        }

        public void TDelete(Subscribe t)
        {
            _SubscribeDal.Delete(t);
        }

        public List<Subscribe> TGetAll()
        {
            return _SubscribeDal.GetAll();
        }

        public Subscribe TGetById(int id)
        {
            return _SubscribeDal.GetByID(id);
        }

        public void TUpdate(Subscribe t)
        {
            _SubscribeDal.Update(t);
        }
    }
}
