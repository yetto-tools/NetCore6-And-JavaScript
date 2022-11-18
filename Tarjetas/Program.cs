using Microsoft.Extensions.FileProviders;
using Microsoft.OpenApi.Models;
using Tarjetas;


var builder = WebApplication.CreateBuilder(args);
var startup = new Startup(builder.Configuration);

startup.ConfigurationServices(builder.Services);

var app = builder.Build();

app.UseStaticFiles(new StaticFileOptions
{
    FileProvider = new PhysicalFileProvider(
        Path.Combine(builder.Environment.ContentRootPath, app.Environment.ContentRootPath)),
    RequestPath = "/app"
});

app.UseFileServer(new FileServerOptions
{
    FileProvider = new PhysicalFileProvider(
        Path.Combine(builder.Environment.ContentRootPath, app.Environment.ContentRootPath)),
    RequestPath = "/public",
    EnableDirectoryBrowsing = true
});

startup.Configure(app, app.Environment);


app.Run();

//namespace Tarjetas
//{
//    public class Program
//    {
//        public static void Main(string[] args)
//        {
//            var builder = WebApplication.CreateBuilder(args);

//            // Add services to the container.

//            builder.Services.AddControllers();

//            builder.Services.AddEndpointsApiExplorer();
//            builder.Services.AddSwaggerGen();

//            builder.Services.AddDirectoryBrowser();

//            builder.Services.AddDbContext<ApplicationDbContext>(options => 
//                options.UseSqlServer("name:ConnectionString:Dev")
//            );

//            //add autentication endpotins

//            //builder.Services.AddAuthorization(options =>
//            //{
//            //    options.FallbackPolicy = new AuthorizationPolicyBuilder()
//            //        .RequireAuthenticatedUser()
//            //        .Build();
//            //});

//            builder.Services.AddCors();

//            var app = builder.Build();

//            // Configure the HTTP request pipeline.
//            if (app.Environment.IsDevelopment())
//            {
//                app.UseSwagger();
//                app.UseSwaggerUI();
//                app.UseExceptionHandler("/Error");
//                app.UseHsts();
//            }

//            app.UseHttpsRedirection();

//            app.UseCors(x => x.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader());

//            app.UseDefaultFiles();

//            app.UseStaticFiles();

//            app.UseAuthorization();

//            app.UseStaticFiles(new StaticFileOptions
//            {
//                FileProvider = new PhysicalFileProvider(
//                       Path.Combine(builder.Environment.ContentRootPath, app.Environment.ContentRootPath)),
//                RequestPath = "/app"
//            });

//            app.UseFileServer(new FileServerOptions
//            {
//                FileProvider = new PhysicalFileProvider(
//                    Path.Combine(builder.Environment.ContentRootPath, app.Environment.ContentRootPath)),
//                RequestPath = "/public",
//                EnableDirectoryBrowsing = true
//            });


//            app.MapControllers();

//            app.Run();
//        }
//    }
//}



