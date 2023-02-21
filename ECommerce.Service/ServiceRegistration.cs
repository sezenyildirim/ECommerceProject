using ECommerce.Application.Repositories;
using ECommerce.Application.Services;
using ECommerce.Service.Repositories;
using ECommerce.Service.Services;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Service
{
    public static class ServiceRegistration
    {
       public static void AddServiceRegister(this IServiceCollection services)//this, IServiceCollection'a bu metodu ekliyor
        {
            services.AddScoped<IProductRepository, ProductRepository>();
            services.AddScoped<IProductService, ProductService>();
            services.AddScoped<IUserService, UserService>();
        }
    }
}
