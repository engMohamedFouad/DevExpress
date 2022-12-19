using AutoMapper;
using DevExpressDemo.Data;
using DevExpressDemo.Helper;
using DevExpressDemo.ModelsDTO;
using DevExpressDemo.Reports;
using DevExpressDemo.Services.Interface;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Net.Http.Headers;

namespace DevExpressDemo.Controllers
{
    public class SystemCardsController : Controller
    {
        private readonly IMapper _mapper;
        private readonly ICompanyInformationService _companyInformationService;
        FiniexApiHelper _finiexApi = new FiniexApiHelper();
        HttpClient client = new HttpClient();
        public SystemCardsController(ILogger<SystemCardsController> logger, FiniexWebDbContext context, IMapper mapper, ICompanyInformationService companyInformationService)
        {
            _mapper = mapper;
            _companyInformationService = companyInformationService;
            //عشان يبقي علي مستوي الكل
            client = _finiexApi.Initial();
        }
        public async Task<IActionResult> GetItemUnits(string? SearchString, string? OrderBy, int PageNumber = 1, int PageSize = 10)
        {
            //List Of DataSource Of ItemsunitandCompanyInformation
            List<ItemsUnitCompanyInformationDTO> itemUnitscompantInfo = new List<ItemsUnitCompanyInformationDTO>();
            //var token = HttpContext.Session.GetString("JWToken");
            var token = Request.Cookies["token"];
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
            HttpResponseMessage res = await client.GetAsync($"/api/v1/general/units/list?PageNumber={PageNumber}&PageSize={PageSize}&OrderBy={OrderBy}&SearchString={SearchString}");
            if (res.IsSuccessStatusCode)
            {
                var result = await res.Content.ReadAsStringAsync();
                var resultJObject = JObject.Parse(result);
                var listOfJson = resultJObject.Root["data"].ToList();
                //object company information
                var companyinformation = await _companyInformationService.GetCompanyInformation(token);
                foreach (var item in listOfJson)
                {
                    var itemfinal = JsonConvert.DeserializeObject<ItemsUnitCompanyInformationDTO>(item.ToString());
                    var unitAndCompanyInfo = _mapper.Map<ItemsUnitCompanyInformationDTO>(companyinformation);
                    unitAndCompanyInfo.id = itemfinal.id;
                    unitAndCompanyInfo.name = itemfinal.name;
                    unitAndCompanyInfo.code = itemfinal.code;
                    unitAndCompanyInfo.details = itemfinal.details;
                    itemUnitscompantInfo.Add(unitAndCompanyInfo);
                }
            }
            //send the data to bind in the Document Viewer
            ItemUnitsReport report = new ItemUnitsReport();
            report.DataSource = itemUnitscompantInfo.OrderBy(x => x.code);

            return View(report);
        }
    }
}
