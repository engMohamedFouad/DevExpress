namespace DevExpressDemo.ModelsDTO
{
    public class JournalResponseAndCompanyInfoDTO : CompanyInformation
    {
        public int? MoveId { get; set; }
        public int? MoveCode { get; set; }
        public string? Date { get; set; }
        public string? AccName { get; set; }
        public bool? IsDone { get; set; }
        public string? IsDoneValue { get; set; }
        public string? MoveType { get; set; }
        public decimal? Total { get; set; }
        public int? UserID { get; set; }
    }
}
