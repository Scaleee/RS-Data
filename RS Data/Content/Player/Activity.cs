using Newtonsoft.Json;

namespace PlayerApi.Content.Player
{
    public class Activity
    {
        [JsonProperty("date")]
        public string Date { get; set; }
        
        [JsonProperty("details")]
        public string Details { get; set; }
        
        [JsonProperty("text")]
        public string Text { get; set; }
    }
}