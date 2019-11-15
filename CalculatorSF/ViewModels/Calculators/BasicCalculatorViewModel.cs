﻿using System;
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
        public BasicCalculatorViewModel(ICalculator calculator):base(calculator)
        {
            
        }

        public override string CalculatorType => "Basic";
    }
}
