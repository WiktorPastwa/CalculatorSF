﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prism.Mvvm;

namespace CalculatorSF.ViewModels.Bases
{
    public abstract class ViewModelBase : BindableBase
    {
        protected ViewModelBase()
        {
            RegisterCommands();
        }

        protected virtual void RegisterCommands() { }
    }
}
