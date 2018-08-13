using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UnitTestGenerator.UI
{
    public partial class CodeEditor : Form
    {
        private MainForm _form;
       
        public CodeEditor(MainForm form)
        {
            this._form = form;
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();

        }

        private void CodeEditor_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            _form.InjectedCode = rtbCode.Text;
            Close();
        }
    }
}
