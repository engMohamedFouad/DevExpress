// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DevExpressDemo.Models
{
    public partial class UserModulePermission
    {
        public int Id { get; set; }
        [Key]
        [StringLength(10)]
        public string PermissionID { get; set; }
        [Key]
        [StringLength(10)]
        public string SubModuleID { get; set; }
        [Key]
        public int RoleID { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? Created { get; set; }
        [StringLength(50)]
        public string CreatedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? LastModified { get; set; }
        [StringLength(50)]
        public string LastModifiedBy { get; set; }

        [ForeignKey("RoleID")]
        [InverseProperty("UserModulePermissions")]
        public virtual AspNetRole Role { get; set; }
    }
}