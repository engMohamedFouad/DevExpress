﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DevExpressDemo.Models
{
    [Table("CustomersBranch")]
    public partial class CustomersBranch
    {
        [Key]
        public int ID { get; set; }
        public int CustomerID { get; set; }
        public int? BranchID { get; set; }
        [StringLength(100)]
        public string PCName { get; set; }
        [StringLength(100)]
        public string PCPerson { get; set; }
        [StringLength(50)]
        public string Phone { get; set; }
        [StringLength(50)]
        public string Fax { get; set; }
        [StringLength(50)]
        public string Mobile { get; set; }
        [StringLength(200)]
        public string PCAddress { get; set; }
        public int? CityID { get; set; }
        [StringLength(50)]
        public string PBox { get; set; }
        [StringLength(50)]
        public string Zip { get; set; }
        [StringLength(50)]
        public string EMail { get; set; }
        [StringLength(50)]
        public string AccID { get; set; }
        public int? CountryID { get; set; }
        public int? SalemanID { get; set; }
        [StringLength(100)]
        public string PCNameEng { get; set; }
        [StringLength(50)]
        public string TaxNo { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? LastModified { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? Created { get; set; }
        [StringLength(50)]
        public string CreatedBy { get; set; }
        [StringLength(50)]
        public string LastModifiedBy { get; set; }

        [ForeignKey("AccID")]
        [InverseProperty("CustomersBranches")]
        public virtual TreeAccount Acc { get; set; }
    }
}