using System.Collections.Generic;
using Newtonsoft.Json;

namespace PlayerApi.Content
{
    public class Root
    {
        [JsonProperty("total")]
        public int Total { get; set; }
        
        [JsonProperty("items")]
        public List<Item> Items { get; set; }
    }
}