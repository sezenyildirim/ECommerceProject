using ECommerce.Entity.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Entity.Entities
{
    public class Option:BaseEntity
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public ICollection<Product> Products { get; set; }
        public ICollection<Discount> Discounts { get; set; }
    }
}

//ürünün sahip olduğu özellikler ve açıklamaları title ve desc alanlarına gelir
//örn: ayakkabı - title=siyah desc=bu ürün siyah bir ayakkabıdır