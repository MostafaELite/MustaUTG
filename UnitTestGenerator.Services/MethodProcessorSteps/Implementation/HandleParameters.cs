using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestGenerator.Services.MethodProcessorSteps.Implementation
{
    public class HandleParameters : Step
    {
        public HandleParameters(Step nextStep) : base(nextStep)
        {
        }

        protected override void DoWork(MethodInfo method)
        {
            foreach (var param in method.GetParameters())
            {
                availableUnitTests.Add(new Domains.UnitTest() { Name= $"{method.Name}_Parameter_{param.Name}_Has_Wrong_Value" });
                availableUnitTests.Add(new Domains.UnitTest() { Name = $"{method.Name}__Parameter_{param.Name}_Has_Right_Value" });
            }
        }
    }
}
