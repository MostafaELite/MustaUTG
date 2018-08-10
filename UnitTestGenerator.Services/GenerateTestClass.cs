using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTestGenerator.Domains;
using UnitTestGenerator.Templates;

namespace UnitTestGenerator.Services
{
    public class GenerateTestClass
    {
        public bool Generate(List<UnitTest> unitTests)
        {
            DefaultTemplate template = new DefaultTemplate();
            template.TransformText();
            return true;
        }
        
    }
}
