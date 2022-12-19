﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DevExpressDemo.Models
{
    [Table("InstallmentMonthly")]
    public partial class InstallmentMonthly
    {
        [Key]
        public int ID { get; set; }
        [StringLength(50)]
        public string MonthDate { get; set; }
        public int? EmployeeCode { get; set; }
        public bool? Posted { get; set; }
        [Column(TypeName = "money")]
        public decimal? PaymentAmount { get; set; }
        [Column(TypeName = "money")]
        public decimal? RemainPa { get; set; }
        [Column(TypeName = "money")]
        public decimal? InstallAmount { get; set; }
        [StringLength(50)]
        public string OrderID { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? LastModified { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? Created { get; set; }
        [StringLength(50)]
        public string CreatedBy { get; set; }
        [StringLength(50)]
        public string LastModifiedBy { get; set; }

        [ForeignKey("EmployeeCode")]
        [InverseProperty("InstallmentMonthlies")]
        public virtual EmployeesDetail EmployeeCodeNavigation { get; set; }
    }
}