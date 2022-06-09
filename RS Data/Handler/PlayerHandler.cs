using System;
using System.Collections.Generic;
using System.Net.Http;
using Newtonsoft.Json;
using PlayerApi.Content.Player;
using RsApi.Configuration.Identifiers;

namespace RsApi.Handler
{ 
    public class PlayerHandler
    {
        private readonly Dictionary<string, Player> data;
        public PlayerHandler(Dictionary<string, Player> data)
        {
            this.data = data;
            
            UpdatePlayers();
        }

        public void Search(string name)
        {
            Program.ConsoleHandler.DisplayItem(data[name.ToLower()]);
        }

        private void UpdatePlayers()
        {
            using var client = new HttpClient();
            
            foreach (var d in data)
            {
                var endpoint = new Uri($"{UriStrings.ProfileUrl}{d.Key}");
                var json = client.GetAsync(endpoint).Result.Content.ReadAsStringAsync().Result;

                data[d.Key] = JsonConvert.DeserializeObject<Player>(json);
            }
        }

        public void UpdatePlayer(string key)
        {
            using var client = new HttpClient();
            
            var endpoint = new Uri($"{UriStrings.ProfileUrl}{key}");
            var json = client.GetAsync(endpoint).Result.Content.ReadAsStringAsync().Result;

            data[key] = JsonConvert.DeserializeObject<Player>(json);
        }

        public void AddPlayer(string key)
        {
            using var client = new HttpClient();
            
            var endpoint = new Uri($"{UriStrings.ProfileUrl}{key}");
            var json = client.GetAsync(endpoint).Result.Content.ReadAsStringAsync().Result;

            data.Add(key, JsonConvert.DeserializeObject<Player>(json));
        }

        public void RemovePlayer(string key)
        {
            data.Remove(key);
        }
    }
}