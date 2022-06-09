using System.Collections.Generic;
using Newtonsoft.Json;

namespace PlayerApi.Content
{
    public class Item
    {
        [JsonProperty("item")]
        public string ItemList { get; set; }
        
        [JsonProperty("icon")]
        public string Icon { get; set; }
        
        [JsonProperty("iconLarge")]
        public string IconLarge { get; set; }
        
        [JsonProperty("id")]
        public int Id { get; set; }
        
        [JsonProperty("type")]
        public string Type { get; set; }
        
        [JsonProperty("typeIcon")]
        public string TypeIcon { get; set; }
        
        [JsonProperty("name")]
        public string Name { get; set; }
        
        [JsonProperty("description")]
        public string Description { get; set; }
                
        [JsonProperty("current")]
        public Current Current { get; set; }
                
        [JsonProperty("today")]
        public Today Today { get; set; }
                
        [JsonProperty("members")]
        public string Members { get; set; }
    }

}