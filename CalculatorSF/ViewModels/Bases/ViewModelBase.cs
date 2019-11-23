using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prism.Mvvm;

namespace CalculatorSF.ViewModels.Bases
{
    public abstract class ViewModelBase : BindableBase
    {
        #region Constructors
        protected ViewModelBase()
        {
            RegisterCommands();
            RegisterCollections();
        }
        #endregion

        #region public/protected Methods
        protected virtual void RegisterCommands() { }
        public virtual void RegisterCollections() { }
        #endregion
    }
}
