using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using UnitTestGenerator.Domains;

namespace UnitTestGenerator.Services.MethodProcessorSteps.Implementation
{
    public class HandleReturnType : Step
    {
        public HandleReturnType(Step nextStep) : base(nextStep)
        {
        }

        protected override void DoWork(MethodInfo method)
        {
            if (method.ReturnType != typeof(void))
            {
                availableUnitTests.Add(new UnitTest { Name = method.Name + "_Returns_WrongValue" });
                availableUnitTests.Add(new UnitTest { Name = method.Name + "_Returns_RightValue" });
            }
            else
            availableUnitTests.Add(new UnitTest { Name = method.Name + "_Doesn't_ThrowException" });
        }
    }
}
