using DevExpressDemo.Helper;
using DevExpressDemo.ModelsDTO;
using DevExpressDemo.Reports;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Net.Http.Headers;
namespace DevExpressDemo.Controllers
{
    public class HomeController : Controller
    {

        FiniexApiHelper _finiexApi = new FiniexApiHelper();
        HttpClient client = new HttpClient();
        public HomeController()
        {
            //عشان يبقي علي مستوي الكل
            client = _finiexApi.Initial();
        }
        public async Task<IActionResult> Index()
        {
            return View();
        }
        public async Task<IActionResult> BranchReportViewer(string id)
        {
            //var token = HttpContext.Session.GetString("JWToken");
            var token = Request.Cookies["token"];
            List<ExpensesResponse> expenses = new List<ExpensesResponse>();
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
            HttpResponseMessage res = await client.GetAsync("/api/v1/purchases/purchases-expenses");
            if (res.IsSuccessStatusCode)
            {
                var result = await res.Content.ReadAsStringAsync();
                var resultJObject = JObject.Parse(result);
                var listOfJson = resultJObject.Root["data"].ToList();
                foreach (var item in listOfJson)
                {
                    var des = JsonConvert.DeserializeObject<ExpensesResponse>(item.ToString());
                    expenses.Add(des);
                }
            }

            //send the data to bind in the Document Viewer
            BranchesAndWarehouseReport report = new BranchesAndWarehouseReport();
            report.DataSource = expenses;
            return View(report);
        }

        public async Task<IActionResult> PurchaseInvoiceViewer(string id = "1")
        {
            //var token = HttpContext.Session.GetString("JWToken");
            var token = Request.Cookies["token"];
            List<PurchaseInvoice> invoice = new List<PurchaseInvoice>();
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
            HttpResponseMessage res = await client.GetAsync($"/api/v1/purchases/purchases-invoice/{id}");
            if (res.IsSuccessStatusCode)
            {
                var result = await res.Content.ReadAsStringAsync();
                var resultJObject = JObject.Parse(result);
                var listOfJson = resultJObject.Root["data"];
                //لوحده كده object مش بتاخد  datasource عشان  list عملناها 
                invoice.Add(JsonConvert.DeserializeObject<PurchaseInvoice>(listOfJson.ToString()));

            }
            //send the data to bind in the Document Viewer
            PurchaseInvoiceReport report = new PurchaseInvoiceReport();
            report.DataSource = invoice;
            return View(report);
        }
        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult ReceiveToken(string id)
        {
            //delete the old
            Response.Cookies.Delete("token");
            //add the new Token
            CookieOptions cookieOptions = new CookieOptions();
            cookieOptions.Expires = DateTime.Now.AddDays(30);
            Response.Cookies.Append("token", id, cookieOptions);

            //session 
            ////اول حاجة نحزف القديم
            //HttpContext.Session.Clear();
            //HttpContext.Session.SetString("JWToken", id);
            return Redirect("~/Home/Index");
        }
    }
}