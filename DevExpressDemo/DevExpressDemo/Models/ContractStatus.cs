﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DevExpressDemo.Models
{
    [Table("ContractStatus")]
    public partial class ContractStatus
    {
        public ContractStatus()
        {
            Contracts = new HashSet<Contract>();
        }

        public int ID { get; set; }
        [Key]
        public int ContractStatusID { get; set; }
        [StringLength(100)]
        public string ContractStatusNameA { get; set; }
        [StringLength(100)]
        public string ContractStatusNameE { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? LastModified { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? Created { get; set; }
        [StringLength(50)]
        public string CreatedBy { get; set; }
        [StringLength(50)]
        public string LastModifiedBy { get; set; }

        [InverseProperty("ContractStatus")]
        public virtual ICollection<Contract> Contracts { get; set; }
    }
}