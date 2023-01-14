using MediatR;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using UpSchool_CQRS_DesignPatterns.CQRS.Handlers.ProductHandlers;
using UpSchool_CQRS_DesignPatterns.CQRS.Handlers.StudentHandlers;
using UpSchool_CQRS_DesignPatterns.DAL.Context;

namespace UpSchool_CQRS_DesignPatterns
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {

            //CQRS i�in konfig�rasyonlar
            services.AddDbContext<ProductContext>();
            services.AddScoped<GetProductByAccounterQueryHandler>(); 
             
            services.AddMediatR(typeof(Startup)); 

            services.AddScoped<GetProductStoragerQueryHandler>();
            services.AddScoped<GetProductHumanResourcesByIDQueryHandler>();
            services.AddScoped<GetProductAccounterByIDQueryHandler>();
            services.AddScoped<CreateStudentCommandHandler>();
            services.AddScoped<GetAllStudentQueryHandler>();
            services.AddScoped<RemoveStudentCommandHandler>();
            services.AddScoped<GetStudentByIDQueryHandler>();
            services.AddScoped<UpdateStudentCommandHandler>();
            services.AddControllersWithViews();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}