using System;
using System.Collections.Generic;
using System.IO;
using UnitTestGenerator.Domains;
using UnitTestGenerator.Templates;

namespace UnitTestGenerator.Services
{
    public class TemplateService
    {
        public void Generate(TestingClass testingClass)
        {
            var template = new TestingClassTemplate(testingClass);
            testingClass.OutputLocation = testingClass.OutputLocation.Contains(".") ? testingClass.OutputLocation : testingClass.OutputLocation + testingClass.ClassName + "Testing";
            File.WriteAllText(testingClass.OutputLocation, template.TransformText());

        }
    }
}