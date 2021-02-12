using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace AradFinal.Core.ViewModels.Dashboard
{
   public class BannerSettingViewModel
    {
        [Display(Name = "بارگزاری بنر")]
        public IFormFile BannerImg { get; set; }

        public string BannerImgName { get; set; }

        [Display(Name = "عنوان بنر")]
        [MaxLength(100 , ErrorMessage = "مقدار{0} نباید بیش از{1} باشد.")]
        public string BannerTitle { get; set; }

        [Display(Name = "نوشته بنر")]
        [MaxLength(100 , ErrorMessage = "مقدار{0} نباید بیش از{1} باشد.")]
        public string BannerSubTitle { get; set; }
    }
}
