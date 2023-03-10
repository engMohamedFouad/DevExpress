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
    public partial class View_ContractPromotion
    {
        public int ContractID { get; set; }
        [StringLength(100)]
        public string EmployeeNameA { get; set; }
        [Required]
        [StringLength(50)]
        public string EmployeeCode { get; set; }
        [StringLength(50)]
        public string ContractStart { get; set; }
        [StringLength(50)]
        public string ContractEnd { get; set; }
        public int? ContractType { get; set; }
        [StringLength(30)]
        public string CConNameArb { get; set; }
        [StringLength(30)]
        public string CConNameEng { get; set; }
        public int? CountryID { get; set; }
        [StringLength(50)]
        public string HireDate { get; set; }
        [StringLength(100)]
        public string EmployeeNameE { get; set; }
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
        public string BloodTypeName { get; set; }
        [StringLength(50)]
        public string BloodTypeID { get; set; }
        [StringLength(100)]
        public string BWBrWaName { get; set; }
        [StringLength(50)]
        public string ResidenceNo { get; set; }
        [StringLength(50)]
        public string NationalNo { get; set; }
        [StringLength(50)]
        public string DrivingLicNo { get; set; }
        [StringLength(50)]
        public string PassportNo { get; set; }
        [StringLength(50)]
        public string DOBHI { get; set; }
        [StringLength(50)]
        public string DOBGR { get; set; }
        public int OrderNo { get; set; }
        [StringLength(50)]
        public string OrderDate { get; set; }
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
        [StringLength(100)]
        public string ContractTypeNameA { get; set; }
        [StringLength(100)]
        public string DepartmentNameA { get; set; }
        [StringLength(100)]
        public string DepartmentNameE { get; set; }
        [StringLength(100)]
        public string JobNameA { get; set; }
        [StringLength(100)]
        public string JobNameE { get; set; }
        public double? BasicSalaryO { get; set; }
        public double? TransAllowO { get; set; }
        public double? HousingAllowO { get; set; }
        public double? HealthInsuranceO { get; set; }
        public double? OtherAllowO { get; set; }
        public double? TicketAmountO { get; set; }
        public int? NoOfTicketO { get; set; }
        public int? NoOfVacationDayO { get; set; }
        public double? NetO { get; set; }
        public double? SocialnsuranceAmountO { get; set; }
        [StringLength(50)]
        public string CategoryNameE { get; set; }
        [StringLength(50)]
        public string CategoryNameA { get; set; }
    }
}