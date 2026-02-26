using System;
using System.Collections.Generic;
using SoftwareDevelopmentSimulation.Interfaces;
using SoftwareDevelopmentSimulation.Base;

namespace SoftwareDevelopmentSimulation.Services
{
    public class ProjectManager : IProjectManager
    {
        private readonly List<Colleague> _colleagues = new List<Colleague>();
        private readonly Action<string> _logToUi;

        public ProjectManager(Action<string> logToUi)
        {
            _logToUi = logToUi;
        }

        public void RegisterColleague(Colleague colleague)
        {
            if (colleague == null) throw new ArgumentNullException(nameof(colleague));
            _colleagues.Add(colleague);
        }

        public void SendMessage(string message, Colleague sender)
        {
            if (string.IsNullOrWhiteSpace(message)) return;

            _logToUi?.Invoke($"[{sender.Role} {sender.Name}]: {message}");

            foreach (var colleague in _colleagues)
            {
                if (colleague != sender)
                    colleague.Receive(message);
            }
        }
    }
}