using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalculatorSF.Core.Calculations;
using Unity;

namespace CalculatorSF.App_Start
{
    public static class UnityConfig
    {
        public static IUnityContainer RegisterInstances(this IUnityContainer container)
        {
            container.RegisterType<ICalculator, ExpressionCalculator>();
            return container;
        }
    }
}
