using System;
using System.Collections.Generic;
using System.Text;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AradFinal.DataAccessLayer.Entities
{
    public class UserDetail
    {
        [Key , ForeignKey("User")]
        public Guid UserId { get; set; }

        [Display(Name="نام")]
        [MaxLength(40)]
        public string FirstName { get; set; }

        [Display(Name="نام خانوادگی")]
        [MaxLength(40)]
        public string LastName { get; set; }

        [Display(Name="شماره تماس")]
        [MaxLength(20)]
        public string Tel { get; set; }

        public virtual User User { get; set; }

    }
}
