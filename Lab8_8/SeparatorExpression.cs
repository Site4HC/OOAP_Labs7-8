using DateInterpreterSimulation.Interfaces;
using DateInterpreterSimulation.Context;

namespace DateInterpreterSimulation.Expressions
{
    public class SeparatorExpression : IExpression
    {
        private readonly char _separator;

        public SeparatorExpression(char separator)
        {
            _separator = separator;
        }

        public void Interpret(DateContext context)
        {
            if (!context.IsValid) return;

            if (context.Position >= context.Input.Length || context.Input[context.Position] != _separator)
            {
                context.IsValid = false;
                context.ErrorMessage = $"Очікувався роздільник '{_separator}'.";
                return;
            }

            context.Position++; 
        }
    }
}