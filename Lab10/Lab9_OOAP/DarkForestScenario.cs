using System.Collections.Generic;

namespace DarkForestGame
{
    public class DarkForestScenario : IScenario
    {
        public string Name => "Сценарій Темного лісу";

        public bool Execute(List<Artifact> artifacts)
        {
            return artifacts.Contains(Artifact.ForestCloak) && artifacts.Contains(Artifact.LightLantern);
        }
    }
}