using AutoMapper;
using DevExpress.AspNetCore;
using DevExpress.AspNetCore.Reporting;
using DevExpressDemo.Helper;
using DevExpressDemo.Services.Implementation;
using DevExpressDemo.Services.Interface;
using Microsoft.Extensions.FileProviders;

var builder = WebApplication.CreateBuilder(args);

////connect to the SqlServer
//builder.Services.AddDbContext<FiniexWebDbContext>(option =>
//{
//    option.UseSqlServer(builder.Configuration.GetConnectionString("localhost_FiniexWebDb_Connection"));
//});

// Add services to the container.
builder.Services.AddControllersWithViews().AddJsonOptions(options => options.JsonSerializerOptions.PropertyNamingPolicy = null);
builder.Services.AddDevExpressControls();

//builder.Services.AddSession(opt =>
//{
//    opt.IdleTimeout = TimeSpan.FromDays(5);
//});


#region AutoMapperConFiguration
var mapperConfig = new MapperConfiguration(mc =>
{
    mc.AddProfile(new MappingProfile());
});
AutoMapper.IMapper mapper = mapperConfig.CreateMapper();
builder.Services.AddSingleton(mapper);
#endregion


#region Service Configuration
builder.Services.AddScoped<ICompanyInformationService, CompanyInformationService>();
#endregion


builder.Services.ConfigureReportingServices(configurator =>
{
    configurator.DisableCheckForCustomControllers();
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseStaticFiles(new StaticFileOptions
{
    FileProvider = new PhysicalFileProvider(Path.Combine(app.Environment.ContentRootPath, "node_modules")),
    RequestPath = "/node_modules"
});
app.UseRouting();

app.UseAuthorization();
app.UseDevExpressControls();
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
