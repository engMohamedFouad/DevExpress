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
    public partial class InventoryOfCash1
    {
        public int AmountCa { get; set; }
        [Required]
        [StringLength(1)]
        [Unicode(false)]
        public string Number { get; set; }
        [Required]
        [StringLength(1)]
        [Unicode(false)]
        public string GroupAmount { get; set; }
        [Required]
        [StringLength(1)]
        [Unicode(false)]
        public string Detailsc { get; set; }
    }
}