using AradFinal.DataAccessLayer.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace AradFinal.DAL.Entities
{
   public class Social:BaseEntity
    {
        [Display(Name="نام شبکه")]
        [MaxLength(100)]
        public string Name { get; set; }

        [Display(Name = "آیکون")]
        [MaxLength(100)]
        public string Icon { get; set; }

        [Display(Name = "کدرنگ")]
        [MaxLength(10)]
        public string Color { get; set; }

        [Display(Name = "آدرس")]
        public string Address { get; set; }

        [Display(Name = "ترتیب نمایش")]
        public int OrderShow { get; set; }
    }
}
