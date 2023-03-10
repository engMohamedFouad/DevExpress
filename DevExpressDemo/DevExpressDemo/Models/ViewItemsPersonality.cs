// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DevExpressDemo.Models
{
    [Keyless]
    public partial class ViewItemsPersonality
    {
        public string ItemID { get; set; }
        [StringLength(101)]
        public string PersonalityID { get; set; }
        [StringLength(203)]
        public string PersonalityName { get; set; }
        public string ItemPersonalityID { get; set; }
        [StringLength(305)]
        public string ItemPersonalityName { get; set; }
        public int? BranchID { get; set; }
        public int? TypeStock { get; set; }
        public string Barcode { get; set; }
    }
}