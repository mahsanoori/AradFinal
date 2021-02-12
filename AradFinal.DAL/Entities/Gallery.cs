using System;
using System.Collections.Generic;
using System.Text;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AradFinal.DataAccessLayer.Entities
{
    public class Gallery : BaseEntity
    {
        public Guid ProductId { get; set; }

        [Display(Name="تصویر")]
        [MaxLength(100)]
        public string Img { get; set; }

        [Display(Name = "عنوان")]
        [MaxLength(100)]
        public string Title { get; set; }

        [ForeignKey("ProductId")]
        public virtual Product Product { get; set; }
    }
}
