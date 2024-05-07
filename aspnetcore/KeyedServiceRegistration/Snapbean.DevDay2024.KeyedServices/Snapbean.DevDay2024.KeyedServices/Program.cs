using Snapbean.DevDay2024.KeyedServices.Interfaces;
using Snapbean.DevDay2024.KeyedServices.Services;

var builder = WebApplication.CreateBuilder(args);

// Registering services the usual way
builder.Services.AddScoped<IUsefulService, UsefulService>();

builder.Services.AddScoped<IDummyService, DummyServiceA>();
builder.Services.AddScoped<IDummyService, DummyServiceB>();
builder.Services.AddScoped<IDummyService, DummyServiceC>();

// Registering services the "keyed" way
// e.g. for different cache sizes, notification types, logging, ...
// builder.Services.AddKeyedScoped<IDummyService, DummyServiceA>("A");
// builder.Services.AddKeyedScoped<IDummyService, DummyServiceB>("B");
// builder.Services.AddKeyedScoped<IDummyService, DummyServiceC>("C");

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

//app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();