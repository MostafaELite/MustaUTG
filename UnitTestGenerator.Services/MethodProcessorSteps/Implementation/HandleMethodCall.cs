using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestGenerator.Services.MethodProcessorSteps.Implementation
{
    public class HandleMethodCall : Step
    {
        public HandleMethodCall(Step nextStep) : base(nextStep)
        {
        }

        protected override void DoWork(MethodInfo method)
        {
            var methodUniTests = availableUnitTests.Where(ut => ut.Method.Name == method.Name).ToList();
            var resultVariable = method.ReturnType == typeof(void) ? "" : "var result =";
            if (method.IsStatic)
            {
                methodUniTests.ForEach(unitTest => unitTest.MethodCall = $"{resultVariable} {method.DeclaringType.Name}.{method.Name}{unitTest.MethodCallParameters}");
            }


            else
            {
                var methodClassObject = $"var obj = new {method.DeclaringType.Name}();{Environment.NewLine}";
                methodUniTests.ForEach(unitTest => unitTest.MethodCall = $"{methodClassObject}{resultVariable} obj.{method.Name}{unitTest.MethodCallParameters}");
            }

        }
    }
}
