using ECommerce.Entity.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Entity.Entities
{
    public class Basket:BaseEntity
    {
        public Product Product { get; set; }
        public int Unit { get; set; }
        public decimal Total { get; set; }
        public decimal Discount { get; set; }
        public DateTime BasketAddedDate { get; set; }
        public bool IsPayment { get; set; } = false; 
        public ICollection<Order> Orders { get; set; }  
    }
}
