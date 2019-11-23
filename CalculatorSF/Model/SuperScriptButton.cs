using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorSF.Model
{
    public class SuperScriptButton : Button
    {
        #region Properties
        public string SuperScript { get; }
        #endregion

        #region Constructors
        public SuperScriptButton(string label, string commandParameter, string superScriptLabel, int order) : base(label, commandParameter, order)
        {
            SuperScript = superScriptLabel;
        }
        #endregion

        #region public/protected Methods
        public static SuperScriptButton Create(string label, string commandParameter, string superScriptLabel, int order)
        {
            return new SuperScriptButton(label, commandParameter, superScriptLabel, order);
        }
        #endregion
    }
}
