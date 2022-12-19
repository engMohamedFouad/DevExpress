﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DevExpressDemo.Models
{
    public partial class MainDatum
    {
        public MainDatum()
        {
            AllInvoiceJions = new HashSet<AllInvoiceJion>();
            AllInvoices = new HashSet<AllInvoice>();
            AllInvoicesDetails = new HashSet<AllInvoicesDetail>();
            CostCenterBalances = new HashSet<CostCenterBalance>();
            FxiedAssets = new HashSet<FxiedAsset>();
            ItemBookingUnitNavigations = new HashSet<Item>();
            ItemItemTypeNavigations = new HashSet<Item>();
            ItemMDCodeGroupNavigations = new HashSet<Item>();
            ItemMDCodeSubGroupNavigations = new HashSet<Item>();
            ItemMDCodeUnitNavigations = new HashSet<Item>();
            ItemMDPurUnitNavigations = new HashSet<Item>();
            ItemMDSalUnitNavigations = new HashSet<Item>();
            ItemOrderUnitNavigations = new HashSet<Item>();
            ItemQuatationUnitNavigations = new HashSet<Item>();
            ItemsAlternatives = new HashSet<ItemsAlternative>();
            ItemsJoinPOs = new HashSet<ItemsJoinPO>();
            ItemsJoins = new HashSet<ItemsJoin>();
            ItemsProductions = new HashSet<ItemsProduction>();
            PagesNos = new HashSet<PagesNo>();
            ProviderCustomers = new HashSet<ProviderCustomer>();
            UnitsItems = new HashSet<UnitsItem>();
        }

        public int MDID { get; set; }
        [Key]
        public int MDCode { get; set; }
        public int MDCodeID { get; set; }
        public int? MBranchID { get; set; }
        [StringLength(100)]
        public string MName { get; set; }
        [StringLength(50)]
        public string MNotes { get; set; }
        public int? MFrmValue { get; set; }
        [StringLength(50)]
        public string MAccID { get; set; }
        [StringLength(100)]
        public string PrintName { get; set; }
        public int? PerNo { get; set; }
        [StringLength(100)]
        public string MNameEng { get; set; }
        public bool? InvAppear { get; set; }
        public double? NotePrice { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? LastModified { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? Created { get; set; }
        [StringLength(50)]
        public string CreatedBy { get; set; }
        [StringLength(50)]
        public string LastModifiedBy { get; set; }

        [ForeignKey("MAccID")]
        [InverseProperty("MainData")]
        public virtual TreeAccount MAcc { get; set; }
        [InverseProperty("Note")]
        public virtual ICollection<AllInvoiceJion> AllInvoiceJions { get; set; }
        [InverseProperty("Cashier")]
        public virtual ICollection<AllInvoice> AllInvoices { get; set; }
        [InverseProperty("Unit")]
        public virtual ICollection<AllInvoicesDetail> AllInvoicesDetails { get; set; }
        [InverseProperty("Cost")]
        public virtual ICollection<CostCenterBalance> CostCenterBalances { get; set; }
        [InverseProperty("GroupNoNavigation")]
        public virtual ICollection<FxiedAsset> FxiedAssets { get; set; }
        [InverseProperty("BookingUnitNavigation")]
        public virtual ICollection<Item> ItemBookingUnitNavigations { get; set; }
        [InverseProperty("ItemTypeNavigation")]
        public virtual ICollection<Item> ItemItemTypeNavigations { get; set; }
        [InverseProperty("MDCodeGroupNavigation")]
        public virtual ICollection<Item> ItemMDCodeGroupNavigations { get; set; }
        [InverseProperty("MDCodeSubGroupNavigation")]
        public virtual ICollection<Item> ItemMDCodeSubGroupNavigations { get; set; }
        [InverseProperty("MDCodeUnitNavigation")]
        public virtual ICollection<Item> ItemMDCodeUnitNavigations { get; set; }
        [InverseProperty("MDPurUnitNavigation")]
        public virtual ICollection<Item> ItemMDPurUnitNavigations { get; set; }
        [InverseProperty("MDSalUnitNavigation")]
        public virtual ICollection<Item> ItemMDSalUnitNavigations { get; set; }
        [InverseProperty("OrderUnitNavigation")]
        public virtual ICollection<Item> ItemOrderUnitNavigations { get; set; }
        [InverseProperty("QuatationUnitNavigation")]
        public virtual ICollection<Item> ItemQuatationUnitNavigations { get; set; }
        [InverseProperty("Group")]
        public virtual ICollection<ItemsAlternative> ItemsAlternatives { get; set; }
        [InverseProperty("Unit")]
        public virtual ICollection<ItemsJoinPO> ItemsJoinPOs { get; set; }
        [InverseProperty("Unit")]
        public virtual ICollection<ItemsJoin> ItemsJoins { get; set; }
        [InverseProperty("Unit")]
        public virtual ICollection<ItemsProduction> ItemsProductions { get; set; }
        [InverseProperty("MDCodeNavigation")]
        public virtual ICollection<PagesNo> PagesNos { get; set; }
        [InverseProperty("GroupNoNavigation")]
        public virtual ICollection<ProviderCustomer> ProviderCustomers { get; set; }
        [InverseProperty("Unit")]
        public virtual ICollection<UnitsItem> UnitsItems { get; set; }
    }
}