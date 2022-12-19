using DevExpressDemo.ModelsDTO;

namespace DevExpressDemo.Services.Interface
{
    public interface ICompanyInformationService
    {
        public Task<CompanyInformation> GetCompanyInformation(string token);
    }
}
