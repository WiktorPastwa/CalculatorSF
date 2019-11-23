using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalculatorSF.Core.Calculations;
using CalculatorSF.Model;
using CalculatorSF.ViewModels.Interfaces;
using Prism.Commands;

namespace CalculatorSF.ViewModels.Bases
{
    public abstract class CalculatorViewModel : ViewModelBase, ICalculatorViewModel
    {
        #region Fileds
        private readonly ICalculator _calculator;
        private string _expression;
        protected bool hasCalculated;
        #endregion

        #region Properties
        public string Expression
        {
            get => _expression;
            set => SetProperty(ref _expression, value);
        }
        public abstract string CalculatorType { get; }
        public abstract int height { get; set; }
        public abstract int width { get; set; }
        public ICollection<CalculationModel> Calculations { get; protected set; }
        #endregion

        #region Constructors
        protected CalculatorViewModel(ICalculator calculator):base()
        {
            _calculator = calculator;
        }
        #endregion

        #region Delegates
        public DelegateCommand<string> AddNumberCommand { get; set; }
        public DelegateCommand ClearCommand { get; set; }
        public DelegateCommand EqualsCommand { get; set; }
        #endregion

        #region public/protected Methods
        protected override void RegisterCommands()
        {
            AddNumberCommand = new DelegateCommand<string>(AddNumber);
            ClearCommand = new DelegateCommand(Clear);
            EqualsCommand = new DelegateCommand(Calculate);
        }
        protected virtual void Calculate()
        {
            var value = _calculator.Calculate(Expression).ToString("N1");
            var calculation = new CalculationModel(Expression, value);
            Expression = value;
            hasCalculated = true;
            Calculations.Add(calculation);
        }
        protected virtual void AddNumber(string buttonValue)
        {
            if (hasCalculated)
            {
                Clear();
                hasCalculated = false;
            }
            Expression += buttonValue;
        }
        protected virtual void Clear()
        {
            Expression = string.Empty;
        }
        public override void RegisterCollections()
        {
            Calculations = new ObservableCollection<CalculationModel>();
        }
        #endregion
    }
}
