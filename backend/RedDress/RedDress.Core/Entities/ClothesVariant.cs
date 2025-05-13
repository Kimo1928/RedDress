using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedDress.Core.Entities
{
    public class ClothesVariant
    {
        public string Id { get; set; }

      public string ClothesId { get; set; }

        public int ClothesColorId { get; set; }

        public int ClothesSizeId { get; set; }

        public int stock { get; set; }


        public string PhotoId { get; set; }


        public decimal PricePerUnit { get; set; }


        public virtual ClothesColor ClothesColor { get; set; }

        public virtual ClothesSize ClothesSize { get; set; }

        public virtual Photo Photo { get; set; }

       

    }
}
