<<<<<<< HEAD
using Backend.Services.Implementations;
using Backend.Services.Interfaces;
=======
using BackEnd.Services.Implementations;
using BackEnd.Services.Interfaces;
>>>>>>> Gustavo
using DAL.Implementations;
using DAL.Interfaces;
using Entities.Entities;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<PrograWebContext>();

#region DI
builder.Services.AddScoped<IUnidadDeTrabajo, UnidadDeTrabajo>();
builder.Services.AddScoped<ITabCurso, TabCursoDALImpl>();
builder.Services.AddScoped<ITabCursoService, TabCursoService>();
builder.Services.AddScoped<ITabCursoImpartir, TabCursoImpartirDALImpl>();
builder.Services.AddScoped<ITabCursoImpartirService, ITabCursoImpartirService>();

#endregion




//Initialize Context
builder.Services.AddDbContext<PrograWebContext>();

//Initialize UnitOfWork
builder.Services.AddScoped<IUnidadDeTrabajo, UnidadDeTrabajo>();

builder.Services.AddScoped<ITabEstadoDAL, TabEstadoDALImpl>();
builder.Services.AddScoped<ITabEstadoService, TabEstadoService>();

builder.Services.AddScoped<ITabEstudianteDAL, TabEstudianteDALImpl>();
builder.Services.AddScoped<ITabEstudianteService, TabEstudianteService>();

builder.Services.AddScoped<ITabHorarioDAL, TabHorarioDALImpl>();
builder.Services.AddScoped<ITabHorarioService, TabHorarioService>();

builder.Services.AddScoped<ITabIngredienteDAL, TabIngredienteDALImpl>();
builder.Services.AddScoped<ITabIngredienteService, TabIngredienteService>();

builder.Services.AddScoped<ITabInstruccionDAL, TabInstruccionDALImpl>();
builder.Services.AddScoped<ITabInstruccionService, TabInstruccionService>();

builder.Services.AddScoped<ITabMatriculaDAL, TabMatriculaDALImpl>();
builder.Services.AddScoped<ITabMatriculaService, TabMatriculaService>();

builder.Services.AddScoped<ITabProfesorDAL, TabProfesorDALImpl>();
builder.Services.AddScoped<ITabProfesorService, TabProfesorService>();

builder.Services.AddScoped<ITabRecetaDAL, TabRecetaDALImpl>();
builder.Services.AddScoped<ITabRecetaService, TabRecetaService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
	app.UseSwagger();
	app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
