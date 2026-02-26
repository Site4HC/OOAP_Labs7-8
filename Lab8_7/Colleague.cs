using SoftwareDevelopmentSimulation.Interfaces;
using SoftwareDevelopmentSimulation.Services;
using System;

namespace SoftwareDevelopmentSimulation.Base
{
    public abstract class Colleague
    {
        protected IProjectManager _mediator;
        public string Name { get; }
        public string Role { get; }

        protected Colleague(string name, string role, IProjectManager mediator)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException("Ім'я не може бути порожнім");

            Name = name;
            Role = role;
            _mediator = mediator;
        }

        public abstract void Receive(string message);

        public void Send(string message)
        {
            _mediator.SendMessage(message, this);
        }
    }
}