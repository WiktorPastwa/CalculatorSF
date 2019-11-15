using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorSF.Model
{
    public class CalculationModel
    {
        public CalculationModel(string expression, string value)
        {
            Expression = expression;
            Value = value;
        }

        public string Expression { get; }
        public string Value { get; }
    }
}
