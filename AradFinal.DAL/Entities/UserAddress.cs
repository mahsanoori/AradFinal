using System;
using System.Collections.Generic;
using System.Text;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AradFinal.DataAccessLayer.Entities
{
    public class UserAddress : BaseEntity
    {
        public Guid UserId { get; set; }

        [Display(Name="عنوان آدرس")]
        [MaxLength(50)]
        public string Title { get; set; }

        [Display(Name = "آدرس کامل")]
        public string Address { get; set; }

        [Display(Name = "استان")]
        [MaxLength(40)]
        public string Region { get; set; }

        [Display(Name = "شهرستان")]
        [MaxLength(40)]
        public string City { get; set; }

        [Display(Name = "کد پستی")]
        [MaxLength(10)]
        public string Postal { get; set; }

        [ForeignKey("UserId")]
        public virtual User User { get; set; }
    }
}
