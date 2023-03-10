// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DevExpressDemo.Models
{
    [Table("MainAccCompanyHR")]
    public partial class MainAccCompanyHR
    {
        [Key]
        public int MACID { get; set; }
        [StringLength(50)]
        public string AccountID { get; set; }
        [StringLength(50)]
        public string AccountValue { get; set; }
        [StringLength(100)]
        public string NameValue { get; set; }
        [StringLength(100)]
        public string NameValueEng { get; set; }
        public int? TypeIn { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? LastModified { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? Created { get; set; }
        [StringLength(50)]
        public string CreatedBy { get; set; }
        [StringLength(50)]
        public string LastModifiedBy { get; set; }

        [ForeignKey("AccountID")]
        [InverseProperty("MainAccCompanyHRs")]
        public virtual TreeAccount Account { get; set; }
    }
}