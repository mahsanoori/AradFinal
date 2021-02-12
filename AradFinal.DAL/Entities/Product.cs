using System;
using System.Collections.Generic;
using System.Text;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AradFinal.DataAccessLayer.Entities
{
    public class Product : BaseEntity
    {
        public Guid? UserId { get; set; }

        [Display(Name="نام دوره")]
        [MaxLength(100)]
        public string Name { get; set; }

        [Display(Name = "تصویر شاخص")]
        public string Img { get; set; }

        [Display(Name = "شهریه")]
        public string Price { get; set; }

        [Display(Name = "سایر توضیحات")]
        public string Desc { get; set; }

        [Display(Name = "تاریخ ثبت")]
        [MaxLength(10)]
        public string Date { get; set; }

        [Display(Name = "زمان ثبت")]
        [MaxLength(10)]
        public string Time { get; set; }

        [Display(Name = "عدم نمایش")]
        public bool NotShow { get; set; }

        public virtual ICollection<ProductCategory> ProductCategories { get; set; }

        public virtual ICollection<Gallery> Galleries { get; set; }

        public virtual ICollection<ProductSeen> ProductSeens { get; set; }

    }
}
