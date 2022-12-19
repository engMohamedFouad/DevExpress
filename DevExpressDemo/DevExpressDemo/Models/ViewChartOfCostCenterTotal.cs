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
    public partial class ViewChartOfCostCenterTotal
    {
        public int CostID { get; set; }
        [StringLength(100)]
        public string MName { get; set; }
        [Column(TypeName = "money")]
        public decimal? OpenB { get; set; }
        public int Debit { get; set; }
        public int Credit { get; set; }
        [Column(TypeName = "money")]
        public decimal? Bal { get; set; }
        [StringLength(30)]
        public string DateGrD { get; set; }
        public int BranchID { get; set; }
        public int? FinancialID { get; set; }
        public int CostCenterID { get; set; }
    }
}