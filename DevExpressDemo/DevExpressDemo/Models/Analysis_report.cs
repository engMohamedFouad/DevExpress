﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DevExpressDemo.Models
{
    public partial class Analysis_report
    {
        public int ID { get; set; }
        [Key]
        [StringLength(50)]
        public string n_rep_no { get; set; }
        [Required]
        [StringLength(50)]
        public string s_rep_title { get; set; }
        [StringLength(50)]
        public string s_rep_title_eng { get; set; }
        [StringLength(50)]
        public string s_rep_name { get; set; }
        [StringLength(50)]
        public string s_table_name { get; set; }
        public int? n_module_id { get; set; }
    }
}