using Microsoft.OpenApi.Models;
using System.Reflection;
using UtilAutoMaper;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c => 
{
    c.SwaggerDoc("v1", new OpenApiInfo
    {
        Title = "Control de Ventas y Produccion de Zapateria",
        Version = "v1",
        Description = "Controlar las ventas y produccion de los empleados",
        Contact = new OpenApiContact
        {
            Name = "Rojas Lopez Felix Bruno",
            Email = "i1921286@continental.edu.pe"
        },
    }
    );
    var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
    var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
    c.IncludeXmlComments(xmlPath, includeControllerXmlComments: true);

});
// COnfig AutoMapper
builder.Services.AddAutoMapper(typeof(IStartup).Assembly,typeof(AutoMapperProfiles).Assembly);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
