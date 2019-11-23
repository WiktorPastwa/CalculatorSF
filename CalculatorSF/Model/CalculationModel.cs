using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorSF.Model
{
    public class CalculationModel
    {
        #region Properties
        public string Expression { get; }
        public string Value { get; }
        #endregion

        #region Constructors
        public CalculationModel(string expression, string value)
        {
            Expression = expression;
            Value = value;
        }
        #endregion
    }
}
