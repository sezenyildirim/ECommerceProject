using ECommerce.Entity.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Entity.Entities
{
    public class Comment:BaseEntity
    {
        public ICollection<Product> Products { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string UserID { get; set; }
        public DateTime CommentDate { get; set; }
    }
}
