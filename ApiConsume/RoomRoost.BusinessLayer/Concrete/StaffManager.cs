﻿using RoomRoost.BusinessLayer.Abstract;
using RoomRoost.DataAccessLayer.Abstract;
using RoomRoost.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoomRoost.BusinessLayer.Concrete
{
    public class StaffManager : IStaffService
    {
        private readonly IStaffDal _staffDal;
        public StaffManager(IStaffDal staffDal )
        {
            _staffDal = staffDal;
        }
        public void TAdd(Staff t)
        {
            _staffDal.Insert(t);
        }

        public void TDelete(Staff t)
        {
            _staffDal.Delete(t);
        }

        public List<Staff> TGetAll()
        {
            return _staffDal.GetAll();
        }

        public Staff TGetById(int id)
        {
            return _staffDal.GetByID(id);
        }

        public void TUpdate(Staff t)
        {
            _staffDal.Update(t);
        }
    }
}
