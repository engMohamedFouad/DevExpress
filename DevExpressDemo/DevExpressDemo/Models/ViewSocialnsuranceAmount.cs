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
    public partial class ViewSocialnsuranceAmount
    {
        public int ID { get; set; }
        public int? ContractType { get; set; }
        public int? ContractStatusID { get; set; }
        [StringLength(50)]
        public string ContractStart { get; set; }
        [StringLength(50)]
        public string ContractEnd { get; set; }
        public int? WorkingDays { get; set; }
        public int? WorkingHours { get; set; }
        public int? NoOfVacationDay { get; set; }
        public int? NoOfTicket { get; set; }
        public int? PayType { get; set; }
        public double? BasicSalary { get; set; }
        public double? HousingAllow { get; set; }
        public double? TransAllow { get; set; }
        public double? HealthInsurance { get; set; }
        public double? OtherAllow { get; set; }
        public double? TicketAmount { get; set; }
        public double? Net { get; set; }
        public double? SocialnsuranceAmount { get; set; }
        public int EmployeeID { get; set; }
        [Required]
        [StringLength(50)]
        public string EmployeeCode { get; set; }
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
        public int? Qualification { get; set; }
        [StringLength(50)]
        public string Major { get; set; }
        public int? MaritalStatus { get; set; }
        [StringLength(50)]
        public string Dependents { get; set; }
        [StringLength(50)]
        public string PassportNo { get; set; }
        [StringLength(50)]
        public string PassportExpires { get; set; }
        [StringLength(50)]
        public string NationalNo { get; set; }
        [StringLength(50)]
        public string NationalExpires { get; set; }
        [StringLength(50)]
        public string ResidenceNo { get; set; }
        [StringLength(50)]
        public string ResidenceExpires { get; set; }
        [StringLength(50)]
        public string DrivingLicNo { get; set; }
        [StringLength(50)]
        public string DrivingLicExpires { get; set; }
        [StringLength(50)]
        public string MedicalInsurance { get; set; }
        [StringLength(50)]
        public string MedicalInsExpires { get; set; }
        [StringLength(50)]
        public string SocialInsurance { get; set; }
        [StringLength(50)]
        public string BankName { get; set; }
        [StringLength(50)]
        public string BankAccountNo { get; set; }
        [StringLength(100)]
        public string AddressA { get; set; }
        [StringLength(100)]
        public string AddressE { get; set; }
        [StringLength(50)]
        public string Phone { get; set; }
        [StringLength(50)]
        public string Mobile { get; set; }
        [StringLength(50)]
        public string Email { get; set; }
        [StringLength(100)]
        public string SponsorNameID { get; set; }
        [StringLength(50)]
        public string SponsorPhone { get; set; }
        [StringLength(100)]
        public string SponsorAddress { get; set; }
        [StringLength(50)]
        public string BranchID { get; set; }
        public int? DepartmentID { get; set; }
        [StringLength(50)]
        public string Manager { get; set; }
        [StringLength(50)]
        public string HireDate { get; set; }
        public int? CategoryID { get; set; }
        [StringLength(50)]
        public string JobID { get; set; }
        [Column(TypeName = "ntext")]
        public string PermissionString { get; set; }
        public int? Status { get; set; }
        [StringLength(50)]
        public string AccID { get; set; }
        [Column(TypeName = "image")]
        public byte[] EmpImage { get; set; }
        [StringLength(50)]
        public string AccIDDe { get; set; }
        [StringLength(50)]
        public string AccIDE { get; set; }
        [StringLength(50)]
        public string AccIDO { get; set; }
        [StringLength(50)]
        public string GenderA { get; set; }
        [StringLength(50)]
        public string GenderE { get; set; }
        [StringLength(100)]
        public string QualificationNameA { get; set; }
        [StringLength(100)]
        public string QualificationNameE { get; set; }
        [StringLength(30)]
        public string CConNameArb { get; set; }
        [StringLength(30)]
        public string CConNameEng { get; set; }
        [StringLength(50)]
        public string StTypeNameE { get; set; }
        [StringLength(50)]
        public string StTypeNameA { get; set; }
        [StringLength(100)]
        public string ReligionNameA { get; set; }
        [StringLength(100)]
        public string ReligionNameE { get; set; }
        [StringLength(100)]
        public string MaritalStatusNameA { get; set; }
        [StringLength(100)]
        public string MaritalStatusNameE { get; set; }
        [StringLength(100)]
        public string JobNameA { get; set; }
        [StringLength(100)]
        public string JobNameE { get; set; }
        [StringLength(100)]
        public string JobDescription { get; set; }
        [StringLength(50)]
        public string BloodTypeName { get; set; }
        public int? BloodType { get; set; }
        [StringLength(100)]
        public string DepartmentNameA { get; set; }
        [StringLength(100)]
        public string DepartmentNameE { get; set; }
        public int Active { get; set; }
        public int? ProfessionsID { get; set; }
        public int? BWCode { get; set; }
        [StringLength(100)]
        public string BWBrWaName { get; set; }
        [StringLength(50)]
        public string NameProfessionsA { get; set; }
        [StringLength(50)]
        public string NameProfessionsE { get; set; }
        [StringLength(100)]
        public string SName { get; set; }
        [StringLength(50)]
        public string SPhone { get; set; }
        [StringLength(50)]
        public string SFax { get; set; }
        [StringLength(250)]
        public string SAddress { get; set; }
        public int? Nationality { get; set; }
        public int? SType { get; set; }
        [StringLength(50)]
        public string BankNameA { get; set; }
        public bool? ChType { get; set; }
        [StringLength(50)]
        public string AccIDL { get; set; }
    }
}