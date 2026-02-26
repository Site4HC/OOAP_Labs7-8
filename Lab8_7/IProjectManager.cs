using SoftwareDevelopmentSimulation.Base;

namespace SoftwareDevelopmentSimulation.Interfaces
{
    public interface IProjectManager
    {
        void SendMessage(string message, Colleague colleague);
        void RegisterColleague(Colleague colleague);
    }
}