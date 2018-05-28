using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;

namespace People.API
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddCors();
            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            app.UseStaticFiles();
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler();
            }

            app.UseStatusCodePages();
            app.UseCors(builder => builder.AllowAnyOrigin());
            app.UseMvc();

            app.Run(async (context) =>
            {
                var message = introduction();
                context.Response.ContentType = "text/html";
                await context.Response.WriteAsync(message);
            });
        }
        private string introduction()
        {
            return @" 
            <title>Krzysztof Szczurowski - Test WebApi 2.0</title>
            <style type='text/css'>
            table, th, td {
                border: 1px solid black;
            }                  
            </style>
            <h1> This is a practice API using ASP.NET Core 2.0 </h1>
            <div>
                <p>If you see this message the API is up and Running. <br/>Use Postman to intorigate this API.</p>
            </div>
            <div>
                <table style='width: 100 % '>
                    <tr>
                        <th> URL </ th >
                        <th> Description</th>
                    </tr>
                    <tr> 
                        <td> /api/people/ </td> 
                        <td>  Get all People as [JSON] collection </ td >
                    </tr>
                    <tr>
                        <td> /api/people/0 </td>
                        <td> Get a [JSON] object with 0th person details </td>
                    </tr>
                </table>
             </div>
            ";
        }
    }
}
