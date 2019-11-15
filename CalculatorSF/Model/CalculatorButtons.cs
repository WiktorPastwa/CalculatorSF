using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorSF.Model
{
    public class CalculatorButtons : Button
    {
        public CalculatorButtons(string label, string commandParameter, int order) : base(label, commandParameter, order)
        {

        }

        public static CalculatorButtons Create(string label, string commandParameter, int order)
        {
            return new CalculatorButtons(label, commandParameter, order);
        }
    }
}
