using System;
using System.Collections.Generic;
using System.Text;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AradFinal.DataAccessLayer.Entities
{
    public class Factor : BaseEntity
    {
        [Display(Name="تاریخ صدور")]
        [MaxLength(10)]
        public string Date { get; set; }

        [Display(Name = "شماره فاکتور")]
        [MaxLength(8)]
        public string Number { get; set; }

        [Display(Name="جمع کل")]
        public long Price { get; set; }

        public Guid UserId { get; set; }

        [ForeignKey("UserId")]
        public virtual User User { get; set; }

        public virtual ICollection<FactorDetail> FactorDetails { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}
