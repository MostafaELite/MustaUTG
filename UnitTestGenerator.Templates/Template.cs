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
    public class Template
    {
        public string ClassName { get; set; }
        public List<UnitTest> UnitTests { get; set; }
        public static Template Get()
        {
            return new Template()
            {
                ClassName = "MyClass",
                UnitTests = new List<UnitTest>()
            {
                new UnitTest() { Name = "UnitTestName" },
                new UnitTest() { Name = "UnitTestName2" }
            }
            };
        }

        public static bool Generate(List<UnitTest> unitTests)
        {
            DefaultTemplate d = new DefaultTemplate();
            File.WriteAllText("GeneratedFile.cs",d.TransformText());
            return true;
        }





    }
}
