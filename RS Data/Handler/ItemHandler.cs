using System.Collections.Generic;
using System.Linq;
using PlayerApi.Content;

namespace RsApi.Handler
{
    public class ItemHandler
    {
        public readonly Dictionary<int, Item> Data = new Dictionary<int, Item>();

        public void Search(int item)
        {
            var i = Data[item];
            Program.ConsoleHandler.DisplayItem(i);
        }
        
        public void Search(string item)
        {
            var i = Data.First(x => x.Value.Name.Equals(item)).Value;
            Program.ConsoleHandler.DisplayItem(i);
        }
    }
}