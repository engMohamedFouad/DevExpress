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
    public partial class QuantityStocks1
    {
        public double? QtyIn { get; set; }
        public double? QtyAv { get; set; }
        public int BranchID { get; set; }
        [Required]
        [StringLength(50)]
        public string ItemID { get; set; }
        public int WareHouseID { get; set; }
    }
}