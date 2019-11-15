using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalculatorSF.Core.Calculations;
using CalculatorSF.Model;
using CalculatorSF.ViewModels.Interfaces;

namespace CalculatorSF.ViewModels.Bases
{
    public abstract class CalculatorViewModel : ViewModelBase, ICalculatorViewModel
    {
        public abstract string CalculatorType { get; }
    
        public ICollection<CalculationModel> Calculations { get; }
    }
}
