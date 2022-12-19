﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DevExpressDemo.Models
{
    [Table("RecordsCompany")]
    public partial class RecordsCompany
    {
        [Key]
        public int ID { get; set; }
        [Required]
        [StringLength(50)]
        public string RecordNo { get; set; }
        [StringLength(50)]
        public string TypeRecord { get; set; }
        [StringLength(50)]
        public string PlaceRecord { get; set; }
        [StringLength(100)]
        public string Notes { get; set; }
        [StringLength(50)]
        public string StratNewDate { get; set; }
        [StringLength(50)]
        public string EndNewDate { get; set; }
        [StringLength(50)]
        public string StratNewDateG { get; set; }
        [StringLength(50)]
        public string EndNewDateG { get; set; }
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