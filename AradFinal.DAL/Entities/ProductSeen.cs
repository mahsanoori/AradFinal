using System;
using System.Collections.Generic;
using System.Text;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AradFinal.DataAccessLayer.Entities
{
    public class ProductSeen : BaseEntity
    {
        public Guid ProductId { get; set; }

        [Display(Name="تاریخ")]
        [MaxLength(10)]
        public string Date { get; set; }

        [Display(Name = "ساعت")]
        [MaxLength(10)]
        public string Time { get; set; }

        [Display(Name = "IP")]
        [MaxLength(30)]
        public string IP { get; set; }

        [ForeignKey("ProductId")]
        public virtual Product Product { get; set; }
    }
}
