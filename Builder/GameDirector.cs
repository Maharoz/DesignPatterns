using Builder.GameBuilder;

namespace Builder
{
    public class GameDirector
    {
        public void Construct(IGameBuilder builder,int numberOfDays,bool isColorfulJersey, string numberOfOvers,
            string tournamentName, List<string> rules)
        {
            builder.BuildNumberOfDays(numberOfDays);
            builder.BuildIsColorfulJersey(isColorfulJersey);
            builder.BuildNameOfTournament(tournamentName);
            builder.BuildNumberOfOvers(numberOfOvers);
            builder.BuildRules(rules);

        }
    }
}
