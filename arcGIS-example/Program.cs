using arcGIS.Services;

var builder = WebApplication.CreateBuilder(args);
// Add MVC services to the application
builder.Services.AddControllers();
builder.Services.AddSingleton<ArcGISService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
app.UseRouting();

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllers();
});

app.Run();