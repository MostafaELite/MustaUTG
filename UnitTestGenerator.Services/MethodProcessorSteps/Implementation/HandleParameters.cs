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
        //private string _methodCall;
        //private string _createdCode;
        public HandleParameters(Step nextStep) : base(nextStep)
        {
        }

        protected override void DoWork(MethodInfo method)
        {
            var createdCode = new StringBuilder("");
            var methodCall = new StringBuilder("(");
            var paramters = new Dictionary<string, string>();

            foreach (var param in method.GetParameters())
            {
                if (!IsSimple(param.ParameterType))
                {
                    createdCode.AppendLine($"var mocked_{param.Name} =  new Mock<{param.ParameterType.Name}>();");
                    paramters.Add(param.Name, $" mocked_{param.Name}");
                }
                else
                    paramters.Add(param.Name, $"It.Any<{param.ParameterType.Name}>()");
            }

            foreach (var paramToIgnore in paramters)
            {
                var methodCallParameters = new StringBuilder();
                foreach (var param in paramters)
                {
                    if (paramToIgnore.Key == param.Key)
                        methodCallParameters.Append("null,");
                    else
                        methodCallParameters.Append(param.Value + ",");
                }

                methodCallParameters.Insert(0, "(", 1);
                methodCallParameters.Remove(methodCallParameters.Length - 1, 1);
                methodCallParameters.Append(");");


                var unitTest = new UnitTest()
                {
                    Name = $"{method.Name}_{paramToIgnore.Key}_Has_Wrong_Value",
                    CreatedCode = string.IsNullOrEmpty(createdCode.ToString()) ? "" : createdCode.ToString(),
                    MethodCallParameters = methodCallParameters.ToString(),
                    Method = method
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

