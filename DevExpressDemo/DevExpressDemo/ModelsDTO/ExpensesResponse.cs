using Newtonsoft.Json;

namespace DevExpressDemo.ModelsDTO
{
    public class ExpensesResponse
    {
        [JsonProperty]
        public string? accID { get; set; }
        [JsonProperty]
        public string? accName { get; set; }
    }
}
