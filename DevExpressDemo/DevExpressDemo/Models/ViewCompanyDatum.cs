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
    public partial class ViewCompanyDatum
    {
        public int CompanyCode { get; set; }
        public int? CountryID { get; set; }
        public int? CityID { get; set; }
        [StringLength(50)]
        public string Phone { get; set; }
        [StringLength(50)]
        public string Fax { get; set; }
        [StringLength(50)]
        public string Emails { get; set; }
        [StringLength(50)]
        public string PBox { get; set; }
        [Column(TypeName = "image")]
        public byte[] CIImage { get; set; }
        [StringLength(50)]
        public string CityNameArb { get; set; }
        [StringLength(50)]
        public string CityNameEng { get; set; }
        [StringLength(100)]
        public string CINameEng { get; set; }
        [StringLength(100)]
        public string CIAddressEng { get; set; }
        [StringLength(30)]
        public string CConNameEng { get; set; }
        [StringLength(30)]
        public string CConNameArb { get; set; }
        [StringLength(100)]
        public string CIAddressArb { get; set; }
        [StringLength(100)]
        public string CINameArb { get; set; }
        [StringLength(50)]
        public string CIVATNo { get; set; }
        [StringLength(50)]
        public string CITradReg { get; set; }
        [StringLength(50)]
        public string CIAccBank { get; set; }
        [StringLength(50)]
        public string AddtionalNo { get; set; }
        [StringLength(50)]
        public string ZipNo { get; set; }
    }
}