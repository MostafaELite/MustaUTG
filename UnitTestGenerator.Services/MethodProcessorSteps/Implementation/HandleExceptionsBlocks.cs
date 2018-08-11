using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestGenerator.Services.MethodProcessorSteps.Implementation
{
    class HandleExceptionsBlocks : Step
    {
        public HandleExceptionsBlocks(Step nextStep) : base(nextStep)
        {
        }

        protected override void DoWork(MethodInfo method)
        {
            var exceptionHandlingClauses = method.GetMethodBody()?.ExceptionHandlingClauses;
            if (exceptionHandlingClauses != null && exceptionHandlingClauses.Any())
            {
                foreach (var exception in exceptionHandlingClauses)
                    availableUnitTests.Add(new Domains.UnitTest { Name = $"{method.Name}_Throws_{exception.CatchType.Name}" });
            }
        }
    }
}
