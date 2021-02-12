using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace AradFinal.Core.ViewModels.Dashboard
{
   public class SocialViewModel
    {
        [Display(Name = "نام شبکه")]
        [Required(ErrorMessage ="نباید بدون مقدار باشد.")]
        [MaxLength(100 , ErrorMessage = "مقدار{0} نباید بیش از{1} باشد.")]
        public string Name { get; set; }

        [Display(Name = "آیکون")]
        [Required(ErrorMessage ="نباید بدون مقدار باشد.")]
        [MaxLength(100, ErrorMessage = "مقدار{0} نباید بیش از{1} باشد.")]
        public string Icon { get; set; }

        [Display(Name = "کدرنگ")]
        public string Color { get; set; }

        [Display(Name = "آدرس")]
        [DataType(DataType.MultilineText)]
        public string Address { get; set; }

        [Display(Name = "ترتیب نمایش")]
        public int OrderShow { get; set; }
    }
}
