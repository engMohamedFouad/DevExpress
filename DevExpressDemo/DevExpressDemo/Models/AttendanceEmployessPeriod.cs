﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DevExpressDemo.Models
{
    [Table("AttendanceEmployessPeriod")]
    public partial class AttendanceEmployessPeriod
    {
        [Key]
        public int ID { get; set; }
        [StringLength(50)]
        public string FromTime { get; set; }
        [StringLength(50)]
        public string ToTime { get; set; }
        public double? Hourse { get; set; }
        public int? EmployeeCode { get; set; }
        public int? PeriodNo { get; set; }
        [StringLength(50)]
        public string DepartmentID { get; set; }
        [Column(TypeName = "ntext")]
        public string Notes { get; set; }
        [StringLength(20)]
        public string DateInsert { get; set; }
        [StringLength(20)]
        public string TimeInsert { get; set; }
        public int? TypePeriod { get; set; }
        public int? TypeAtten { get; set; }
        public double? AveLeat { get; set; }
        public int? MuLeat { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? LastModified { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? Created { get; set; }
        [StringLength(50)]
        public string CreatedBy { get; set; }
        [StringLength(50)]
        public string LastModifiedBy { get; set; }

        [ForeignKey("EmployeeCode")]
        [InverseProperty("AttendanceEmployessPeriods")]
        public virtual EmployeesDetail EmployeeCodeNavigation { get; set; }
    }
}