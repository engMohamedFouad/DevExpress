using AutoMapper;
using DevExpressDemo.ModelsDTO;

namespace DevExpressDemo.Helper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            // Add as many of these lines as you need to map your objects
            CreateMap<CompanyInformation, ItemsUnitCompanyInformationDTO>();
            CreateMap<CompanyInformation, JournalResponseAndCompanyInfoDTO>();
        }
    }
}
