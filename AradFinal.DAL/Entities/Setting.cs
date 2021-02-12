using System;
using System.Collections.Generic;
using System.Text;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AradFinal.DataAccessLayer.Entities
{
    public class Setting
    {
        public Guid Id { get; set; }

        [Display(Name="عنوان سایت")]
        public string Title { get; set; }

        [Display(Name="توضیح مختصر")]
        public string Desc { get; set; }

        [Display(Name="کلمات کلیدی")]
        public string Key { get; set; }

        [Display(Name="API")]
        public string SmsAPI { get; set; }

        [Display(Name="شماره تماس")]
        public string Tel { get; set; }

        [Display(Name="آدرس آموزشگاه")]
        public string Address { get; set; }

        [Display(Name="طول جغرافیایی")]
        [MaxLength(40 , ErrorMessage ="مقدار {0} نباید بیش از {1} باشد")]
        public string Lat { get; set; }

        [Display(Name="عرض جغرافیایی")]
        [MaxLength(40 , ErrorMessage ="مقدار {0} نباید بیش از {1} باشد")]
        public string Lng { get; set; }

        [Display(Name = "لوگو")]
        [MaxLength(100)]
        public string Logo { get; set; }

        [Display(Name = "تصویر بنر")]
        [MaxLength(100)]
        public string Banner { get; set; }

        [Display(Name = "عنوان بنر")]
        [MaxLength(100)]
        public string BannerTitle { get; set; }

        [Display(Name = "نوشته بنر")]
        [MaxLength(100)]
        public string BannerSubTitle { get; set; }
    }
}
