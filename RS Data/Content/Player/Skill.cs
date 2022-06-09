using Newtonsoft.Json;

namespace PlayerApi.Content.Player
{
    public class Skill
    {
        [JsonProperty("level")]
        public int Level { get; set; }
        
        [JsonProperty("dxp")]
        public int Xp { get; set; }
        
        [JsonProperty("rank")]
        public int Rank { get; set; }
        
        [JsonProperty("id")]
        public int Id { get; set; }
    }
}