using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
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
        public DelegateCommand DeleteCharacterCommand { get; set; }
        public DelegateCommand EqualsCommand { get; set; }
        public DelegateCommand<string> TrigonometricCommand { get; set; }
        public DelegateCommand PowerOfNumberCommand { get; set; }
        public DelegateCommand PowerOfNumber2Command { get; set; }
        #endregion

        #region private Methods
        private bool CheckIfWindowIsNotEmpty()
        {
            bool isNotEmpty = (Expression?.Length > 0);
            return isNotEmpty;
        }
        #endregion

        #region public/protected Methods
        protected override void RegisterCommands()
        {
            AddNumberCommand = new DelegateCommand<string>(AddNumber);
            ClearCommand = new DelegateCommand(Clear);
            DeleteCharacterCommand = new DelegateCommand(DeleteCharacter);
            EqualsCommand = new DelegateCommand(Calculate);
            TrigonometricCommand = new DelegateCommand<string>(CalculateTrigonometric);
            PowerOfNumberCommand = new DelegateCommand(PowerOfNumber);
            PowerOfNumber2Command = new DelegateCommand(PowerOfNumber2);
        }
        protected virtual void Calculate()
        {
            if (CheckIfWindowIsNotEmpty())
            {
                var value = _calculator.Calculate(Expression).ToString("N1");
                var calculation = new CalculationModel(Expression, value);
                Expression = value;
                hasCalculated = true;
                Calculations.Add(calculation);
            }
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
        protected virtual void CalculateTrigonometric(string buttonValue)
        {
            Expression = buttonValue + "(" + Expression + ")";
        }
        protected virtual void PowerOfNumber()
        {
            Expression += "^";
        }
        protected virtual void PowerOfNumber2()
        {
            Expression += "^2";
        }
        protected virtual void Clear()
        {
            Expression = string.Empty;
        }
        protected virtual void DeleteCharacter()
        {
            if(CheckIfWindowIsNotEmpty())
                Expression = Expression?.Remove(Expression.Length - 1);
        }
        public override void RegisterCollections()
        {
            Calculations = new ObservableCollection<CalculationModel>();
        }
        #endregion
    }
}
