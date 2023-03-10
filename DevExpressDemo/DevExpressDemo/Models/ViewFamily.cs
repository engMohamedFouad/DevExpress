// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DevExpressDemo.Models
{
    [Keyless]
    public partial class ViewFamily
    {
        [StringLength(100)]
        public string EmployeeNameFA { get; set; }
        [StringLength(100)]
        public string EmployeeNameFE { get; set; }
        [StringLength(100)]
        public string MaritalStatusNameA { get; set; }
        [StringLength(100)]
        public string MaritalStatusNameE { get; set; }
        [StringLength(50)]
        public string DateF { get; set; }
        [StringLength(50)]
        public string GenderA { get; set; }
        [StringLength(50)]
        public string GenderE { get; set; }
        [StringLength(30)]
        public string CConNameArb { get; set; }
        [StringLength(30)]
        public string CConNameEng { get; set; }
        public int? Status { get; set; }
        [StringLength(50)]
        public string BranchID { get; set; }
        [StringLength(50)]
        public string Email { get; set; }
        [StringLength(50)]
        public string Mobile { get; set; }
        [StringLength(50)]
        public string IdntityPlace { get; set; }
        [StringLength(50)]
        public string IdntityStart { get; set; }
        [StringLength(50)]
        public string IdntityExpires { get; set; }
        [StringLength(50)]
        public string IdntityNo { get; set; }
        [Required]
        [StringLength(50)]
        public string EmployeeCode { get; set; }
        [StringLength(50)]
        public string PassportPlace { get; set; }
        [StringLength(50)]
        public string PassportStart { get; set; }
        [StringLength(50)]
        public string PassportExpires { get; set; }
        [StringLength(50)]
        public string PassportNo { get; set; }
        [StringLength(50)]
        public string Dependents { get; set; }
        public int? MaritalStatus { get; set; }
        public int? Nationality { get; set; }
        [StringLength(50)]
        public string FamilyEmp { get; set; }
        public int? Qualification { get; set; }
        public int? BloodType { get; set; }
        public int? ReligionID { get; set; }
        [StringLength(50)]
        public string DOBGR { get; set; }
        [StringLength(50)]
        public string DOBHI { get; set; }
        public int? GenderID { get; set; }
        [StringLength(30)]
        public string Passwords { get; set; }
        [StringLength(100)]
        public string EmployeeNameE { get; set; }
        [StringLength(100)]
        public string EmployeeNameA { get; set; }
        [StringLength(100)]
        public string MaritalStatusNameEC { get; set; }
        [StringLength(100)]
        public string MaritalStatusNameAC { get; set; }
        [StringLength(100)]
        public string DepartmentNameA { get; set; }
        [StringLength(100)]
        public string DepartmentNameE { get; set; }
        [StringLength(50)]
        public string NationalNo { get; set; }
        [StringLength(50)]
        public string ResidenceNo { get; set; }
        [StringLength(50)]
        public string EmailE { get; set; }
    }
}