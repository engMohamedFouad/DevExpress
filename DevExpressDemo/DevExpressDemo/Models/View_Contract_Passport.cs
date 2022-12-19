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
    public partial class View_Contract_Passport
    {
        public int ContractID { get; set; }
        [StringLength(50)]
        public string ContractStart { get; set; }
        [StringLength(50)]
        public string ContractEnd { get; set; }
        public double? BasicSalary { get; set; }
        [StringLength(100)]
        public string ContractStatusNameA { get; set; }
        [StringLength(100)]
        public string ContractTypeNameA { get; set; }
        public double? Net { get; set; }
        [Required]
        [StringLength(50)]
        public string EmployeeCode { get; set; }
        [StringLength(100)]
        public string EmployeeNameA { get; set; }
        public int? ContractType { get; set; }
        public int? ContractStatusID { get; set; }
        public int? WorkingDays { get; set; }
        public double? WorkingHours { get; set; }
        public int? NoOfVacationDay { get; set; }
        public int? NoOfTicket { get; set; }
        public int? PayType { get; set; }
        public double? HousingAllow { get; set; }
        public double? TransAllow { get; set; }
        public double? HealthInsurance { get; set; }
        public double? OtherAllow { get; set; }
        public double? TicketAmount { get; set; }
        [StringLength(100)]
        public string EmployeeNameE { get; set; }
        [StringLength(50)]
        public string HireDate { get; set; }
        public int? CountryID { get; set; }
        [StringLength(30)]
        public string CConNameArb { get; set; }
        [StringLength(30)]
        public string CConNameEng { get; set; }
        [StringLength(100)]
        public string DepartmentNameA { get; set; }
        [StringLength(100)]
        public string DepartmentNameE { get; set; }
        [StringLength(50)]
        public string Email { get; set; }
        [StringLength(50)]
        public string Mobile { get; set; }
        [StringLength(50)]
        public string Phone { get; set; }
        [StringLength(100)]
        public string AddressE { get; set; }
        [StringLength(100)]
        public string AddressA { get; set; }
        [StringLength(50)]
        public string BloodTypeID { get; set; }
        [StringLength(50)]
        public string BloodTypeName { get; set; }
        [StringLength(100)]
        public string JobNameA { get; set; }
        [StringLength(100)]
        public string JobNameE { get; set; }
        [StringLength(100)]
        public string BWBrWaName { get; set; }
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
        public string BankName { get; set; }
        [StringLength(50)]
        public string SocialInsurance { get; set; }
        [StringLength(50)]
        public string BankAccountNo { get; set; }
        [StringLength(50)]
        public string PassportExpires { get; set; }
        [StringLength(50)]
        public string Dependents { get; set; }
        public int? MaritalStatus { get; set; }
        public int? Nationality { get; set; }
        [StringLength(50)]
        public string Major { get; set; }
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
        public string SponsorName { get; set; }
        [StringLength(50)]
        public string SponsorPhone { get; set; }
        [StringLength(100)]
        public string SponsorAddress { get; set; }
        public int Active { get; set; }
        public double? SocialnsuranceAmount { get; set; }
        public int? CategoryID { get; set; }
        [StringLength(50)]
        public string CategoryNameA { get; set; }
        [StringLength(50)]
        public string CategoryNameE { get; set; }
        [StringLength(50)]
        public string PassportA { get; set; }
        [StringLength(50)]
        public string PassportE { get; set; }
        [StringLength(50)]
        public string PassportNo { get; set; }
        [StringLength(50)]
        public string IssuPassportDate { get; set; }
        [StringLength(50)]
        public string IssuCountry { get; set; }
        [StringLength(100)]
        public string Notes { get; set; }
        [StringLength(50)]
        public string StratNewDate { get; set; }
        [StringLength(50)]
        public string EndNewDate { get; set; }
        public int? Period { get; set; }
        [StringLength(50)]
        public string EndNewDateG { get; set; }
        [StringLength(50)]
        public string StratNewDateG { get; set; }
        public int? TypeID { get; set; }
        [StringLength(100)]
        public string MaritalStatusNameE { get; set; }
        [StringLength(100)]
        public string MaritalStatusNameA { get; set; }
        [StringLength(50)]
        public string GenderE { get; set; }
        [StringLength(50)]
        public string StTypeNameE { get; set; }
        [StringLength(50)]
        public string GenderA { get; set; }
        [StringLength(50)]
        public string StTypeNameA { get; set; }
    }
}