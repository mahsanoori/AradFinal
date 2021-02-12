using System;
using System.Collections.Generic;
using System.Text;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AradFinal.DataAccessLayer.Entities
{
    public class FactorDetail : BaseEntity
    {
        public Guid FactorId { get; set; }
        public Guid ProductId { get; set; }

        [Display(Name="تعداد")]
        public int Qty { get; set; }

        [Display(Name="قیمت واحد")]
        public long Price { get; set; }

        [ForeignKey("FactorId")]
        public virtual Factor Factor { get; set; }

        [ForeignKey("ProductId")]
        public virtual Product Product { get; set; }
    }
}
