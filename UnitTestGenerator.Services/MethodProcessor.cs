using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using UnitTestGenerator.Domains;
using UnitTestGenerator.Services.MethodProcessorSteps.Implementation;

namespace UnitTestGenerator.Services
{
    public class MethodProcessor
    {        
        public List<UnitTest> ProcessMethod(MethodInfo method)
        {
            var handleExceptionsBlocks = new HandleExceptionsBlocks(null);
            var handleReturnType = new HandleReturnType(handleExceptionsBlocks);
            var handleParameters = new HandleParameters(handleReturnType);

            handleParameters.Process(method);
            var result = Step.availableUnitTests.ConvertAll(f => f);
            Step.availableUnitTests.Clear();
            return result;
        }
        
    }
}
