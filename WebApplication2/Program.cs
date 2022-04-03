var builder = WebApplication.CreateBuilder(args);

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

public void ConfigureServcies(IServiceCollection services)
{
    services.AddControllers();
    services.AddDbContextPool<WebApplication2.Models.StarSystemDBContext>(options => options.UserSqlServer(
        "@\"host=localhost;Database=space;username=postgres;Password=root;uid=postgres;;Integrated Security=True\""));
    services.AddScoped<WebApplication2.StarSystemData.IStarSystemData, WebApplication2.StarSystemData.SqlStarSystemData>
    
}
app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
