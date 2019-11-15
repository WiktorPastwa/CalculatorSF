using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalculatorSF.Core.Calculations;
using CalculatorSF.Core.Helpers;
using Unity;
using Unity.Lifetime;

namespace CalculatorSF.App_Start
{
    public static class UnityConfig
    {
        public static IUnityContainer RegisterInstances(this IUnityContainer container)
        {
            container.RegisterType<ICalculator, ExpressionCalculator>();
            return container;
        }

        public static IUnityContainer RegisterSingletons(this IUnityContainer container)
        {
            container.RegisterType<IContainerHelper, ContainerHelper>(new ContainerControlledLifetimeManager());
            return container;
        }
    }
}
