﻿using Microsoft.EntityFrameworkCore;
using RoomRoost.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoomRoost.DataAccessLayer.Concrete
{
    public class RoomRoostDbContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=Rabia\\SQLEXPRESS;initial catalog=RoomRoostApiDB; integrated security=true");
        }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<Staff> Staffs { get; set; }
        public DbSet<Subscribe> Subscribes { get; set; }
        public DbSet<Testimonial> Testimonials { get; set; }
    }
}
