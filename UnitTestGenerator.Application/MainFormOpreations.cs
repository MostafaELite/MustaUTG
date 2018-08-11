using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using UnitTestGenerator.Domains;
using UnitTestGenerator.Services;

namespace UnitTestGenerator.Application
{
    public class MainFormOpreations
    {
        private Assembly _currentAssembly;  

        public List<Type> LoadAssembely(string assemlebyLocation, bool f)
        {
            _currentAssembly = Assembly.LoadFrom(assemlebyLocation);
            return _currentAssembly.GetTypes().ToList();
        }

        public MethodInfo[] GetClassMethods(Type type)
        {
            return type.GetMethods();
        }

        private IEnumerable<UnitTest> GetUnitTests(MethodInfo methodInfo, object dataSource, string injectedCode)
        {
            var dataTable = dataSource as DataTable;
            foreach (DataRow row in dataTable.Rows)
                yield return new UnitTest { Name = row["Name"].ToString(), InjectedCode = injectedCode, MockObjects = (bool)row["MockObjects"] };
        }

        //public bool Generate(object methodInfo, object dataSource, string injectedCode)
        //{
        //    var unitTests = GetUnitTests(methodInfo as MethodInfo, dataSource, injectedCode).ToList();
        //    return new GenerateTestClass().Generate(unitTests);
        //}

        public List<string> GetAvailableUnitTests(object selectedItem)
        {
            var processor = new MethodProcessor();
            return processor.ProcessMethod(selectedItem as MethodInfo);
        }
    }
}
