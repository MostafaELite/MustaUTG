namespace UnitTestGenerator.UI
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ofdAssembelyLocation = new System.Windows.Forms.OpenFileDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.lbCalsses = new System.Windows.Forms.ListBox();
            this.lbMethods = new System.Windows.Forms.ListBox();
            this.rtbMethodBody = new System.Windows.Forms.RichTextBox();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.lblAssembelyLocation = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbMockAllParamters = new System.Windows.Forms.CheckBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.colTestMethodName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMockParameters = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colAddInjectedCode = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(518, 47);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Load Assembely";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbCalsses
            // 
            this.lbCalsses.FormattingEnabled = true;
            this.lbCalsses.Location = new System.Drawing.Point(29, 118);
            this.lbCalsses.Name = "lbCalsses";
            this.lbCalsses.Size = new System.Drawing.Size(209, 251);
            this.lbCalsses.TabIndex = 1;
            this.lbCalsses.SelectedIndexChanged += new System.EventHandler(this.lbClasses_SelectedIndexChanged);
            // 
            // lbMethods
            // 
            this.lbMethods.FormattingEnabled = true;
            this.lbMethods.Location = new System.Drawing.Point(273, 118);
            this.lbMethods.Name = "lbMethods";
            this.lbMethods.Size = new System.Drawing.Size(209, 251);
            this.lbMethods.TabIndex = 2;
            this.lbMethods.SelectedIndexChanged += new System.EventHandler(this.lbMethods_SelectedIndexChanged);
            // 
            // rtbMethodBody
            // 
            this.rtbMethodBody.Location = new System.Drawing.Point(29, 604);
            this.rtbMethodBody.Name = "rtbMethodBody";
            this.rtbMethodBody.Size = new System.Drawing.Size(1095, 167);
            this.rtbMethodBody.TabIndex = 4;
            this.rtbMethodBody.Text = "";
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(478, 779);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(205, 23);
            this.btnGenerate.TabIndex = 5;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // lblAssembelyLocation
            // 
            this.lblAssembelyLocation.AutoSize = true;
            this.lblAssembelyLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAssembelyLocation.Location = new System.Drawing.Point(88, 9);
            this.lblAssembelyLocation.Name = "lblAssembelyLocation";
            this.lblAssembelyLocation.Size = new System.Drawing.Size(0, 16);
            this.lblAssembelyLocation.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(88, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Classes";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(334, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Methods";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(601, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Unit Tests";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(25, 569);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(163, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "Enter Code To Inject :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbMockAllParamters);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.groupBox1.Location = new System.Drawing.Point(38, 394);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1086, 142);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Generation Configuration";
            // 
            // cbMockAllParamters
            // 
            this.cbMockAllParamters.AutoSize = true;
            this.cbMockAllParamters.Location = new System.Drawing.Point(30, 39);
            this.cbMockAllParamters.Name = "cbMockAllParamters";
            this.cbMockAllParamters.Size = new System.Drawing.Size(173, 24);
            this.cbMockAllParamters.TabIndex = 0;
            this.cbMockAllParamters.Text = "Mock All Parameters";
            this.cbMockAllParamters.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeight = 50;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colTestMethodName,
            this.colMockParameters,
            this.colAddInjectedCode});
            this.dataGridView1.GridColor = System.Drawing.Color.Teal;
            this.dataGridView1.Location = new System.Drawing.Point(501, 118);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 90;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.Size = new System.Drawing.Size(636, 251);
            this.dataGridView1.TabIndex = 15;
            // 
            // colTestMethodName
            // 
            this.colTestMethodName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colTestMethodName.DefaultCellStyle = dataGridViewCellStyle2;
            this.colTestMethodName.FillWeight = 120F;
            this.colTestMethodName.Frozen = true;
            this.colTestMethodName.HeaderText = "Test Method Name";
            this.colTestMethodName.MinimumWidth = 350;
            this.colTestMethodName.Name = "colTestMethodName";
            this.colTestMethodName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colTestMethodName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colTestMethodName.Width = 350;
            // 
            // colMockParameters
            // 
            this.colMockParameters.HeaderText = "Mock Parameters";
            this.colMockParameters.MinimumWidth = 150;
            this.colMockParameters.Name = "colMockParameters";
            this.colMockParameters.Width = 150;
            // 
            // colAddInjectedCode
            // 
            this.colAddInjectedCode.HeaderText = "AddInjectedCode";
            this.colAddInjectedCode.Name = "colAddInjectedCode";
            this.colAddInjectedCode.Width = 139;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1160, 750);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblAssembelyLocation);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.rtbMethodBody);
            this.Controls.Add(this.lbMethods);
            this.Controls.Add(this.lbCalsses);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog ofdAssembelyLocation;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox lbCalsses;
        private System.Windows.Forms.ListBox lbMethods;
        private System.Windows.Forms.RichTextBox rtbMethodBody;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Label lblAssembelyLocation;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox cbMockAllParamters;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTestMethodName;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colMockParameters;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colAddInjectedCode;
    }
}

