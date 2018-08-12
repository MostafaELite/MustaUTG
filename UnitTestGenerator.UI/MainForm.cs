using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using UnitTestGenerator.Application;
using UnitTestGenerator.Domains;

namespace UnitTestGenerator.UI
{
    public partial class MainForm : Form
    {

        MainFormOpreations mainFormOpreation = new MainFormOpreations();

        public MainForm()
        {
            InitializeComponent();
        }

        private void btnLoadAssembly_Click(object sender, EventArgs e)
        {
            if (ofdAssembelyLocation.ShowDialog() == DialogResult.OK)
            {
                lbCalsses.Items.Clear();
                var classes = mainFormOpreation.LoadAssembely(ofdAssembelyLocation.FileName, false);
                lbCalsses.Items.AddRange(classes.ToArray());
                lblAssembelyLocation.Text = ofdAssembelyLocation.SafeFileName;
            }

        }

        private void lbClasses_SelectedIndexChanged(object sender, EventArgs e)
        {
            lvMethods.Items.Clear();
            var methods = mainFormOpreation.GetClassMethods(lbCalsses.SelectedItem as Type);

            lvMethods.Items.AddRange(methods.ToArray());
        }

        private void clbMethods_SelectedIndexChanged(object sender, EventArgs e)
        {
            var unitTests = mainFormOpreation.GetUnitTestsPanels(lvMethods.SelectedItems).ToArray();
            flowLayoutPanel1.Controls.AddRange(mainFormOpreation.GetUnitTestsPanels(lvMethods.SelectedItems).ToArray());

            //dataGridView1.Rows.Clear();
            //var avaliableUnitTestsNames = mainFormOpreation.GetAvailableUnitTests(clbMethods.SelectedItem);
            //avaliableUnitTestsNames.ForEach(name => dataGridView1.Rows.Add(new[] { Name = name }));
            //if (selectedMethodInfo.ReturnType != typeof(void))
            //{
            //    var row = new DataGridViewRow();
            //    dataGridView1.Rows.Add(new object[] { selectedMethodInfo.Name + "_Returns_Wrong_Value", false, false });
            //    dataGridView1.Rows.Add(new object[] { selectedMethodInfo.Name + "_Returns_RightValue", false, false });
            //}
            //var selectedMethodBody = selectedMethodInfo.GetMethodBody();

            //selectedMethodBody?.ExceptionHandlingClauses.ToList().ForEach(
            //    ex => { dataGridView1.Rows.Add(new object[] { selectedMethodInfo.Name + "_Throws_" + ex.CatchType.Name, false, false }); });






            //panel.Width = flowLayoutPanel1.Width;
            //panel.Controls.Add(new Label { Text = selectedMethodInfo.Name , TextAlign = System.Drawing.ContentAlignment.MiddleCenter });
            //panel.Controls.Add(new CheckBox { Name = selectedMethodInfo.Name , Text="Mock Parameters" , TextAlign=System.Drawing.ContentAlignment.MiddleCenter });
            //panel.Controls.Add(new CheckBox { Name = selectedMethodInfo.Name, Text = "Add Injected Code", TextAlign = System.Drawing.ContentAlignment.MiddleCenter });


            //flowLayoutPanel1.Controls.Clear();
            //flowLayoutPanel1.Controls.Add(panel);


            //var selectedMethodBody = selectedMethodInfo.GetMethodBody();
            //var selectedMethodReturnType = _selectedMethod.ReturnParameter;



            //clbCodeInjected.Items.Clear();
            //clbCodeInjected.Items.AddRange(clbUnitTests.Items);

        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            var selectedUnitTests = new List<UnitTest>();
            
            foreach (TableLayoutPanel tablePanel in flowLayoutPanel1.Controls)
                foreach (Control control in tablePanel.Controls)
                    if (control is CheckBox && ((CheckBox)control).CheckState == CheckState.Checked && control.Name.Contains("_AddUnitTest"))
                    {
                        var injectCode = control.Parent.Controls.Where(c => c.Name.Contains("InjectCode")) as CheckBox;
                        var mockParameters = control.Parent.Controls.Where(c => c.Name.Contains("MockAll")) as CheckBox;
                        var unitTest = tablePanel.Tag as UnitTest;
                        unitTest.InjectCode = injectCode.Checked;
                        unitTest.InjectCode = mockParameters.Checked;
                        selectedUnitTests.Add(unitTest);
                    }

            var testingClass = new TestingClass() { InjectedCode = "asdad", UnitTests = selectedUnitTests };
            mainFormOpreation.Generate(testingClass);

            //Application.MainFormOpreations formApplication = new Application.MainFormOpreations();
            //if (formApplication.Generate())
            //    MessageBox.Show("Generated");



        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        public static bool IsComplex(Type typeIn)
        {
            if (typeIn.IsSubclassOf(typeof(System.ValueType)) || typeIn.Equals(typeof(string))) //|| typeIn.IsPrimitive
                return false;
            return true;

        }

        private void lbUnitTests_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lvMethods_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void lvMethods_Click(object sender, EventArgs e)
        {
            //flowLayoutPanel1.Controls.Clear();
            //var unitTests = mainFormOpreation.GetUnitTestsPanels(lvMethods.SelectedItems).ToArray();
            //flowLayoutPanel1.Controls.AddRange(mainFormOpreation.GetUnitTestsPanels(lvMethods.SelectedItems).ToArray());
        }

        private void lvMethods_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            var unitTests = mainFormOpreation.GetUnitTestsPanels(lvMethods.CheckedItems).ToArray();
            flowLayoutPanel1.Controls.AddRange(mainFormOpreation.GetUnitTestsPanels(lvMethods.CheckedItems).ToArray());
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

