using AutoMapper;
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
    public class JournalController : Controller
    {
        FiniexApiHelper _finiexApi = new FiniexApiHelper();
        private readonly ICompanyInformationService _companyInformationService;
        private readonly IMapper _mapper;
        HttpClient client = new HttpClient();
        public JournalController(ICompanyInformationService companyInformationService, IMapper mapper)
        {
            //عشان يبقي علي مستوي الكل
            client = _finiexApi.Initial();
            _companyInformationService = companyInformationService;
            _mapper = mapper;
        }
        public async Task<IActionResult> GetJournalListReport(string? SearchString, string? OrderBy, int PageNumber = 1, int PageSize = 10)
        {
            //var token = HttpContext.Session.GetString("JWToken");
            var token = Request.Cookies["token"];
            List<JournalResponseAndCompanyInfoDTO> journalList = new List<JournalResponseAndCompanyInfoDTO>();
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
            HttpResponseMessage res = await client.GetAsync($"/api/v1/accounting/journal-entry/list?PageNumber={PageNumber}&PageSize={PageSize}&OrderBy={OrderBy}&SearchString={SearchString}");
            if (res.IsSuccessStatusCode)
            {
                var result = await res.Content.ReadAsStringAsync();
                var resultJObject = JObject.Parse(result);
                var listOfJson = resultJObject.Root["data"].ToList();
                foreach (var item in listOfJson)
                {
                    //object company information
                    var companyinformation = await _companyInformationService.GetCompanyInformation(token);

                    var des = JsonConvert.DeserializeObject<JournalResponseAndCompanyInfoDTO>(item.ToString());
                    if (des.IsDone == true)
                    {
                        des.IsDoneValue = "مرحل";
                    }
                    else
                    {
                        des.IsDoneValue = "غير مرحل";
                    }
                    //part for complete the data of companyinfo and Journal
                    var journalResponseCompanyInfo = _mapper.Map<JournalResponseAndCompanyInfoDTO>(companyinformation);
                    journalResponseCompanyInfo.MoveId = des.MoveId;
                    journalResponseCompanyInfo.MoveCode = des.MoveCode;
                    journalResponseCompanyInfo.Date = des.Date;
                    journalResponseCompanyInfo.AccName = des.AccName;
                    journalResponseCompanyInfo.IsDoneValue = des.IsDoneValue;
                    journalResponseCompanyInfo.MoveType = des.MoveType;
                    journalResponseCompanyInfo.Total = des.Total;
                    journalResponseCompanyInfo.UserID = des.UserID;
                    journalList.Add(journalResponseCompanyInfo);
                }
            }
            //send the data to bind in the Document Viewer
            JournalReport report = new JournalReport();
            report.DataSource = journalList;
            return View(report);
        }
    }
}
