﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DevExpressDemo.Models
{
    [Index("RoleId", Name = "IX_AspNetUserRoles_RoleId")]
    public partial class AspNetUserRole
    {
        [Key]
        public int UserId { get; set; }
        public int RoleId { get; set; }
        [Key]
        public int BranchID { get; set; }

        [ForeignKey("BranchID")]
        [InverseProperty("AspNetUserRoles")]
        public virtual BranchsAndWarehouse Branch { get; set; }
        [ForeignKey("RoleId")]
        [InverseProperty("AspNetUserRoles")]
        public virtual AspNetRole Role { get; set; }
        [ForeignKey("UserId")]
        [InverseProperty("AspNetUserRoles")]
        public virtual AspNetUser User { get; set; }
    }
}