﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DevExpressDemo.Models
{
    [Table("UserDataPermission")]
    public partial class UserDataPermission
    {
        public int ID { get; set; }
        [Key]
        public int UserID { get; set; }
        [Key]
        public int BranchID { get; set; }
        public int? SalesmanID { get; set; }
        [Column(TypeName = "ntext")]
        public string PermssisonStringAcc { get; set; }

        [ForeignKey("UserID")]
        [InverseProperty("UserDataPermissions")]
        public virtual UsersDatum User { get; set; }
    }
}