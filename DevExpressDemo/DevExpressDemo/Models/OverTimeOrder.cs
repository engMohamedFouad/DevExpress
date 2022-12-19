﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DevExpressDemo.Models
{
    [Table("OverTimeOrder")]
    public partial class OverTimeOrder
    {
        public int OverTimeID { get; set; }
        [Key]
        [StringLength(50)]
        public string OverTimeOrderNo { get; set; }
        public int? EmployeeCode { get; set; }
        [StringLength(50)]
        public string OverTimeOrderDate { get; set; }
        public double? TotalOverHourse { get; set; }
        [Column(TypeName = "money")]
        public decimal? OverTimeAmount { get; set; }
        [StringLength(100)]
        public string Note { get; set; }
        [StringLength(50)]
        public string AddOverDate { get; set; }
        public bool? ChekAdd { get; set; }
        public bool? Done { get; set; }
        [StringLength(50)]
        public string AccFundID { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? LastModified { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? Created { get; set; }
        [StringLength(50)]
        public string CreatedBy { get; set; }
        [StringLength(50)]
        public string LastModifiedBy { get; set; }

        [ForeignKey("AccFundID")]
        [InverseProperty("OverTimeOrders")]
        public virtual TreeAccount AccFund { get; set; }
        [ForeignKey("EmployeeCode")]
        [InverseProperty("OverTimeOrders")]
        public virtual EmployeesDetail EmployeeCodeNavigation { get; set; }
    }
}