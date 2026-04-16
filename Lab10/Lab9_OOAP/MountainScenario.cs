using System.Collections.Generic;

namespace DarkForestGame
{
    public class MountainScenario : IScenario
    {
        public string Name => "Гірський сценарій";

        public bool Execute(List<Artifact> artifacts)
        {
            return artifacts.Contains(Artifact.MountainClaws);
        }
    }
}