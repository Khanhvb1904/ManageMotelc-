using API_ManageMotel_Fpoly.EF.ManageMotelDbContext;
using API_ManageMotel_Fpoly.IServices;
using API_ManageMotel_Fpoly.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IHostingEnvironment = Microsoft.Extensions.Hosting.IHostingEnvironment;

namespace API_ManageMotel_Fpoly
{
    public class Startup
    {
        private IHostingEnvironment _IHostingEnviroment;
        public Startup(IConfiguration configuration, IHostingEnvironment ihostingEnvironment)
        {
            Configuration = configuration;
            _IHostingEnviroment = ihostingEnvironment;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {

            #region Cros API
            services.AddCors(options =>
            {
                //options.AddDefaultPolicy(

                //     builder => builder.WithOrigins("Link view"));
                //options.AddPolicy("Mypolicy", builder => builder.WithOrigins("Link api"));
            }
            );
            services.AddHttpContextAccessor();
            services.AddRazorPages();
            #endregion


            #region Add Database
            services.AddDbContext<ManageMotelDbContext>(x => x.UseSqlServer(Configuration.GetConnectionString("ManageMotelConnectionString")));
            #endregion

            #region Add Transient
            services.AddTransient<IThongTinNhaTroServices, ThongTinNhaTroServices>();
            services.AddTransient<IPhongService, PhongService>();
            #endregion


   
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseCors();
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
            }
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }


    }
}
