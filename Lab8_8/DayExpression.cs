using DateInterpreterSimulation.Interfaces;
using DateInterpreterSimulation.Context;

namespace DateInterpreterSimulation.Expressions
{
    public class DayExpression : IExpression
    {
        public void Interpret(DateContext context)
        {
            if (!context.IsValid) return;

            if (context.Position + 2 > context.Input.Length)
            {
                context.IsValid = false;
                context.ErrorMessage = "Недостатньо символів для дня.";
                return;
            }

            string part = context.Input.Substring(context.Position, 2);
            if (int.TryParse(part, out int day) && day >= 1 && day <= 31)
            {
                context.Day = day;
                context.Position += 2; 
            }
            else
            {
                context.IsValid = false;
                context.ErrorMessage = "Невірний день. Очікується 01-31.";
            }
        }
    }
}