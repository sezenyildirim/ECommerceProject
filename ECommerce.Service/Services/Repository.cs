using ECommerce.Application.Services;
using ECommerce.DataAccess.Context;
using ECommerce.Entity.Entities.Abstract;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Service.Services
{
    public class Repository<T> : IRepository<T> where T : BaseEntity
    {
        private readonly eCommerceDBContext _context;

        public Repository(eCommerceDBContext context)
        {
            _context = context;
        }

        public DbSet<T> Table => _context.Set<T>();

        public async Task<bool> AddAsync(T model)
        {
            EntityEntry entityEntry = await Table.AddAsync(model);
            return entityEntry.State == EntityState.Added;
        }

        public async Task<bool> AddRangeAsync(List<T> model)
        {
            await Table.AddRangeAsync(model);
            return true;
        }

        public bool Delete(T model)
        {
            EntityEntry entityEntry = Table.Remove(model);
            return entityEntry.State == EntityState.Deleted;
        }

        public async Task<bool> DeleteAsync(string ID)
        {
            T model = await Table.FirstOrDefaultAsync(p => p.ID == Guid.Parse(ID));
            EntityEntry<T> entityEntry = Table.Remove(model);
            return entityEntry.State == EntityState.Deleted;
        }

        public bool DeleteRange(List<T> model)
        {
            Table.RemoveRange(model);
            return true;
        }

        public  IQueryable<T> GetAll()
        {
          IQueryable<T> list =  Table.AsQueryable();
            return list;
        }

        public async Task<T> GetByID(string ID)
        {
          T model =  await Table.FindAsync(ID);
            return model;
        }

        public async Task<T> GetSingle(Expression<Func<T, bool>> predicate)
        {

           T model = await Table.SingleOrDefaultAsync(predicate);
            return model;
        }

        public IQueryable<T> GetWhere(Expression<Func<T, bool>> predicate)
        {
            IQueryable<T> list = Table.Where(predicate);
            return list;
        }

        public async Task<int> SaveAsync()
        {
            int count = await _context.SaveChangesAsync();
            return count;
        }

        public bool Update(T model)
        {
           EntityEntry<T> entityEntry = Table.Update(model);
            return entityEntry.State == EntityState.Modified;
        }
    }
}
