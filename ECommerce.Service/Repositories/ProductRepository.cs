using ECommerce.Application.Repositories;
using ECommerce.DataAccess.Context;
using ECommerce.Entity.Entities;
using ECommerce.Service.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Service.Repositories
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        public ProductRepository(eCommerceDBContext context) : base(context)
        {
        }
    }
}
