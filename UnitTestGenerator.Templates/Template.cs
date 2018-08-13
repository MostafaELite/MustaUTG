using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTestGenerator.Domains;
using UnitTestGenerator.Templates;


namespace UnitTestGenerator.Templates
{
    public partial class TestingClassTemplate
    {
        public TestingClass _testingClass { get; set; }

        public TestingClassTemplate(TestingClass testingClass)
        {
            _testingClass = testingClass;
        }

        public static bool Generate(List<UnitTest> unitTests)
        {
            //DefaultTemplate d = new DefaultTemplate();
            //File.WriteAllText("GeneratedFile.cs",d.TransformText());
            return true;
        }





    }
}
