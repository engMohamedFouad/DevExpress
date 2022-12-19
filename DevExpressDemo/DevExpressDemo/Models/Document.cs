﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DevExpressDemo.Models
{
    public partial class Document
    {
        [Key]
        public int ID { get; set; }
        public int? EmployeeCode { get; set; }
        [StringLength(100)]
        public string DocumentPath { get; set; }
        [StringLength(50)]
        public string DocumentName { get; set; }
        [Column(TypeName = "ntext")]
        public string Remarks { get; set; }
        [StringLength(50)]
        public string DocumentDate { get; set; }
        public byte[] DocumentImages { get; set; }
        [StringLength(100)]
        public string DocumenLoaction { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? LastModified { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? Created { get; set; }
        [StringLength(50)]
        public string CreatedBy { get; set; }
        [StringLength(50)]
        public string LastModifiedBy { get; set; }

        [ForeignKey("EmployeeCode")]
        [InverseProperty("Documents")]
        public virtual EmployeesDetail EmployeeCodeNavigation { get; set; }
    }
}