namespace SmartRoomApp.Core
{
    public interface ICommand
    {
        string Name { get; }
        void Execute();
        void Undo();
    }
}