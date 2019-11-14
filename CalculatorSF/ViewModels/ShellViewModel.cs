using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalculatorSF.Core.Calculations;
using CalculatorSF.ViewModels.Bases;
using Prism.Commands;

namespace CalculatorSF.ViewModels
{
    public class ShellViewModel : ViewModelBase
    {
        private readonly ICalculator _calculator;
        private bool hasCalculated;

        public ShellViewModel(ICalculator calculator)
        {
            _calculator = calculator;
        }

        public string Title { get; } = "Calculator";

        private string _expression;
        public string Expression 
        {
            get => _expression; 
            set => SetProperty(ref _expression, value);
        }

        public DelegateCommand<string> AddNumberCommand { get; set; }
        public DelegateCommand ClearCommand { get; set; }
        public DelegateCommand EqualsCommand { get; set; }

        protected override void RegisterCommands()
        {
            AddNumberCommand = new DelegateCommand<string>(AddNumber);
            ClearCommand = new DelegateCommand(Clear);
            EqualsCommand = new DelegateCommand(Calculate);
        }

        private void AddNumber(string buttonValue)
        {
            if (hasCalculated)
            {
                Clear();
                hasCalculated = false;
            }
            Expression += buttonValue;
        }

        private void Clear()
        {
            Expression = string.Empty;
        }

        private void Calculate()
        {
            Expression = _calculator.Calculate(Expression).ToString("N1");
            hasCalculated = true;
        }
    }
}
