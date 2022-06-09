using System.Collections.Generic;
using Newtonsoft.Json;

namespace PlayerApi.Content.Player
{
    public class Player
    {
        [JsonProperty("activities")]
        public List<Activity> Activities { get; set; }
        
        [JsonProperty("skillvalues")]
        public List<Skill> SkillValues { get; set; }
        
        [JsonProperty("name")]
        public string Name { get; set; }
        
        [JsonProperty("rank")]
        public string Rank { get; set; }
        
        [JsonProperty("magic")]
        public int Magic { get; set; }
        
        [JsonProperty("melee")]
        public int Melee { get; set; }
        
        [JsonProperty("ranged")]
        public int Ranged { get; set; }
        
        [JsonProperty("combatlevel")]
        public int CombatLevel { get; set; }
        
        [JsonProperty("totalxp")]
        public long TotalXp { get; set; }
        
        [JsonProperty("totalskill")]
        public int TotalSkill { get; set; }
        
        [JsonProperty("questscomplete")]
        public int QuestsComplete { get; set; }
        
        [JsonProperty("questsstarted")]
        public int QuestsStarted { get; set; }

        [JsonProperty("questsnotstarted")]
        public int QuestsNotStarted { get; set; }
        
        [JsonProperty("loggedIn")]
        public string LoggedIn { get; set; }
    }
}