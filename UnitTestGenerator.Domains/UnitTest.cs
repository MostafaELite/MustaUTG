using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestGenerator.Domains
{
    public class UnitTest
    {
        public string Name { get; set; }
        
        public bool MockObjects { get; set; }
        public bool InjectCode { get; set; }

        public string CreatedCode { get; set; }
        public string MethodCall { get; set; }
        public string MethodCallParameters { get; set; }
    }
}

