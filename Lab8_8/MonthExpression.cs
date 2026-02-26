using DateInterpreterSimulation.Interfaces;
using DateInterpreterSimulation.Context;

namespace DateInterpreterSimulation.Expressions
{
    public class MonthExpression : IExpression
    {
        public void Interpret(DateContext context)
        {
            if (!context.IsValid) return;

            if (context.Position + 2 > context.Input.Length)
            {
                context.IsValid = false;
                context.ErrorMessage = "Недостатньо символів для місяця.";
                return;
            }

            string part = context.Input.Substring(context.Position, 2);
            if (int.TryParse(part, out int month) && month >= 1 && month <= 12)
            {
                context.Month = month;
                context.Position += 2;
            }
            else
            {
                context.IsValid = false;
                context.ErrorMessage = "Невірний місяць. Очікується 01-12.";
            }
        }
    }
}