﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DevExpressDemo.Models
{
    [Table("Deduction")]
    public partial class Deduction
    {
        public int ID { get; set; }
        [Key]
        [StringLength(50)]
        public string DisOrderNo { get; set; }
        public int? EmployeeCode { get; set; }
        [StringLength(50)]
        public string DisOrderDate { get; set; }
        [StringLength(50)]
        public string FromMonth { get; set; }
        [Column(TypeName = "money")]
        public decimal? InstallmentAmount { get; set; }
        [StringLength(100)]
        public string Note { get; set; }
        [Column(TypeName = "money")]
        public decimal? InstallmentIn { get; set; }
        public bool? ChPaymentSalar { get; set; }
        public bool? Done { get; set; }
        public int? DeductionType { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? LastModified { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? Created { get; set; }
        [StringLength(50)]
        public string CreatedBy { get; set; }
        [StringLength(50)]
        public string LastModifiedBy { get; set; }

        [ForeignKey("EmployeeCode")]
        [InverseProperty("Deductions")]
        public virtual EmployeesDetail EmployeeCodeNavigation { get; set; }
    }
}