﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DevExpressDemo.Models
{
    public partial class Ticket
    {
        public int ID { get; set; }
        [Key]
        public int TicOrderNo { get; set; }
        public int? EmployeeCode { get; set; }
        [StringLength(50)]
        public string TicOrderDate { get; set; }
        [StringLength(100)]
        public string LAddress { get; set; }
        public int? TicNo { get; set; }
        [StringLength(100)]
        public string Note { get; set; }
        public double? TicAmount { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? LastModified { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? Created { get; set; }
        [StringLength(50)]
        public string CreatedBy { get; set; }
        [StringLength(50)]
        public string LastModifiedBy { get; set; }

        [ForeignKey("EmployeeCode")]
        [InverseProperty("Tickets")]
        public virtual EmployeesDetail EmployeeCodeNavigation { get; set; }
    }
}