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
    public class RoomManager : IRoomService
    {
        private readonly IRoomDal _roomDal;
        public RoomManager(IRoomDal roomDal) 
        {
            _roomDal = roomDal;
        }
        public void TAdd(Room t)
        {
            _roomDal.Insert(t);
        }

        public void TDelete(Room t)
        {
            _roomDal.Delete(t);
        }

        public List<Room> TGetAll()
        {
            return _roomDal.GetAll();
        }

        public Room TGetById(int id)
        {
            return _roomDal.GetByID(id);
        }

        public void TUpdate(Room t)
        {
             _roomDal.Update(t);
        }
    }
}
