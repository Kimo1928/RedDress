using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedDress.Core.Entities
{
    public class Clothes
    {
        public string Id { get; set; }
        public string Name { get; set; }

        public DateTime JoinedAt { get; set; }

        public string Description { get; set; }

        public int ClothesTypeId { get; set; }

        public virtual ClothesType ClothesType { get; set; }

    }
}
