using System;
using System.Collections.Generic;

namespace DarkForestGame
{
    public class Unit
    {
        public List<Artifact> Artifacts { get; private set; }
        private IScenario _scenario;

        public Unit()
        {
            Artifacts = new List<Artifact>();
        }

        public void SetScenario(IScenario scenario)
        {
            _scenario = scenario;
        }

        public void AddArtifact(Artifact artifact)
        {
            if (Artifacts.Count >= 2)
            {
                throw new InvalidOperationException("Юніт може мати лише два артефакти.");
            }
            if (!Artifacts.Contains(artifact))
            {
                Artifacts.Add(artifact);
            }
        }

        public void ClearArtifacts()
        {
            Artifacts.Clear();
        }

        public string Play()
        {
            if (_scenario == null)
            {
                return "Сценарій не обрано.";
            }

            bool success = _scenario.Execute(Artifacts);
            return success ? $"Юніт успішно пройшов випробування: {_scenario.Name}!" : $"Юніт не зміг пройти випробування: {_scenario.Name}.";
        }
    }
}