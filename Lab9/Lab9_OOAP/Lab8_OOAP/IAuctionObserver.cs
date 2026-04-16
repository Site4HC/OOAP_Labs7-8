namespace AuctionApp
{
    public interface IAuctionObserver
    {
        string Name { get; }
        void Update(string bidderName, decimal newBid);
    }
}