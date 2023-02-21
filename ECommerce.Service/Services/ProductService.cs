using ECommerce.Application.Repositories;
using ECommerce.Application.Services;
using ECommerce.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Service.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _repository;

        public ProductService(IProductRepository repository)
        {
            _repository = repository;
        }

        public async Task AddAsync(Product product)
        {
            await _repository.AddAsync(product);
            await _repository.SaveAsync();
        }

        public async Task DeleteAsync(string ID)
        {
            await _repository.DeleteAsync(ID);
            await _repository.SaveAsync();

        }

        public async Task<Product> GetByID(string ID)
        {
            Product product = await _repository.GetByID(ID);
            return product;
        }

        public IList<Product> GetProducts()
        {
            IList<Product> products = _repository.GetAll().ToList();
            return products;
        }

        public async Task UpdateAsync(Product product)
        {
            _repository.Update(product);
            await _repository.SaveAsync();
        }
    }
}
