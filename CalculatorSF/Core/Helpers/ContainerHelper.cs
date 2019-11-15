using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Unity;

namespace CalculatorSF.Core.Helpers
{
    public class ContainerHelper : IContainerHelper
    {
        private readonly IUnityContainer _container;

        public ContainerHelper(IUnityContainer container)
        {
            _container = container;
        }

        public object Create(string typeName)
        {
            var type = Assembly.GetExecutingAssembly().GetTypes().SingleOrDefault(x => x.Name == typeName);
            if (type == null)
                throw new InvalidOperationException("The typeName doesn't match anything");

            return _container.Resolve(type);
        }
    }
}
