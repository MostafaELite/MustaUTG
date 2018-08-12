using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using UnitTestGenerator.Domains;
using UnitTestGenerator.Services;
using static System.Windows.Forms.ListView;

namespace UnitTestGenerator.Application
{
    public class MainFormOpreations
    {
        private Assembly _currentAssembly;
        private TemplateService templateService;
        public MainFormOpreations()
        {
            templateService = new TemplateService();
        }


        public List<Type> LoadAssembely(string assemlebyLocation, bool f)
        {
            _currentAssembly = Assembly.LoadFrom(assemlebyLocation);
            return _currentAssembly.GetTypes().ToList();
        }

        public IEnumerable<ListViewItem> GetClassMethods(Type type)
        {
            foreach (var method in type.GetMethods())
                if (method.DeclaringType != typeof(object))
                    yield return new ListViewItem() { Text = method.ToString(), Name = method.Name, Tag = method };


        }

        //private IEnumerable<UnitTest> GetUnitTests(MethodInfo methodInfo, object dataSource, string injectedCode)
        //{
        //    var dataTable = dataSource as DataTable;
        //    foreach (DataRow row in dataTable.Rows)
        //        yield return new UnitTest { Name = row["Name"].ToString(), InjectedCode = injectedCode, MockObjects = (bool)row["MockObjects"] };
        //}

        private List<UnitTest> GetAvailableUnitTestsNames(object selectedItem)
        {
            var availableUnitTestsNames = new List<UnitTest>();
            var castedSeletedItems = selectedItem as CheckedListViewItemCollection;
            foreach (ListViewItem item in castedSeletedItems)
            {
                var processor = new MethodProcessor();                
                availableUnitTestsNames.AddRange(processor.ProcessMethod(item.Tag as MethodInfo));
            }
            return availableUnitTestsNames;
        }

        public IEnumerable<Control> GetUnitTestsPanels(object selectedItems)
        {
            var availableUnitTestNames = GetAvailableUnitTestsNames(selectedItems);
            foreach (var unitTest in availableUnitTestNames)
            {
                var labelUnitTest = new Label()
                {
                    Text = unitTest.Name,
                    TextAlign = System.Drawing.ContentAlignment.MiddleLeft,
                    Font = new System.Drawing.Font("SanSeirf", 12),
                    Width = 400
                };
                var chkUnitTest = new CheckBox()
                {
                    Name = unitTest.Name + "_AddUnitTest",
                    Text = "Add Unit Test",
                    TextAlign = System.Drawing.ContentAlignment.MiddleCenter,
                    AutoSize = false,
                    Anchor = AnchorStyles.None,
                    Font = new System.Drawing.Font("SanSeirf", 9),

                };
                var chkInjectCode = new CheckBox()
                {
                    Name = unitTest.Name + "_InjectCode",
                    Text = "Inject Code",
                    AutoSize = false,
                    Anchor = AnchorStyles.None,
                    Font = new System.Drawing.Font("SanSeirf", 9)
                };
                var chkMockAllParamters = new CheckBox()
                {
                    Name = unitTest.Name + "_MockAllParameters",
                    Text = "Mock All Parameters",
                    AutoSize = false,
                    Anchor = AnchorStyles.None,
                    Font = new System.Drawing.Font("SanSeirf", 9)
                };

                RowStyle r = new RowStyle() { };
                var unitTestPanel = new TableLayoutPanel() { BorderStyle = BorderStyle.Fixed3D, BackColor = System.Drawing.Color.BlanchedAlmond, Width = 400,Tag= unitTest };
                unitTestPanel.ColumnCount = 1;
                unitTestPanel.RowCount = 1;


                unitTestPanel.Controls.Add(labelUnitTest);


                unitTestPanel.ColumnCount = 3;
                unitTestPanel.RowCount = 2;
                unitTestPanel.Controls.Add(chkUnitTest);
                unitTestPanel.Controls.Add(chkInjectCode);
                unitTestPanel.Controls.Add(chkMockAllParamters);

                unitTestPanel.SetColumnSpan(labelUnitTest, 3);
                yield return unitTestPanel;
            }
        }

        public void Generate(TestingClass testingClass)
        {
            templateService.Generate(testingClass);
        }
    }
}
