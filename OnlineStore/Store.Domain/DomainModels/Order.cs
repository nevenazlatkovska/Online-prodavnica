using Store.Domain.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Store.Domain.DomainModels
{
    public class Order: BaseEntity
    {
        public string UserId { get; set; }
        public StoreApplicationUser User { get; set; }
        public virtual ICollection<ProductInOrder> ProductInOrders { get; set; }

    }
}
