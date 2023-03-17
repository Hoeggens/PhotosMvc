using PhotosMvc.Models;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddHttpClient();
builder.Services.AddControllersWithViews();
builder.Services.AddSingleton<DataService>(); 
builder.Services.AddSingleton<PhotoDetailsDto>(); 
var app = builder.Build();

app.UseRouting();
app.UseEndpoints(o => o.MapControllers());
app.Run();
