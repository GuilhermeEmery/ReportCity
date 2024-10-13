#region IMPORTAÇÕES
using System.Text;
using Fiap.Api.ReportCity.Data.Contexts;
using Fiap.Api.ReportCity.Data.Repository;
using Fiap.Api.ReportCity.Services;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
#endregion

var builder = WebApplication.CreateBuilder(args);

#region INICIALIZANDO O BANCO DE DADOS
var connectionString = builder.Configuration.GetConnectionString("DatabaseConnection");

builder.Services.AddDbContext<ApplicationDbContext>(
    opt => opt.UseOracle(connectionString).EnableSensitiveDataLogging(true)
);
#endregion

#region Autenticação
builder.Services.AddAuthentication(options =>
{
    options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
})
    .AddJwtBearer(options =>
    {
        options.TokenValidationParameters = new TokenValidationParameters
        {
            ValidateIssuerSigningKey = true,
            IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("f+ujXAKHk00L5jlMXo2XhAWawsOoihNP1OiAM25lLSO57+X7uBMQgwPju6yzyePi")),
            ValidateIssuer = false,
            ValidateAudience = false
        };
    });
#endregion

#region REGISTRO REPOSITORIOS 
// Registrar serviços para CrimePrediction
builder.Services.AddScoped<ICrimePredictionService, CrimePredictionService>();
builder.Services.AddScoped<ICrimePredictionRepository, CrimePredictionRepository>();

// Registrar serviços para AlarmNotification
builder.Services.AddScoped<IAlarmNotificationService, AlarmNotificationService>();
builder.Services.AddScoped<IAlarmNotificationRepository, AlarmNotificationRepository>();

// Registrar serviços para IncidentReport
builder.Services.AddScoped<IIncidentReportService, IncidentReportService>();
builder.Services.AddScoped<IIncidentReportRepository, IncidentReportRepository>();

// Registrar serviços para Surveillance
builder.Services.AddScoped<ISurveillanceService, SurveillanceService>();
builder.Services.AddScoped<ISurveillanceRepository, SurveillanceRepository>();

// Registrar serviços para User
builder.Services.AddScoped<IUserService, UserService>();
builder.Services.AddScoped<IUserRepository, UserRepository>();

#endregion

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

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
