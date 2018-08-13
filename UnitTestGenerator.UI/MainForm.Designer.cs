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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.ofdAssembelyLocation = new System.Windows.Forms.OpenFileDialog();
            this.lbCalsses = new System.Windows.Forms.ListBox();
            this.lblAssembelyLocation = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnLoadAssembly = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.lvMethods = new System.Windows.Forms.ListView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnChangeOutputLocation = new System.Windows.Forms.Button();
            this.lblOutputLocation = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.sfdOutputLocation = new System.Windows.Forms.SaveFileDialog();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbCalsses
            // 
            this.lbCalsses.DisplayMember = "Name";
            this.lbCalsses.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCalsses.FormattingEnabled = true;
            this.lbCalsses.ItemHeight = 18;
            this.lbCalsses.Location = new System.Drawing.Point(12, 143);
            this.lbCalsses.Name = "lbCalsses";
            this.lbCalsses.Size = new System.Drawing.Size(143, 220);
            this.lbCalsses.TabIndex = 1;
            this.lbCalsses.SelectedIndexChanged += new System.EventHandler(this.lbClasses_SelectedIndexChanged);
            // 
            // lblAssembelyLocation
            // 
            this.lblAssembelyLocation.AutoSize = true;
            this.lblAssembelyLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAssembelyLocation.Location = new System.Drawing.Point(515, 28);
            this.lblAssembelyLocation.Name = "lblAssembelyLocation";
            this.lblAssembelyLocation.Size = new System.Drawing.Size(0, 16);
            this.lblAssembelyLocation.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Classes";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(241, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Select Methods";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(597, 642);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Unit Tests";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 678);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1260, 315);
            this.flowLayoutPanel1.TabIndex = 17;
            // 
            // btnLoadAssembly
            // 
            this.btnLoadAssembly.BackColor = System.Drawing.Color.Transparent;
            this.btnLoadAssembly.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLoadAssembly.BackgroundImage")));
            this.btnLoadAssembly.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLoadAssembly.FlatAppearance.BorderSize = 0;
            this.btnLoadAssembly.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoadAssembly.Location = new System.Drawing.Point(33, 8);
            this.btnLoadAssembly.Name = "btnLoadAssembly";
            this.btnLoadAssembly.Size = new System.Drawing.Size(62, 46);
            this.btnLoadAssembly.TabIndex = 21;
            this.btnLoadAssembly.UseVisualStyleBackColor = false;
            this.btnLoadAssembly.Click += new System.EventHandler(this.btnLoadAssembly_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(27, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "Load Assembly";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.CadetBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnGenerate);
            this.panel1.Controls.Add(this.btnLoadAssembly);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(-2, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1361, 75);
            this.panel1.TabIndex = 23;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(171, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Generate";
            // 
            // btnGenerate
            // 
            this.btnGenerate.BackColor = System.Drawing.Color.Transparent;
            this.btnGenerate.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGenerate.BackgroundImage")));
            this.btnGenerate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGenerate.FlatAppearance.BorderSize = 0;
            this.btnGenerate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerate.Location = new System.Drawing.Point(161, 0);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(65, 54);
            this.btnGenerate.TabIndex = 23;
            this.btnGenerate.UseVisualStyleBackColor = false;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // lvMethods
            // 
            this.lvMethods.CheckBoxes = true;
            this.lvMethods.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.lvMethods.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.lvMethods.Location = new System.Drawing.Point(171, 143);
            this.lvMethods.Name = "lvMethods";
            this.lvMethods.Size = new System.Drawing.Size(1102, 232);
            this.lvMethods.TabIndex = 24;
            this.lvMethods.UseCompatibleStateImageBehavior = false;
            this.lvMethods.View = System.Windows.Forms.View.List;
            this.lvMethods.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.lvMethods_ItemChecked);
            this.lvMethods.SelectedIndexChanged += new System.EventHandler(this.lvMethods_SelectedIndexChanged);
            this.lvMethods.Click += new System.EventHandler(this.lvMethods_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.btnChangeOutputLocation);
            this.groupBox1.Controls.Add(this.lblOutputLocation);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(12, 399);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1260, 229);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Configurations";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(16, 75);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(160, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Add Injeted Code";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnChangeOutputLocation
            // 
            this.btnChangeOutputLocation.Location = new System.Drawing.Point(16, 27);
            this.btnChangeOutputLocation.Name = "btnChangeOutputLocation";
            this.btnChangeOutputLocation.Size = new System.Drawing.Size(88, 23);
            this.btnChangeOutputLocation.TabIndex = 2;
            this.btnChangeOutputLocation.Text = "Change";
            this.btnChangeOutputLocation.UseVisualStyleBackColor = true;
            this.btnChangeOutputLocation.Click += new System.EventHandler(this.btnChangeOutputLocation_Click);
            // 
            // lblOutputLocation
            // 
            this.lblOutputLocation.AutoSize = true;
            this.lblOutputLocation.Location = new System.Drawing.Point(195, 32);
            this.lblOutputLocation.Name = "lblOutputLocation";
            this.lblOutputLocation.Size = new System.Drawing.Size(16, 13);
            this.lblOutputLocation.TabIndex = 1;
            this.lblOutputLocation.Text = "...";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(121, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Output To";
            // 
            // sfdOutputLocation
            // 
            this.sfdOutputLocation.Filter = "|.cs";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 1005);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lvMethods);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblAssembelyLocation);
            this.Controls.Add(this.lbCalsses);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MustaUTG";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog ofdAssembelyLocation;
        private System.Windows.Forms.ListBox lbCalsses;
        private System.Windows.Forms.Label lblAssembelyLocation;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnLoadAssembly;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListView lvMethods;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblOutputLocation;
        private System.Windows.Forms.Button btnChangeOutputLocation;
        private System.Windows.Forms.SaveFileDialog sfdOutputLocation;
        private System.Windows.Forms.Button button1;
    }
}

