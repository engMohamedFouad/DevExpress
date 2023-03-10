// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DevExpressDemo.Models
{
    [Table("Job")]
    public partial class Job
    {
        public int ID { get; set; }
        [Key]
        public int JobID { get; set; }
        [StringLength(100)]
        public string JobNameA { get; set; }
        [StringLength(100)]
        public string JobNameE { get; set; }
        [StringLength(100)]
        public string JobDescription { get; set; }
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