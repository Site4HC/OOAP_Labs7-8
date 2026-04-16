using System.Collections.Generic;

namespace DarkForestGame
{
    public class ForestScenario : IScenario
    {
        public string Name => "Лісовий сценарій";

        public bool Execute(List<Artifact> artifacts)
        {
            return artifacts.Contains(Artifact.ForestCloak);
        }
    }
}