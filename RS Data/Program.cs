using System;
using System.Collections.Generic;
using PlayerApi.Content;
using PlayerApi.Content.Player;
using RsApi.Handler;

namespace RsApi
{
    internal class Program
    {
        public static bool Active = true;
        public static ConsoleHandler ConsoleHandler;
        public static PlayerHandler PlayerHandler;
        public static ItemHandler ItemHandler;

        public static void Main(string[] args)
        {
            ConsoleHandler = new ConsoleHandler();
            ItemHandler = new ItemHandler();
            PlayerHandler = new PlayerHandler(new Dictionary<string, Player>
            {
                { "gods", null },
                { "wasy", null },
                { "spvnk", null },
                { "vislly", null },
                { "lint licker", null },
            });

            while (Active)
            {
                var input = Console.ReadLine();

                if (input != null)
                    ConsoleHandler.ProcessInput(input);
                else
                    Console.WriteLine("NULL INPUT");
            }
        }
    }
}