using DateInterpreterSimulation.Context;

namespace DateInterpreterSimulation.Interfaces
{
    public interface IExpression
    {
        void Interpret(DateContext context);
    }
}