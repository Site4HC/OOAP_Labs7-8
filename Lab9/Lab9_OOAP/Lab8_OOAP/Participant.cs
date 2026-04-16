using System;

namespace AuctionApp
{
    public class Participant : IAuctionObserver
    {
        public string Name { get; }
        public event Action<string> OnNotificationReceived;

        public Participant(string name)
        {
            Name = name;
        }

        public void Update(string bidderName, decimal newBid)
        {
            if (bidderName != Name)
            {
                OnNotificationReceived?.Invoke($"[{Name}] дізнався: {bidderName} зробив ставку {newBid}");
            }
        }

        public override string ToString()
        {
            return Name;
        }
    }
}