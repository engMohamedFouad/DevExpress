namespace DevExpressDemo.ModelsDTO
{
    public class CompanyInformation
    {
        public int CompanyInformationId { get; set; }
        public string? CompanyInformationNameArb { get; set; }
        public string? CompanyInformationNameEng { get; set; }
        public string? CompanyInformationAddressArb { get; set; }
        public string? CompanyInformationAddressEng { get; set; }
        public string? CompanyInformationEmail { get; set; }
        public int? CompanyInformationCountryId { get; set; }
        public string? CompanyInformationCountryName { get; set; }
        public int? CompanyInformationCityId { get; set; }
        public string? CompanyInformationCityName { get; set; }

        public string? CompanyInformationAccountBank { get; set; }
        public string? CompanyInformationPbox { get; set; }
        public string? CompanyInformationPhone { get; set; }
        public string? CompanyInformationZipNo { get; set; }
        public string? CompanyInformationAddtionalNumber { get; set; }
        public string? CompanyInformationFax { get; set; }
        public string? CompanyInformationVatNumber { get; set; }

        public string? CompanyInformationImage { get; set; }
    }
}
