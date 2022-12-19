﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DevExpressDemo.Models
{
    [Keyless]
    public partial class ViewPayroll
    {
        [StringLength(100)]
        public string EmployeeNameA { get; set; }
        [StringLength(100)]
        public string EmployeeNameE { get; set; }
        public double? AbesnAmount { get; set; }
        public double? HealthInsurance { get; set; }
        public double? OtherAllow { get; set; }
        [Column(TypeName = "ntext")]
        public string Notes { get; set; }
        [StringLength(50)]
        public string CheckDate { get; set; }
        [StringLength(50)]
        public string CheckNo { get; set; }
        public int? PaymentType { get; set; }
        public double? TotalDeductionDay { get; set; }
        public double? TotalOverTimeHours { get; set; }
        public double? Loan { get; set; }
        public double? TotalDeduction { get; set; }
        public double? TotalPay { get; set; }
        public double? TotalOverTime { get; set; }
        public double? BonusAmount { get; set; }
        public double? TransAllow { get; set; }
        public double? HousingAllow { get; set; }
        public double? BasicSalary { get; set; }
        [StringLength(50)]
        public string PayRollDate { get; set; }
        [Required]
        [StringLength(50)]
        public string EmployeeCode { get; set; }
        [StringLength(50)]
        public string BranchID { get; set; }
        public int? DepartmentID { get; set; }
        public int? Status { get; set; }
        public int? CategoryID { get; set; }
        [StringLength(50)]
        public string MDDName { get; set; }
        public bool? Done { get; set; }
        public int PayRollID { get; set; }
        public int? PaySales { get; set; }
        [StringLength(50)]
        public string AccIDO { get; set; }
        [StringLength(50)]
        public string AccIDE { get; set; }
        [StringLength(50)]
        public string AccIDDe { get; set; }
        [StringLength(50)]
        public string AccID { get; set; }
        public int? BankID { get; set; }
        public double? OpenBalance { get; set; }
        [StringLength(100)]
        public string DepartmentNameA { get; set; }
        [StringLength(100)]
        public string DepartmentNameE { get; set; }
        [StringLength(50)]
        public string BankAccountNo { get; set; }
        [StringLength(50)]
        public string BankName { get; set; }
        [StringLength(50)]
        public string BankNameEng { get; set; }
        [StringLength(50)]
        public string MDDNameEng { get; set; }
        [StringLength(100)]
        public string JobNameA { get; set; }
        [StringLength(100)]
        public string JobNameE { get; set; }
        [StringLength(100)]
        public string JobDescription { get; set; }
        public double? Socialinsurance { get; set; }
        [StringLength(100)]
        public string BWBrWaName { get; set; }
    }
}