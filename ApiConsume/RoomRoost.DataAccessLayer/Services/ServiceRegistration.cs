using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using RoomRoost.DataAccessLayer.Abstract;
using RoomRoost.DataAccessLayer.Concrete;
using RoomRoost.DataAccessLayer.EntityFramework;
using RoomRoost.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoomRoost.DataAccessLayer.Services
{
    public static class ServiceRegistration
    {
        public static void AddPersistenceServices(this IServiceCollection services)
        {
            services.AddDbContext<RoomRoostDbContext>(options => options.UseSqlServer(Configuration.ConnectionString));
            services.AddScoped<IServiceDal, EfServiceDal>();
            services.AddScoped<IStaffDal, EfStaffDal>();
            services.AddScoped<IRoomDal, EfRoomDal>();
            services.AddScoped<ITestimonialDal, EfTestimonialDal>();
        }
    }
}
