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
        #region Fields
        private string _calculatedExpression;
        #endregion

        #region Properties
        public override string CalculatorType => "Scientific";
        public override int height { get; set; } = 380;
        public override int width { get; set; } = 310;
        public string CalculatedExpression 
        {
            get => _calculatedExpression;
            set => SetProperty(ref _calculatedExpression, value);
        }
        #endregion

        #region Constructors
        public ScientificCalculatorViewModel(ICalculator calculator) : base(calculator)
        {

        }
        #endregion

        #region public/protected Methods
        protected override void Calculate()
        {
            CalculatedExpression = Expression;
            base.Calculate();
        }
        #endregion
    }
}
