// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DevExpressDemo.Models
{
    [Table("UsersLogin")]
    public partial class UsersLogin
    {
        [Key]
        public int ID { get; set; }
        public int? UserID { get; set; }
        public int? BranchID { get; set; }
        [StringLength(50)]
        public string ServerName { get; set; }
        public int? StatsUser { get; set; }
        [StringLength(50)]
        public string DateLogin { get; set; }
        [StringLength(50)]
        public string TimeLogin { get; set; }
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