using Microsoft.EntityFrameworkCore;
using RoomRoost.BusinessLayer.Abstract;
using RoomRoost.BusinessLayer.Concrete;
using RoomRoost.DataAccessLayer.Abstract;
using RoomRoost.DataAccessLayer.Concrete;
using RoomRoost.DataAccessLayer.EntityFramework;
using RoomRoost.DataAccessLayer.Services;

var builder = WebApplication.CreateBuilder(args);

//Register DbContext


builder.Services.AddDbContext<RoomRoostDbContext>();

builder.Services.AddScoped<IServiceDal, EfServiceDal>();
builder.Services.AddScoped<IServiceService, ServiceManager>();

builder.Services.AddScoped<IStaffService, StaffManager>();
builder.Services.AddScoped<IStaffDal, EfStaffDal>();


builder.Services.AddScoped<IRoomDal, EfRoomDal>();
builder.Services.AddScoped<IRoomService, RoomManager>();

builder.Services.AddScoped<ITestimonialDal, EfTestimonialDal>();
builder.Services.AddScoped<ITestimonialService, TestimonialManager>();


builder.Services.AddAutoMapper(typeof(Program));

//API'nizin CORS politikalarýný yapýlandýrarak farklý kaynaklardan
//gelen isteklere izin verir ve uygulamanýn CORS destekleyen istemcilerle doðru bir þekilde iletiþim kurmasýný saðlar.
builder.Services.AddCors(opt =>
{
    opt.AddPolicy("HotelApiCors", opts =>
    {
        opts.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod();
    });
});
// Add services to the container.


builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseCors("HotelApiCors");

app.UseAuthorization();

app.MapControllers();

app.Run();
