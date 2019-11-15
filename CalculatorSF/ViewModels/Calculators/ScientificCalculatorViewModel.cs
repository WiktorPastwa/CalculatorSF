using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalculatorSF.Core.Calculations;
using CalculatorSF.ViewModels.Bases;

namespace CalculatorSF.ViewModels.Calculators
{
    public class ScientificCalculatorViewModel : CalculatorViewModel
    {
        public override string CalculatorType => "Scientific";

        public ScientificCalculatorViewModel(ICalculator calculator) : base(calculator)
        {

        }
    }
}
