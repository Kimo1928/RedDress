using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedDress.Core.Entities
{
    public class Order
    {
        public string Id { get; set; }

        public DateTime OrderDate { get; set; }


        public string Status { get; set; }


        public decimal TotalAmount { get; set; }

        public string UserId { get; set; }

        public virtual UserAccount UserAccount { get; set; }





    }
}
