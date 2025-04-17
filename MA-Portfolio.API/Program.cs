using MA_Portfolio.BLL.Service.Abstract;
using MA_Portfolio.DAL.Context;
using MA_Portfolio.DAL.Repository.Abstract;
using MA_Portfolio.DAL.UnitOfWork.Abstract;
using MA_Portfolio.DAL.UnitOfWork.Concrete;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<MADbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("MA-Portfolio"));
});
builder.Services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
builder.Services.AddScoped(typeof(IDalService<>), typeof(DalService<,>));
builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();





// Add services to the container.

var app = builder.Build();
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}


// Configure the HTTP request pipeline.


app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();

