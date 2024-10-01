using BodegaVinos.Repository;
using BodegaVinos.Services;

internal class Program
{
    private static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        // Agregar servicios al contenedor
        builder.Services.AddControllers();

        // Inyectar repositorios y servicios
        builder.Services.AddSingleton<VinoRepository>();
        builder.Services.AddSingleton<UserRepository>();
        builder.Services.AddScoped<IVinoService, VinoService>();
        builder.Services.AddScoped<IUserService, UserService>();

        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen();

        var app = builder.Build();

        if (app.Environment.IsDevelopment())
        {
            app.UseSwagger();
            app.UseSwaggerUI();
        }

        app.UseHttpsRedirection();
        app.UseAuthorization();
        app.MapControllers();

        app.Run();
    }
}