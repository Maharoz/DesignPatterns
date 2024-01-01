using Builder.GameBuilder;

namespace Builder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GameDirector director = new GameDirector();
            IGameBuilder redBallBuilder = new RedBallGameBuilder();
            IGameBuilder whiteBallBuilder = new WhiteBallGameBuilder();

            List<string> whiteBallRules = new List<string> { "2 Innings", "Minimum 7 local player in a side" };
            List<string> redBallRules = new List<string> { "4 Innings","No overseas player permitted" };

            // Construct a Red ball game
            director.Construct(redBallBuilder, 5, false,"UNLIMITED","Classic test", redBallRules);
            Game redBallGame = redBallBuilder.GetGame();

            // Construct an White ball game
            director.Construct(whiteBallBuilder, 1, true, "10", "T-10", whiteBallRules);
            Game whiteBallGame = whiteBallBuilder.GetGame();

            // Display game details
            Console.WriteLine("Red ball game:");
            redBallGame.Display();

            Console.WriteLine("\nWhite ball game:");
            whiteBallGame.Display();

            Console.ReadLine();
        }
    }
}
