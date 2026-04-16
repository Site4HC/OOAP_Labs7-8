namespace AuctionApp
{
    public interface IAuctionSubject
    {
        void Attach(IAuctionObserver observer);
        void Detach(IAuctionObserver observer);
        void Notify(string bidderName, decimal newBid);
    }
}