using System.Collections.Generic;
using DateInterpreterSimulation.Interfaces;
using DateInterpreterSimulation.Expressions;
using DateInterpreterSimulation.Context;

namespace DateInterpreterSimulation.Services
{
    public class DateParser
    {
        public DateContext Parse(string input, string format)
        {
            List<IExpression> expressionTree = new List<IExpression>();
            string[] formatParts = format.Split('-');

            for (int i = 0; i < formatParts.Length; i++)
            {
                if (formatParts[i] == "DD") expressionTree.Add(new DayExpression());
                else if (formatParts[i] == "MM") expressionTree.Add(new MonthExpression());
                else if (formatParts[i] == "YYYY") expressionTree.Add(new YearExpression());

                if (i < formatParts.Length - 1)
                {
                    expressionTree.Add(new SeparatorExpression('-'));
                }
            }

            var context = new DateContext(input);

            foreach (var expression in expressionTree)
            {
                expression.Interpret(context);
                if (!context.IsValid) break; 
            }

            if (context.IsValid && context.Position < context.Input.Length)
            {
                context.IsValid = false;
                context.ErrorMessage = "Рядок містить зайві символи в кінці.";
            }

            return context;
        }
    }
}