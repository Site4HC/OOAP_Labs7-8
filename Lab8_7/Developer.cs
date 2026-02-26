using SoftwareDevelopmentSimulation.Base;
using SoftwareDevelopmentSimulation.Interfaces;
using SoftwareDevelopmentSimulation.Services;

namespace SoftwareDevelopmentSimulation.Models
{
    public class Developer : Colleague
    {
        public Developer(string name, IProjectManager mediator)
            : base(name, "Програміст", mediator) { }

        public override void Receive(string message)
        {
            string lowerMessage = message.ToLower();

            if (lowerMessage.Contains("баг") || lowerMessage.Contains("помилка"))
                this.Send($"На моєму комп'ютері все працює... Але добре, я перевірю цей баг.");
            else if (lowerMessage.Contains("завдання") || lowerMessage.Contains("таска"))
                this.Send($"Оцінюю це завдання в 4 години. Починаю писати код.");
        }
    }
}