﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DevExpressDemo.Models
{
    [Keyless]
    public partial class ViewUsersBranch
    {
        public int UserID { get; set; }
        public int BranchID { get; set; }
        [StringLength(100)]
        public string UserName { get; set; }
        public bool? NoActive { get; set; }
        public int? TypeUser { get; set; }
        public int? SalesmanID { get; set; }
    }
}