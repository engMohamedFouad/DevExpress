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
    public partial class InventoryOfChecks1
    {
        public int AmountCh { get; set; }
        [Required]
        [StringLength(1)]
        [Unicode(false)]
        public string CheckNo { get; set; }
        [Required]
        [StringLength(1)]
        [Unicode(false)]
        public string DateCheck { get; set; }
        [Required]
        [StringLength(1)]
        [Unicode(false)]
        public string BankName { get; set; }
    }
}