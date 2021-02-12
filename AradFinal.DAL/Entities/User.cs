using System;
using System.Collections.Generic;
using System.Text;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AradFinal.DataAccessLayer.Entities
{
    public class User : BaseEntity
    {
        [Display(Name="نام کاربری")]
        [MaxLength(100)]
        public string Username { get; set; }

        [Display(Name = "رمز ورود")]
        [MaxLength(100)]
        public string Password { get; set; }

        [Display(Name="فعال/غیرفعال")]
        public bool IsActive { get; set; }

        [Display(Name="تاریخ عضویت")]
        [MaxLength(10)]
        public string Date { get; set; }

        [Display(Name = "کد")]
        [MaxLength(6)]
        public string Code { get; set; }

        [Display(Name="موجودی کیف پول")]
        public long Wallet { get; set; }

        public Guid RoleId { get; set; }

        [ForeignKey("RoleId")]
        public virtual Role Role { get; set; }

        public virtual UserDetail UserDetail { get; set; }

        public virtual ICollection<UserIP> UserIPs { get; set; }

        public virtual ICollection<UserAddress> UserAddresses { get; set; }

        public virtual ICollection<Payment> Payments { get; set; }

        public virtual ICollection<Factor> Factors { get; set; }
    }
}
