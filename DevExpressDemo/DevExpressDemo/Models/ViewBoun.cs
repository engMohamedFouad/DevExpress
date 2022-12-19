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
    public partial class ViewBoun
    {
        [StringLength(100)]
        public string BonusTypeNameA { get; set; }
        [StringLength(100)]
        public string BonusTypeNameE { get; set; }
        [Required]
        [StringLength(50)]
        public string BonusOrderNo { get; set; }
        [StringLength(50)]
        public string EmployeeCode { get; set; }
        [StringLength(50)]
        public string BonusOrderDate { get; set; }
        [Column(TypeName = "money")]
        public decimal? BonusAmount { get; set; }
        [StringLength(100)]
        public string Note { get; set; }
        public int BonusTypeID { get; set; }
        public int ID { get; set; }
        public bool? Done { get; set; }
        public bool? ChekAdd { get; set; }
        [StringLength(50)]
        public string BranchID { get; set; }
        [StringLength(50)]
        public string AccFundID { get; set; }
        [StringLength(100)]
        public string EmployeeNameA { get; set; }
        [StringLength(100)]
        public string EmployeeNameE { get; set; }
        [StringLength(50)]
        public string AccIDDe { get; set; }
        [StringLength(50)]
        public string AccIDE { get; set; }
        [StringLength(50)]
        public string AccIDO { get; set; }
        [StringLength(50)]
        public string AccID { get; set; }
    }
}