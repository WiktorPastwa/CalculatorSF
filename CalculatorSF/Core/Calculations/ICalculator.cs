using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorSF.Core.Calculations
{
    public interface ICalculator
    {
        double Calculate(string expression);
    }
}
