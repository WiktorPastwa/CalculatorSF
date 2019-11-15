using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorSF.Model
{
    public class SuperScriptButton : Button
    {
        public string SuperScript { get; }

        public SuperScriptButton(string label, string commandParameter, string superScriptLabel, int order) : base(label, commandParameter, order)
        {
            SuperScript = superScriptLabel;
        }

        public static SuperScriptButton Create(string label, string commandParameter, string superScriptLabel, int order)
        {
            return new SuperScriptButton(label, commandParameter, superScriptLabel, order);
        }
    }
}
