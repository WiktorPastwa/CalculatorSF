using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalculatorSF.Core.Calculations;
using CalculatorSF.ViewModels.Bases;
using Prism.Commands;

namespace CalculatorSF.ViewModels.Calculators
{
    public class BasicCalculatorViewModel : CalculatorViewModel
    {
        public override string CalculatorType => "Basic";
        public override int height { get; set; } = 300;
        public override int width { get; set; } = 310;

        public BasicCalculatorViewModel(ICalculator calculator):base(calculator)
        {
            
        }
    }
}
