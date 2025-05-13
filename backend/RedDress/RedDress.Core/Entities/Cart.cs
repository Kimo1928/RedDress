using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedDress.Core.Entities
{
    public class Cart
    {
        public string Id { get; set; }


        public int quantity { get; set; }


        public DateTime AddedAt { get; set; }


        public string UserId { get; set; }

        public string ClothesVarientId { get; set; }


        public virtual UserAccount UserAccount { get; set; }

        public virtual ClothesVariant ClothesVariant { get; set; }
    }
}
