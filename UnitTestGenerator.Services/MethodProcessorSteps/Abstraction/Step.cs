using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using UnitTestGenerator.Domains;

namespace UnitTestGenerator.Services
{
    public abstract class Step
    {
        public static List<UnitTest> availableUnitTests = new List<UnitTest>();

        private Step _nextStep;
        protected Step(Step nextStep)
        {
            _nextStep = nextStep;
        }

        protected abstract void DoWork(MethodInfo method);
        
        public void Process(MethodInfo method)
        {
            DoWork(method);
            _nextStep?.Process(method);
        }
    }
}
