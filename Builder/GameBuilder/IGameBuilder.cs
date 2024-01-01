using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.GameBuilder
{
    public interface IGameBuilder
    {
        void BuildNumberOfDays(int days);
        void BuildNumberOfOvers(string overs);
        void BuildNameOfTournament(string name);
        void BuildIsColorfulJersey(bool isColorfulJersey);  
        void BuildRules(List<string> rules);
        Game GetGame();
    }
}
