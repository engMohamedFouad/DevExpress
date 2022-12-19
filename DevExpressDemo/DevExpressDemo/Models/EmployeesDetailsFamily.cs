﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DevExpressDemo.Models
{
    [Table("EmployeesDetailsFamily")]
    public partial class EmployeesDetailsFamily
    {
        [Key]
        public int ID { get; set; }
        public int EmployeeCode { get; set; }
        [StringLength(100)]
        public string EmployeeNameA { get; set; }
        [StringLength(100)]
        public string EmployeeNameE { get; set; }
        [StringLength(30)]
        public string Passwords { get; set; }
        public int? GenderID { get; set; }
        [StringLength(50)]
        public string DOBHI { get; set; }
        [StringLength(50)]
        public string DOBGR { get; set; }
        public int? ReligionID { get; set; }
        public int? BloodType { get; set; }
        public int? Qualification { get; set; }
        [StringLength(50)]
        public string FamilyEmp { get; set; }
        public int? Nationality { get; set; }
        public int? MaritalStatus { get; set; }
        [StringLength(50)]
        public string Dependents { get; set; }
        [StringLength(50)]
        public string PassportNo { get; set; }
        [StringLength(50)]
        public string PassportExpires { get; set; }
        [StringLength(50)]
        public string PassportStart { get; set; }
        [StringLength(50)]
        public string PassportPlace { get; set; }
        [StringLength(50)]
        public string IdntityNo { get; set; }
        [StringLength(50)]
        public string IdntityExpires { get; set; }
        [StringLength(50)]
        public string IdntityStart { get; set; }
        [StringLength(50)]
        public string IdntityPlace { get; set; }
        [StringLength(50)]
        public string Mobile { get; set; }
        [StringLength(50)]
        public string Email { get; set; }
        [StringLength(50)]
        public string BranchID { get; set; }
        public int? Status { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? LastModified { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? Created { get; set; }
        [StringLength(50)]
        public string CreatedBy { get; set; }
        [StringLength(50)]
        public string LastModifiedBy { get; set; }

        [ForeignKey("EmployeeCode")]
        [InverseProperty("EmployeesDetailsFamilies")]
        public virtual EmployeesDetail EmployeeCodeNavigation { get; set; }
    }
}