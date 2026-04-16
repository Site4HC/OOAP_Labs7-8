using System.Collections.Generic;

namespace DarkForestGame
{
    public interface IScenario
    {
        string Name { get; }
        bool Execute(List<Artifact> artifacts);
    }
}