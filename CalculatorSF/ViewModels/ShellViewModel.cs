using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalculatorSF.Core.Calculations;
using CalculatorSF.Core.Helpers;
using CalculatorSF.Model;
using CalculatorSF.ViewModels.Bases;
using CalculatorSF.ViewModels.Calculators;
using CalculatorSF.ViewModels.Interfaces;
using Prism.Commands;

namespace CalculatorSF.ViewModels
{
    public class ShellViewModel : ViewModelBase
    {
        private readonly IContainerHelper _containerHelper;

        public  ShellViewModel(IContainerHelper containerHelper)
        {
            _containerHelper = containerHelper;
        }

        public string Title { get; } = "Calculator";

        private ICalculatorViewModel _selectedCalculatorViewModel;
        public ICalculatorViewModel SelectedCalculatorViewModel 
        {
            get { return _selectedCalculatorViewModel; } 
            set { SetProperty(ref _selectedCalculatorViewModel, value); }
        }

        private bool _flyoutOpen;
        public bool FlyoutOpen 
        { 
            get { return _flyoutOpen; } 
            set { SetProperty(ref _flyoutOpen, value); }
        }

        public DelegateCommand OpenFlyoutCommand { get; set; }
        public DelegateCommand<CalculatorType> CalculatorChangeCommand { get; set; }

        protected override void RegisterCommands()
        {
            OpenFlyoutCommand = new DelegateCommand(OpenFlyout);
            CalculatorChangeCommand = new DelegateCommand<CalculatorType>(CalculatorChanged);
        }

        private void OpenFlyout()
        {
            FlyoutOpen = true;
        }

        private void CalculatorChanged(CalculatorType calculatorType)
        {
            var newCalculator = (ICalculatorViewModel) _containerHelper.Create(calculatorType.TypeName);
            SelectedCalculatorViewModel = newCalculator;
            FlyoutOpen = false;
        }
    }
}
