using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class Game
    {
        public int NumberOfDay { get; set; }
        public bool IsColorfulJersey { get; set; }
        public string TournamentName { get; set; }
        public string NumberOfOver { get; set; }
        public List<string> Rules { get; set; }

        public void Display() {
            Console.WriteLine($"Allotted Number of day:{NumberOfDay}");
            Console.WriteLine($"Colorful Jersey:{(IsColorfulJersey?"Yes":"No")}");
            Console.WriteLine($"Tournament Name:{TournamentName}");
            Console.WriteLine($"Number of over:{NumberOfOver}");
            Console.WriteLine("Rules:");

            foreach(var rule in Rules )
            {
                Console.WriteLine($"= {rule}");
            }
                
        }
    }
}
