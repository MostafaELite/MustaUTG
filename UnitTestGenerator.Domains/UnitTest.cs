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
        public string MockedObjects { get; set; }
        public string InjectedCode { get; set; }
        public bool MockObjects { get; set; }
    }
}
