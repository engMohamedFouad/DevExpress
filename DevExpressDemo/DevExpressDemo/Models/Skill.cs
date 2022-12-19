﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DevExpressDemo.Models
{
    public partial class Skill
    {
        [Key]
        public int SkillID { get; set; }
        public int? EmployeeCode { get; set; }
        [Column("Skill")]
        [StringLength(100)]
        public string Skill1 { get; set; }
        public int? SkillLevelID { get; set; }
        [StringLength(50)]
        public string YearsOfExperience { get; set; }
        [StringLength(50)]
        public string LastUsed { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? LastModified { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? Created { get; set; }
        [StringLength(50)]
        public string CreatedBy { get; set; }
        [StringLength(50)]
        public string LastModifiedBy { get; set; }

        [ForeignKey("EmployeeCode")]
        [InverseProperty("Skills")]
        public virtual EmployeesDetail EmployeeCodeNavigation { get; set; }
    }
}