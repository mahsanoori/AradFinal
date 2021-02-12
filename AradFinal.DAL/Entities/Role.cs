using System;
using System.Collections.Generic;
using System.Text;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AradFinal.DataAccessLayer.Entities
{
    public class Role : BaseEntity
    {
        [Display(Name="نام سیستمی نقش")]
        [MaxLength(20)]
        public string Name { get; set; }

        [Display(Name="عنوان نقش")]
        [MaxLength(20)]
        public string Title { get; set; }

        public virtual ICollection<User> Users { get; set; }
    }
}
