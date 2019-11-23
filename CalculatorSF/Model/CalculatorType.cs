using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorSF.Model
{
    public class CalculatorType
    {
        #region Properties
        public string DisplayName { get; }
        public string TypeName { get; }
        #endregion

        #region Constructors
        public CalculatorType(string displayName, string typeName)
        {
            DisplayName = displayName;
            TypeName = typeName;
        }
        #endregion

        #region public/protected Methods
        public static CalculatorType Create(string displayName, string typeName)
        {
            return  new CalculatorType(displayName, typeName);
        }
        #endregion
    }
}
