using CalculateDiscount.Service;
using CalculateDiscount.Service.Interfaces;
using CalculateDiscount.Service.Strategy;
using CalculateDiscount.Service.Strategy.Interfaces;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddTransient<IDiscountService, DiscountService>();
builder.Services.AddTransient<IDiscountStrategy, AffiliateDiscountStrategy>();
builder.Services.AddTransient<IDiscountStrategy, EmployeeDiscountStrategy>();
builder.Services.AddTransient<IDiscountStrategy, LongTimeCustomerDiscountStrategy>();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
