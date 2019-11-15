using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalculatorSF.Model;

namespace CalculatorSF.Core.Constants
{
    public static class Calculators
    {
        public static CalculatorType[] CalculatorTypes = new[]
        {
            CalculatorType.Create("Basic", "BasicCalculatorViewModel"),
            CalculatorType.Create("Scientific", "ScientificCalculatorViewModel")
        };
    }
}
