using RoomRoost.DataAccessLayer.Abstract;
using RoomRoost.DataAccessLayer.Concrete;
using RoomRoost.DataAccessLayer.Repositories;
using RoomRoost.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoomRoost.DataAccessLayer.EntityFramework
{
    public class EfBookingDal: GenericRepository<Booking>, IBookingDal
    {
        public EfBookingDal(RoomRoostDbContext context) : base(context) { }

    }
}
