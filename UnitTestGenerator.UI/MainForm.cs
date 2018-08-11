using System;
using System.Collections.Generic;
using System.ComponentModel;

using System.Linq;
using System.Reflection;
using System.Windows.Forms;

using UnitTestGenerator.Application;

namespace UnitTestGenerator.UI
{
    public partial class MainForm : Form
    {

        MainFormOpreations mainFormOpreation = new MainFormOpreations();

        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
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
            lbMethods.Items.Clear();
            var methods = mainFormOpreation.GetClassMethods(lbCalsses.SelectedItem as Type);
            lbMethods.Items.AddRange(methods);
        }

        private void lbMethods_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            dataGridView1.Rows.Clear();
            var avaliableUnitTestsNames = mainFormOpreation.GetAvailableUnitTests(lbMethods.SelectedItem);
            avaliableUnitTestsNames.ForEach(name => dataGridView1.Rows.Add(new[] { Name = name }));
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
            string injectedCode;
            string mockedObjects = "";
            //if (cbMockAllParamters.Checked)
            //{
            //    var parameters = _selectedMethod.GetParameters();
            //    foreach (var param in parameters)
            //        if (IsComplex(param.ParameterType))
            //            mockedObjects += $"var mocked{param.Name}= new Mock<{param.ParameterType.Name}>();" + Environment.NewLine;
            //}

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
    }
}

