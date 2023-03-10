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
    public partial class ViewPrintCustomerProvider
    {
        public int PCID { get; set; }
        public int ProviderCustomerID { get; set; }
        public int ProviderCustomerCode { get; set; }
        public int? BranchID { get; set; }
        [StringLength(100)]
        public string PCName { get; set; }
        [StringLength(100)]
        public string PCPerson { get; set; }
        [StringLength(50)]
        public string Phone { get; set; }
        [StringLength(50)]
        public string Fax { get; set; }
        [StringLength(50)]
        public string Mobile { get; set; }
        [StringLength(200)]
        public string PCAddress { get; set; }
        public int? CityID { get; set; }
        [StringLength(50)]
        public string PBox { get; set; }
        [StringLength(50)]
        public string Zip { get; set; }
        [StringLength(50)]
        public string EMail { get; set; }
        [StringLength(50)]
        public string AccID { get; set; }
        public int? DiscountPriceType { get; set; }
        public double? DiscountPriceValue { get; set; }
        public int? FrmValueCust { get; set; }
        public int? CountryID { get; set; }
        public int? SalemanID { get; set; }
        public int? GroupNo { get; set; }
        [StringLength(100)]
        public string BWBrWaName { get; set; }
        [StringLength(50)]
        public string CityNameArb { get; set; }
        [StringLength(50)]
        public string CityNameEng { get; set; }
        [StringLength(30)]
        public string CConNameArb { get; set; }
        [StringLength(30)]
        public string CConNameEng { get; set; }
        [StringLength(100)]
        public string MName { get; set; }
        [StringLength(50)]
        public string MNotes { get; set; }
        [Column(TypeName = "ntext")]
        public string Notes1 { get; set; }
        public int? BarcodeNo { get; set; }
        [Column(TypeName = "ntext")]
        public string Notes2 { get; set; }
    }
}