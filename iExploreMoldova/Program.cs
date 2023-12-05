using iExploreMoldova.Models.ApplicationServices;
using iExploreMoldova.Models.Interfaces;
using iExploreMoldova.Models.Repositories;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddScoped<ICategoryRepository, CategoryRepository>();
builder.Services.AddScoped<ILocationRepository, LocationRepository>();
builder.Services.AddScoped<IOrderRepository, OrderRepository>();

builder.Services.AddScoped<ICartTicket, CartTicketRepository>(CartTicketRepository.GetTicketsList);
builder.Services.AddSession();
//Calling the Accessor here because we included it in the GetTicketsList method --- services.GetRequiredService<IHttpContextAccessor>
builder.Services.AddHttpContextAccessor();

builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<iExploreMoldovaDbContext>(options =>
{
    options.UseLazyLoadingProxies();
    options.UseSqlServer(builder.Configuration["ConnectionStrings:iExploreMoldovaDbContextConnection"]);
});

var app = builder.Build();

//Bring in the support for sessions
app.UseSession();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

DbInitializer.SeedData(app);

app.Run();
