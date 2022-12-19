namespace DevExpressDemo.ModelsDTO
{
    public class PurchaseInvoice
    {
        public int InvoiceID { get; set; }
        public int InvoiceCode { get; set; }
        public DateTime DateGr { get; set; }
        public int QutationID { get; set; }
        public string? CustomerName { get; set; }
        public int PayType { get; set; }
        public decimal AllwedDiscount { get; set; }
        public decimal Netinv { get; set; }
        public int CostCenterId { get; set; }
        public string? Note { get; set; }
        public int CashierId { get; set; }
        public string? ProvInvNo { get; set; }
        public string? ProvInvDate { get; set; }
        public decimal? RoundNo { get; set; }
        public decimal? TaxAmount { get; set; }
        public decimal? TotalInvo { get; set; }
        public decimal DiscountInvo { get; set; }
        public string? CheckNo { get; set; }
        public int? ProviderId { get; set; }
        public List<PurchasesInvoiceDetailsDTO> allInvoicesDetails { get; set; }
    }
    public class PurchasesInvoiceDetailsDTO
    {
        public int ID { get; set; }
        public string? ItemID { get; set; }
        public int UnitID { get; set; }
        public int WarehouseID { get; set; }
        public string? ItemNote { get; set; }
        public double Quantity { get; set; }
        public double QuantityBouns { get; set; }
        public decimal Price { get; set; }
        public decimal DiscountDetails { get; set; }
        public decimal TaxPerItem { get; set; }
        public decimal NetDetails { get; set; }
        public string Batch { get; set; }
        public string? NotesItem { get; set; }
        public string? SerialNumber { get; set; }
        public string? Personality { get; set; }
        public DateTime ExpireDate { get; set; }
        public decimal? CostPrice { get; set; }
        public decimal? TaxDetails { get; set; }
        public decimal? OtherDiscounts { get; set; }
        public decimal? TotalDetails { get; set; }
    }
}
