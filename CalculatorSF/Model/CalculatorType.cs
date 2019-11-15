using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorSF.Model
{
    public class CalculatorType
    {
        public CalculatorType(string displayName, string typeName)
        {
            DisplayName = displayName;
            TypeName = typeName;
        }

        public string DisplayName { get;}
        public string TypeName { get;}

        public static CalculatorType Create(string displayName, string typeName)
        {
            return  new CalculatorType(displayName, typeName);
        }
    }
}
