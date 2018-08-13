using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestGenerator.Domains
{
    public class TestingClass
    {
        public string ClassName { get; set; }
        public string MockedObjects { get; set; }
        public string InjectedCode { get; set; }
        public string OutputLocation { get; set; }


        public List<UnitTest> UnitTests { get; set; }
    }
}
