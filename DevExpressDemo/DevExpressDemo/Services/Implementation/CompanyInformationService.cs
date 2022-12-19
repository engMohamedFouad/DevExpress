using DevExpressDemo.Helper;
using DevExpressDemo.ModelsDTO;
using DevExpressDemo.Services.Interface;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Net.Http.Headers;

namespace DevExpressDemo.Services.Implementation
{
    public class CompanyInformationService : ICompanyInformationService
    {
        FiniexApiHelper _finiexApi = new FiniexApiHelper();
        HttpClient client = new HttpClient();
        public CompanyInformationService()
        {
            //عشان يبقي علي مستوي الكل
            client = _finiexApi.Initial();
        }
        public async Task<CompanyInformation> GetCompanyInformation(string token)
        {
            //var token = HttpContext.Session.GetString("JWToken");
            CompanyInformation companyInformation = new CompanyInformation();
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
            HttpResponseMessage res = await client.GetAsync("/api/v1/general/company-informations");
            if (res.IsSuccessStatusCode)
            {
                var result = await res.Content.ReadAsStringAsync();
                var resultJObject = JObject.Parse(result);
                var listOfJson = resultJObject.Root["data"];
                var des = JsonConvert.DeserializeObject<CompanyInformation>(listOfJson.ToString());
                companyInformation = des;
            }
            return companyInformation;
        }
    }
}
