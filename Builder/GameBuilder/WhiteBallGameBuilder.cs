using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Builder.GameBuilder
{
    public class WhiteBallGameBuilder : IGameBuilder
    {
        private Game game = new Game();
        public void BuildIsColorfulJersey(bool isColorfulJersey)
        {
            game.IsColorfulJersey = isColorfulJersey;
        }

        public void BuildNameOfTournament(string name)
        {
            game.TournamentName = name;
        }

        public void BuildNumberOfDays(int days)
        {
            game.NumberOfDay = days;
        }

        public void BuildNumberOfOvers(string overs)
        {
            game.NumberOfOver = overs;
        }

        public void BuildRules(List<string> rules)
        {
            rules.Add("Game Must be finished within the day");
            rules.Add("There will be not more than one break within the game");
            game.Rules = rules;
        }

        public Game GetGame()
        {
            return game;
        }
    }
}
