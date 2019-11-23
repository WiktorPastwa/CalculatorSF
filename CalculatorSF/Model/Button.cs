using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorSF.Model
{
    public abstract class Button
    {
        #region Properties
        public string Label { get; }
        public string CommandParameter { get; }
        public int Order { get; }
        #endregion

        #region Constructors
        protected Button(string label, string commandParameter, int order)
        {
            Label = label;
            CommandParameter = commandParameter;
            Order = order;
        }
        #endregion
    }
}
