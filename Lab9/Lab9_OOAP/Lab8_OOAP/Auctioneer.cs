using System;
using System.Collections.Generic;

namespace AuctionApp
{
    public class Auctioneer : IAuctionSubject
    {
        private readonly List<IAuctionObserver> _observers = new List<IAuctionObserver>();
        public decimal CurrentBid { get; private set; }
        public string HighestBidder { get; private set; }

        public event Action<string> OnLog;

        public void Attach(IAuctionObserver observer)
        {
            _observers.Add(observer);
            OnLog?.Invoke($"Учасник {observer.Name} приєднався до аукціону.");
        }

        public void Detach(IAuctionObserver observer)
        {
            _observers.Remove(observer);
            OnLog?.Invoke($"Учасник {observer.Name} покинув аукціон.");
        }

        public void Notify(string bidderName, decimal newBid)
        {
            foreach (var observer in _observers)
            {
                observer.Update(bidderName, newBid);
            }
        }

        public bool PlaceBid(IAuctionObserver participant, decimal bidAmount)
        {
            if (bidAmount > CurrentBid)
            {
                CurrentBid = bidAmount;
                HighestBidder = participant.Name;
                OnLog?.Invoke($"Ведучий прийняв ставку {bidAmount} від {participant.Name}.");
                Notify(participant.Name, bidAmount);
                return true;
            }
            else
            {
                OnLog?.Invoke($"Ставка {bidAmount} від {participant.Name} відхилена. Поточна ставка {CurrentBid}.");
                return false;
            }
        }
    }
}