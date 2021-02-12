using System;
using System.Collections.Generic;
using System.Text;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AradFinal.DataAccessLayer.Entities
{
    public class Category : BaseEntity
    {
        public Guid? ParentId { get; set; }

        [Display(Name="نام دسته")]
        [MaxLength(50)]
        public string Name { get; set; }

        [Display(Name="ترتیب نمایش")]
        public int OrderShow { get; set; }

        [ForeignKey("ParentId")]
        public virtual Category Parent { get; set; }

        public virtual ICollection<ProductCategory> ProductCategories { get; set; }
    }
}
