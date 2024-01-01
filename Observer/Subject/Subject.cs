
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    public class Subject: ISubject
    {
        private List<IObserver> observers = new List<IObserver>();
        private string promotionUpdate;

        public void AddObserver(IObserver observer)
        {
            observers.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            observers.Remove(observer);
        }

        public void NotifyObservers()
        {
            foreach (var observer in observers)
            {
                observer.Update(promotionUpdate);

                //Simulation
                Thread.Sleep(1000);
            }
        }

        public void SetPromotionMessage(string update)
        {
            promotionUpdate = update;
            NotifyObservers();
        }
    }
}
