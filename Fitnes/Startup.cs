using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Fitnes.Storage;
using Fitnes.Storage.Manager.Clients;
using Fitnes.Storage.Manager.Authors;
using Fitnes.Storage.Manager.Gyms;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Fitnes.Storage.Manager.Positions;
using Fitnes.Storage.Manager.ProgramWorkouts;
using Fitnes.Storage.Manager.Employers;
using Fitnes.Storage.Manager.Subscriptions;
using Fitnes.Storage.Manager.Trainers;
using Fitnes.Storage.Manager.TrainingMachines;

namespace Fitnes {
    public class Startup {
        private IConfigurationRoot _confString;

        public Startup(IHostingEnvironment hostEnv) {
            _confString = new ConfigurationBuilder().SetBasePath(hostEnv.ContentRootPath).AddJsonFile("FitnesDbSettings.json").Build();
        }
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services) {
            services.AddDbContext<FitnesDbContext>(options => options.UseSqlServer(_confString.GetConnectionString("DefaultConnection")));
            services.AddMvc(option => option.EnableEndpointRouting = false);
            services.AddTransient<IAuthorManager, AuthorManager>();
            services.AddTransient<IClientManager, ClientManager>();
            services.AddTransient<IEmployeeManager, EmployeeManager>();
            services.AddTransient<IGymManager, GymManager>();
            services.AddTransient<IPositionManager, PositionManager>();
            services.AddTransient<IProgramWorkoutManager, ProgramWorkoutManager>();
            services.AddTransient<ISubscriptionManager, SubscriptionManager>();
            services.AddTransient<ITrainerManager, TrainerManager>();
            services.AddTransient<ITrainingMachineManager, TrainingMachineManager>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env) {
            app.UseDeveloperExceptionPage();
            app.UseStatusCodePages();
            app.UseStaticFiles();
            app.UseMvcWithDefaultRoute();
            app.UseMvc(routes => {
                routes.MapRoute(
                name: "default",
                template: "{controller=Main}/{action=MainPage}");
            });
        }

    }
}
