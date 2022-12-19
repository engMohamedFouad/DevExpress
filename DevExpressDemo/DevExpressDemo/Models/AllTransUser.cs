﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DevExpressDemo.Models
{
    [Table("AllTransUser")]
    public partial class AllTransUser
    {
        [Key]
        public int ID { get; set; }
        [StringLength(50)]
        public string DateCreate { get; set; }
        [StringLength(50)]
        public string TimeCreate { get; set; }
        public int? UserID { get; set; }
        [Column(TypeName = "ntext")]
        public string DisForm { get; set; }
        public int? TypeForm { get; set; }
        /// <summary>
        /// 0 \ insert , 1 \ Edit ,2 \ Delete
        /// </summary>
        public int? NameButton { get; set; }
        public int? BranchID { get; set; }
        public bool? Status { get; set; }
        [StringLength(50)]
        public string No { get; set; }
        [StringLength(50)]
        public string AllBranch { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? LastModified { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? Created { get; set; }
        [StringLength(50)]
        public string CreatedBy { get; set; }
        [StringLength(50)]
        public string LastModifiedBy { get; set; }
    }
}