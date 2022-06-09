using Newtonsoft.Json;

namespace PlayerApi.Content
{
    public class Today
    {
        [JsonProperty("trend")]
        public string Trend { get; set; }
        
        [JsonProperty("price")]
        public string Price { get; set; }
    }
}