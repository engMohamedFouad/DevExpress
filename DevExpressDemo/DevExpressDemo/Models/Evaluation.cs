// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DevExpressDemo.Models
{
    [Table("Evaluation")]
    public partial class Evaluation
    {
        public int ID { get; set; }
        [Key]
        public int EvaluationID { get; set; }
        [StringLength(30)]
        public string EvNameArb { get; set; }
        [StringLength(30)]
        public string EvNameEng { get; set; }
        public int? EvDegree { get; set; }
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