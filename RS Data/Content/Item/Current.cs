using Newtonsoft.Json;

namespace PlayerApi.Content
{
    public class Current
    {
        [JsonProperty("trend")]
        public string Trend { get; set; }
        
        [JsonProperty("price")]
        public int Price { get; set; }

    }
}