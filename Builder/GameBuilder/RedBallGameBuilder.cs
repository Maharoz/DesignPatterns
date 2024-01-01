using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.GameBuilder
{
    public class RedBallGameBuilder : IGameBuilder
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
            game.NumberOfDay= days;
        }

        public void BuildNumberOfOvers(string overs)
        {
            game.NumberOfOver = overs;
        }

        public void BuildRules(List<string> rules)
        {
            rules.Add("There will be multiple sessions in a day");
            rules.Add("Each session will not lesser than 25 overs");
            game.Rules = rules;
        }
        public Game GetGame()
        {
            return game;
        }
    }
}
