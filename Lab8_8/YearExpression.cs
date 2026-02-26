using DateInterpreterSimulation.Interfaces;
using DateInterpreterSimulation.Context;

namespace DateInterpreterSimulation.Expressions
{
    public class YearExpression : IExpression
    {
        public void Interpret(DateContext context)
        {
            if (!context.IsValid) return;

            if (context.Position + 4 > context.Input.Length)
            {
                context.IsValid = false;
                context.ErrorMessage = "Недостатньо символів для року.";
                return;
            }

            string part = context.Input.Substring(context.Position, 4);
            if (int.TryParse(part, out int year) && year >= 1000 && year <= 9999)
            {
                context.Year = year;
                context.Position += 4;
            }
            else
            {
                context.IsValid = false;
                context.ErrorMessage = "Невірний рік. Очікується 4 цифри.";
            }
        }
    }
}