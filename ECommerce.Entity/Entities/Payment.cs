using ECommerce.Entity.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Entity.Entities
{
    public class Payment:BaseEntity
    {
        public Order Order { get; set; }
        public string NameLastName { get; set; }
        public string CreditCardNumber { get; set; }
        public string ExpireDate { get; set; }
        public string CVV { get; set; }
        public DateTime CreatedDate { get; set; }
        public bool IsPaymentSuccess { get; set; }
    }
}
