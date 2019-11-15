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
        public override int height { get; set; } = 420;
        public override int width { get; set; } = 310;

        private string _calculatedExpression;
        public string CalculatedExpression 
        {
            get => _calculatedExpression;
            set => SetProperty(ref _calculatedExpression, value);
        }

        public ScientificCalculatorViewModel(ICalculator calculator) : base(calculator)
        {

        }

        protected override void Calculate()
        {
            CalculatedExpression = Expression;
            base.Calculate();
        }
    }
}
