using PhotosMvc.Models;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddHttpClient();
builder.Services.AddControllersWithViews(); 
builder.Services.AddEndpointsApiExplorer();

builder.Services.AddSingleton<DataService>();
var app = builder.Build();

app.UseRouting();
app.UseEndpoints(o => o.MapControllers());
app.Run();
