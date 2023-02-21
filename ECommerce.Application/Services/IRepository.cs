using ECommerce.Entity.Entities.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Application.Services
{
    public interface IRepository<T> where T : BaseEntity
    {
        DbSet<T> Table { get; }
        IQueryable<T> GetAll(); //tüm listeyi döner
        IQueryable<T> GetWhere(Expression<Func<T, bool>> predicate);//sorgu
        Task<T> GetSingle(Expression<Func<T, bool>> predicate);//sorgu ile tek değer döner
        Task<T> GetByID(string ID);//id'ye göre tek değer döner
        Task<bool> AddAsync(T model);
        Task<bool> AddRangeAsync(List<T> model);//birden fazla değer kaydeder
        bool Delete(T model);
        bool DeleteRange(List<T> model);//bir aralık içerisinde silme yapar
        Task<bool> DeleteAsync(string ID);
        bool Update(T model);
        Task<int> SaveAsync();
    }
}
