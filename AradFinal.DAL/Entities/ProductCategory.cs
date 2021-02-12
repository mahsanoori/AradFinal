using System;
using System.Collections.Generic;
using System.Text;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AradFinal.DataAccessLayer.Entities
{
    public class ProductCategory : BaseEntity
    {
        public Guid CategoryId { get; set; }

        public Guid ProductId { get; set; }

        [ForeignKey("CategoryId")]
        public virtual Category Category { get; set; }

        [ForeignKey("ProductId")]
        public virtual Product Product { get; set; }
    }
}
