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
        private List<Type> _currentAssemblyTypes;
        private List<MethodInfo> _currentTypeMethods;
        private MethodInfo _selectedMethod;

        public IEnumerable<string> LoadAssembely(string assemlebyLocation)
        {   
            _currentAssembly = Assembly.LoadFrom(assemlebyLocation);
            _currentAssemblyTypes = _currentAssembly.GetTypes().ToList();
            return _currentAssemblyTypes.Select(type=>type.Name);
        }
        private IEnumerable<UnitTest> GetUnitTests(MethodInfo methodInfo, object dataSource, string injectedCode)
        {
            var dataTable = dataSource as DataTable;
            foreach (DataRow row in dataTable.Rows)
                yield return new UnitTest { Name = row["Name"].ToString(), InjectedCode = injectedCode, MockObjects = (bool)row["MockObjects"] };
        }

        public bool Generate(MethodInfo methodInfo, object dataSource, string injectedCode)
        {
            var unitTests = GetUnitTests(methodInfo, dataSource, injectedCode).ToList();
            return new GenerateTestClass().Generate(unitTests);
        }
    }
}
