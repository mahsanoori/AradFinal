using System;
using System.Collections.Generic;
using System.Text;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AradFinal.DataAccessLayer.Entities
{
    public class UserIP : BaseEntity
    {
        public Guid UserId { get; set; }

        [Display(Name="IP")]
         [MaxLength(30)]
        public string IP { get; set; }

        [Display(Name = "تاریخ")]
        [MaxLength(10)]
        public string Date { get; set; }

        [ForeignKey("UserId")]
        public virtual User User { get; set; }
    }
}
