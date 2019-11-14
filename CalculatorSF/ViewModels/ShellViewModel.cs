using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalculatorSF.Core.Calculations;
using CalculatorSF.ViewModels.Bases;
using CalculatorSF.ViewModels.Calculators;
using Prism.Commands;

namespace CalculatorSF.ViewModels
{
    public class ShellViewModel : ViewModelBase
    {
        public  ShellViewModel(ICalculator calculator)
        {
            var viewModel = new BasicCalculatorViewModel(calculator);
            SelectedCalculatorViewModel = viewModel;
        }

        public string Title { get; } = "Calculator";

        private ViewModelBase _selectedCalculatorViewModel;
        public ViewModelBase SelectedCalculatorViewModel 
        {
            get { return _selectedCalculatorViewModel; } 
            set { SetProperty(ref _selectedCalculatorViewModel, value); }
        }
    }
}
