
using Observer;

namespace Observer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Subject
           Subject subject = new Subject();

            // Subscribers (Observers)
            IObserver premiumOne = new PremiumMembers("Tom");
            IObserver premiumTwo = new PremiumMembers("Dick");
            IObserver premiumThree = new StandardMembers("Harry");

            // Register observers with the OTT
            subject.AddObserver(premiumOne);
            subject.AddObserver(premiumTwo);
            subject.AddObserver(premiumThree);

            // OTT sends an promotional message
            subject.SetPromotionMessage("NEW DISCOUNT 15%");

            // Remove an subscriber (unsubscribing)
            subject.RemoveObserver(premiumOne);

            // OTT sends another update
            subject.SetPromotionMessage("NEW DISCOUNT 30%");

            Console.ReadLine();
        }
    }
}
