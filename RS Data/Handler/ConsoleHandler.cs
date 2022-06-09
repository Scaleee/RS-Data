using System;
using PlayerApi.Content;
using PlayerApi.Content.Player;

namespace RsApi.Handler
{
    public class ConsoleHandler
    {
        public void ProcessInput(string input)
        {
            var split = input.ToLower().Split(' ');
            
            switch (split[0])
            {
                case "-help":
                    HelpMenu();
                    break;
                
                case "-exit":
                    Program.Active = false;
                    break;
                
                case "-item":
                    if (split.Length < 2)
                    {
                        Console.WriteLine("Requires argument of item ID or name");
                        break;
                    }
                    
                    if (int.TryParse(split[1], out var val))
                        Program.ItemHandler.Search(val);
                    else
                        Program.ItemHandler.Search(split[1]);
                    
                    break;
                
                case "-player":
                    if (split.Length < 2)
                    {
                        Console.WriteLine("Requires argument of player name");
                        break;
                    }
                    else if (split.Length == 2)
                    {
                        Program.PlayerHandler.Search(split[1]);
                    }
                    else if (split.Length == 3)
                    {
                        switch (split[1])
                        {
                            case "add":
                                Program.PlayerHandler.AddPlayer(split[2]);
                                break;
                            
                            case "remove":
                                Program.PlayerHandler.RemovePlayer(split[2]);
                                break;
                            
                            case "update":
                                Program.PlayerHandler.UpdatePlayer(split[2]);
                                break;
                        }
                    }
                    
                    break;
            }
        }
        
        public void HelpMenu()
        { 
            Console.WriteLine("-I       Look up item information with ID\n");
            Console.WriteLine("-P       Look up player information with name\n");
            Console.WriteLine("-exit    Exits the program\n");
        }

        public void DisplayItem(Item i)
        {
            Console.WriteLine("\nName: " + i.Name);
            Console.WriteLine("\nId: " + i.Id);
            Console.WriteLine("\nType: " + i.Type);
            Console.WriteLine("\nDescription: " + i.Description);
            Console.WriteLine("\nCurrent Price: " + i.Current.Price);
            Console.WriteLine("\nPrevious Price: " + i.Today.Price);
        }
        
        public void DisplayItem(Player? p)
        {
            Console.WriteLine("\nName: " + p.Name);
            Console.WriteLine("Total Level: " + p.TotalSkill);
            Console.WriteLine("Total Xp: " + p.TotalXp + "\n");
        }
        
    }
}