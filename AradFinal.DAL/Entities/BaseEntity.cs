using System;
using System.Collections.Generic;
using System.Text;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AradFinal.DataAccessLayer.Entities
{
    public class BaseEntity
    {
         [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public Guid Id { get; set; }

        [Display(Name="حذف شده")]
        public bool IsDelete { get; set; }

        [Display(Name="تاریخ آخرین تغییرات")]
         [MaxLength(10)]
        public string LastModifyDate { get; set; }

        [Display(Name= "ساعت آخرین تغییرات")]
         [MaxLength(8)]
        public string LastModifyTime { get; set; }
    }
}
