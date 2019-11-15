using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalculatorSF.Model;

namespace CalculatorSF.ViewModels.Interfaces
{
    public interface ICalculatorViewModel
    {
        string CalculatorType { get;}

        ICollection<CalculationModel> Calculations { get; }
    }
}
