// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DevExpressDemo.Models
{
    [Keyless]
    public partial class MovementCash
    {
        public int AmountCash { get; set; }
        public int AmountChecks { get; set; }
        public int AmountOthers { get; set; }
        [Required]
        [StringLength(1)]
        [Unicode(false)]
        public string Details { get; set; }
        [Required]
        [StringLength(1)]
        [Unicode(false)]
        public string TypeDe { get; set; }
    }
}