using SoftwareDevelopmentSimulation.Base;
using SoftwareDevelopmentSimulation.Interfaces;

namespace SoftwareDevelopmentSimulation.Models
{
    public class Customer : Colleague
    {
        public Customer(string name, IProjectManager mediator)
            : base(name, "Замовник", mediator) { }

        public override void Receive(string message)
        {
            if (message.ToLower().Contains("реліз"))
                Console.WriteLine($"[Система]: Замовник {Name} пішов перевіряти продакшн.");
        }
    }
}