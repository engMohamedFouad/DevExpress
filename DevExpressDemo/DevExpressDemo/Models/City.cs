﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DevExpressDemo.Models
{
    public partial class City
    {
        public City()
        {
            CompanyInformations = new HashSet<CompanyInformation>();
            ProviderCustomers = new HashSet<ProviderCustomer>();
        }

        public int ID { get; set; }
        [Key]
        public int CityID { get; set; }
        public int? CountryID { get; set; }
        [StringLength(50)]
        public string CityNameArb { get; set; }
        [StringLength(50)]
        public string CityNameEng { get; set; }
        [StringLength(10)]
        public string CityKey { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? LastModified { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? Created { get; set; }
        [StringLength(50)]
        public string CreatedBy { get; set; }
        [StringLength(50)]
        public string LastModifiedBy { get; set; }

        [ForeignKey("CountryID")]
        [InverseProperty("Cities")]
        public virtual Country Country { get; set; }
        [InverseProperty("City")]
        public virtual ICollection<CompanyInformation> CompanyInformations { get; set; }
        [InverseProperty("City")]
        public virtual ICollection<ProviderCustomer> ProviderCustomers { get; set; }
    }
}