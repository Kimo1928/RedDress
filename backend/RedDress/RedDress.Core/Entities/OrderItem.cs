using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedDress.Core.Entities
{
    public class OrderItem
    {
        public string Id { get; set; }


        public int quantity { get; set; }

        public string OrderId { get; set; }

        public string ClothesVarientId { get; set; }


        public virtual Order Order { get; set; }

        public virtual ClothesVariant ClothesVariant { get; set; }
    }
}
