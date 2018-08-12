using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using UnitTestGenerator.Domains;

namespace UnitTestGenerator.Services.MethodProcessorSteps.Implementation
{
    public class HandleParameters : Step
    {
        private string _methodCall;
        private string _createdCode;
        public HandleParameters(Step nextStep) : base(nextStep)
        {
        }

        protected override void DoWork(MethodInfo method)
        {
            var _createdCode = new StringBuilder("");
            var _methodCall = new StringBuilder("(");
            var _paramters = new Dictionary<string, string>();

            foreach (var param in method.GetParameters())
            {
                if (!IsSimple(param.ParameterType))
                {
                    _createdCode.AppendLine($"var mocked_{param.Name} =  new Mock<{param.ParameterType.Name}>();");
                    _paramters.Add(param.Name, $" mocked_{param.Name}");
                }
                else
                    _paramters.Add(param.Name, $"It.Any<{param.ParameterType.Name}>()");
            }

            foreach (var paramToIgnore in _paramters)
            {
                var methodCallParameters = new StringBuilder($"(");
                foreach (var param in _paramters)
                    if (paramToIgnore.Key == param.Key)
                        methodCallParameters.Append("null,");
                    else
                        methodCallParameters.Append(param.Value + ",");

                methodCallParameters.Remove(_methodCall.Length - 1, 1);
                methodCallParameters.Append(')');

                var unitTest = new UnitTest()
                {
                    Name = $"{method.Name}_{paramToIgnore.Key}_Has_Wrong_Value",
                    CreatedCode = _createdCode.ToString(),
                    MethodCallParameters = methodCallParameters.ToString()
                };

                availableUnitTests.Add(unitTest);
            }
        }

        bool IsSimple(Type type)
        {
            if (type.IsGenericType && type.GetGenericTypeDefinition() == typeof(Nullable<>))
            {
                // nullable type, check if the nested type is simple.
                return IsSimple(type.GetGenericArguments()[0]);
            }
            return type.IsPrimitive
              || type.IsEnum
              || type.Equals(typeof(string))
              || type.Equals(typeof(decimal));
        }
    }
}

