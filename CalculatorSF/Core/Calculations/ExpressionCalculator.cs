using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorSF.Core.Calculations
{
    public class ExpressionCalculator : ICalculator
    {
        #region private Methods
        private string CheckScientificCalculations(string expression)
        {
            if (expression.Contains("sin"))
            {
                expression = expression.Replace("sin", "");
                expression = expression.Replace("(", "");
                expression = expression.Replace(")", "");
                var angleValue = Math.Sin((Math.PI * double.Parse(expression) / 180));
                expression = angleValue.ToString();
            }
            else if (expression.Contains("cos"))
            {
                expression = expression.Replace("cos", "");
                expression = expression.Replace("(", "");
                expression = expression.Replace(")", "");
                var angleValue = Math.Cos((Math.PI * double.Parse(expression) / 180));
                expression = angleValue.ToString();
            }
            else if (expression.Contains("tan"))
            {
                expression = expression.Replace("tan", "");
                expression = expression.Replace("(", "");
                expression = expression.Replace(")", "");
                var angleValue = Math.Tan((Math.PI * double.Parse(expression) / 180));
                expression = angleValue.ToString();
            }
            else if (expression.Contains("√"))
            {
                expression = expression.Replace("√", "");
                var value = Math.Sqrt(double.Parse(expression));
                expression = value.ToString();
            }
            else if(expression.Contains("π"))
            {
                expression = expression.Replace("π", "3.14");
            }
            else if (expression.Contains("^"))
            {
                string[] separator = { "^" };
                Int32 count = 2;
                string[] expressionList = expression.Split(separator, count, StringSplitOptions.RemoveEmptyEntries);
                var value = Math.Pow(double.Parse(expressionList[0]), double.Parse(expressionList[1]));
                expression = value.ToString();
            }

            expression = expression.Replace(",", ".");

            return expression;
        }
        #endregion

        #region public/protected Methods
        public double Calculate(string expression)
        {
            expression = CheckScientificCalculations(expression);

            var dataTable = new DataTable();
            var value = dataTable.Compute(expression, "");

            return Convert.ToDouble(value);
        }
        #endregion
    }
}
