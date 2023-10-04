using api.product_management_platform.Infrastructure.Persistence.DatabaseContext;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

string? connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

if (connectionString == null)
{
    throw new ApplicationException(connectionString);
}


builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<ApplicationContext>(options =>
{
    options.UseNpgsql(connectionString);
});
CreateDatabase(builder);

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

static void CreateDatabase(WebApplicationBuilder builder)
{
    using (var scope = builder.Services.BuildServiceProvider().CreateScope())
    {
        var config = scope.ServiceProvider.GetRequiredService<ApplicationContext>();
            
        if (!config.Database.EnsureCreated())
            return;

        config.Database.Migrate();
    }
}