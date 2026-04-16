using System.Collections.Generic;

namespace DarkForestGame
{
    public class RiverScenario : IScenario
    {
        public string Name => "Річковий сценарій";

        public bool Execute(List<Artifact> artifacts)
        {
            return artifacts.Contains(Artifact.WaterBoots);
        }
    }
}