using System.Reflection;
using System.Text.Json.Serialization;
using Infrastructure.Extensions;
using LogicLayer;
using LogicLayer.Implementation;
using MainApi.Extensions;
using Microsoft.OpenApi.Models;
using Serilog;

var builder = WebApplication.CreateBuilder(args);

// pull env vars into IConfiguration
builder.Configuration.AddEnvironmentVariables();

// configure logger
Log.Logger = new LoggerConfiguration()
    .WriteTo.Console()
    .CreateLogger();

// TODO: authorization middleware

// register logger and configuration for DI
builder.Services.AddSingleton(Log.Logger);
builder.Services.AddSingleton(typeof(IConfiguration), builder.Configuration);

// configure and register mongo and SQL dbs for DI
builder.Services.ConfigureMongoDatabase(builder.Configuration);
builder.Services.ConfigureSqlDatabase(builder.Configuration);

// register services/repositories for DI
builder.Services.AddTransient<IExceptionService, ExceptionService>();

// register background services

// register controllers and swagger
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo
    {
        Title = "Main REST Api",
        Version = "v1",
        Description = "Does some stuff."
    });

    // include XML comments file
    var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
    var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
    c.IncludeXmlComments(xmlPath);
});

builder.Services.AddMvc().AddJsonOptions(options =>
{
    options.JsonSerializerOptions.DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull;
});

var app = builder.Build();

// TODO: configure CORS

app.UseSwagger();
app.UseSwaggerUI();
app.UseExceptionMiddleware();
app.MapControllers();
app.Run();