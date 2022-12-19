﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DevExpressDemo.Models
{
    [Table("Module")]
    public partial class Module
    {
        public Module()
        {
            SubModules = new HashSet<SubModule>();
        }

        public int Id { get; set; }
        [Key]
        [StringLength(50)]
        public string ModuleID { get; set; }
        [StringLength(100)]
        public string NameAr { get; set; }
        [StringLength(100)]
        public string NameEn { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? LastModified { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? Created { get; set; }
        [StringLength(50)]
        public string CreatedBy { get; set; }
        [StringLength(50)]
        public string LastModifiedBy { get; set; }

        [InverseProperty("Module")]
        public virtual ICollection<SubModule> SubModules { get; set; }
    }
}