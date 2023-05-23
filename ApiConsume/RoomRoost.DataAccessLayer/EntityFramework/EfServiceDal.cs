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
    public class EfServiceDal:GenericRepository<Service>, IServiceDal
    {
        public EfServiceDal(Context context) : base(context) { }
    }
}
