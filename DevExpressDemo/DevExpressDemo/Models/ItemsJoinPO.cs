﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DevExpressDemo.Models
{
    [Table("ItemsJoinPOS")]
    public partial class ItemsJoinPO
    {
        [Key]
        public int ID { get; set; }
        [StringLength(50)]
        public string ItemID { get; set; }
        public int? UnitID { get; set; }
        public double? Quantity { get; set; }
        public double? Price { get; set; }
        [Column(TypeName = "ntext")]
        public string Notes { get; set; }
        [StringLength(50)]
        public string JoinItem { get; set; }
        public int? WarehouseID { get; set; }
        public double? QuantityFull { get; set; }
        public int? BranchID { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? LastModified { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? Created { get; set; }
        [StringLength(50)]
        public string CreatedBy { get; set; }
        [StringLength(50)]
        public string LastModifiedBy { get; set; }

        [ForeignKey("ItemID")]
        [InverseProperty("ItemsJoinPOs")]
        public virtual Item Item { get; set; }
        [ForeignKey("UnitID")]
        [InverseProperty("ItemsJoinPOs")]
        public virtual MainDatum Unit { get; set; }
    }
}