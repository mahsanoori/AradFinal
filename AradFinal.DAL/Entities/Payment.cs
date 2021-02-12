using System;
using System.Collections.Generic;
using System.Text;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AradFinal.DataAccessLayer.Entities
{
    public class Payment : BaseEntity
    {
        public Guid UserId { get; set; }

        [Display(Name="کد سفارش")]
        [MaxLength(8)]
        public string Number { get; set; }

        [Display(Name = "تاریخ")]
        [MaxLength(10)]
        public string Date { get; set; }

        [Display(Name = "ساعت")]
        [MaxLength(10)]
        public string Time { get; set; }

        [Display(Name = "کد پیگیری")]
        [MaxLength(30)]
        public string RefCode { get; set; }

        [Display(Name="مبلغ سفارش")]
        public long Price { get; set; }

        [Display(Name = "سایر توضیحات")]
        [MaxLength(100)]
        public string Desc { get; set; }

        [Display(Name="وضعیت پرداخت")]
        public bool IsPay { get; set; }

        [ForeignKey("UserId")]
        public virtual User User { get; set; }
    }
}
