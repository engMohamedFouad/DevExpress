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
    public partial class ViewQuantityJoin
    {
        public int BranchID { get; set; }
        [StringLength(50)]
        public string JoinItem { get; set; }
        public double QtyAv { get; set; }
    }
}