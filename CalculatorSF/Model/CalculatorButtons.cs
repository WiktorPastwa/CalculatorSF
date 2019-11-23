using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorSF.Model
{
    public class CalculatorButtons : Button
    {
        #region Constructors
        public CalculatorButtons(string label, string commandParameter, int order) : base(label, commandParameter, order)
        {

        }
        #endregion

        #region public/protected Methods
        public static CalculatorButtons Create(string label, string commandParameter, int order)
        {
            return new CalculatorButtons(label, commandParameter, order);
        }
        #endregion
    }
}
