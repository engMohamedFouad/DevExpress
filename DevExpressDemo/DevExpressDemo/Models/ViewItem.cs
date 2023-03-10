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
    public partial class ViewItem
    {
        [StringLength(100)]
        public string ItemName { get; set; }
        [Required]
        [StringLength(50)]
        public string ItemID { get; set; }
        public int? BranchID { get; set; }
        public double? QuantityIn { get; set; }
        public int? WareHouseID { get; set; }
        public double? QuantityAv { get; set; }
        public int? BWCode { get; set; }
        [StringLength(100)]
        public string WarehouseName { get; set; }
        public int? MDCodeGroup1 { get; set; }
        public int? MDCodeGroup { get; set; }
        public int? MDCodeUnit { get; set; }
        public int? MDCodeGroup2 { get; set; }
        public int? MDCodeGroup3 { get; set; }
        public int? MDCodeGroup4 { get; set; }
        [StringLength(50)]
        public string FactoryNo { get; set; }
        [Column(TypeName = "ntext")]
        public string OtherData { get; set; }
        [Column(TypeName = "ntext")]
        public string Barcode { get; set; }
        [Column(TypeName = "image")]
        public byte[] Images { get; set; }
        public int? BarcodeValue { get; set; }
        [Column(TypeName = "ntext")]
        public string Location { get; set; }
        public double? RequestQuantity { get; set; }
        public double? RequestPoint { get; set; }
        public int? ProfitSales { get; set; }
        public bool? ShowItemNoBar { get; set; }
        public bool? ShowItemNameBar { get; set; }
        public int? StatsItems { get; set; }
        public int? TypeItems { get; set; }
        [StringLength(100)]
        public string Groups { get; set; }
        [StringLength(100)]
        public string Units { get; set; }
        public double? Qty { get; set; }
        [StringLength(50)]
        public string UnitBarcode { get; set; }
        [Column(TypeName = "money")]
        public decimal? WholePrice { get; set; }
        [Column(TypeName = "money")]
        public decimal? PriceCost { get; set; }
        [Column(TypeName = "money")]
        public decimal? PriceAverage { get; set; }
        [Column(TypeName = "money")]
        public decimal? MinPrice { get; set; }
        [Column(TypeName = "money")]
        public decimal? PriceSales { get; set; }
        [StringLength(10)]
        public string ExpireDate { get; set; }
        [Column(TypeName = "ntext")]
        public string Note { get; set; }
        [StringLength(100)]
        public string CompName { get; set; }
        [Column(TypeName = "money")]
        public decimal? UnitPriceCostOpen { get; set; }
        [Column(TypeName = "money")]
        public decimal? UnitPriceMarket { get; set; }
        [Column(TypeName = "money")]
        public decimal? UnitPriceSalesman { get; set; }
        public int? StatsTax { get; set; }
        public double? TaxValue { get; set; }
        [Column(TypeName = "money")]
        public decimal? UnitPriceAfterTax { get; set; }
        public int? MDCodeSubGroup { get; set; }
    }
}