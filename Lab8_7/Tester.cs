using SoftwareDevelopmentSimulation.Base;
using SoftwareDevelopmentSimulation.Interfaces;

namespace SoftwareDevelopmentSimulation.Models
{
    public class Tester : Colleague
    {
        public Tester(string name, IProjectManager mediator)
            : base(name, "Тестувальник", mediator) { }

        public override void Receive(string message)
        {
            if (message.ToLower().Contains("помилка"))
                Console.WriteLine($"[Система]: Тестувальник {Name} автоматично створив баг-репорт!");
        }
    }
}