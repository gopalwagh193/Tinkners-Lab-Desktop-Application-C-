namespace abc
{
    partial class LabUtilization
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tdesc = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cdevice = new System.Windows.Forms.ComboBox();
            this.bdelete = new System.Windows.Forms.Button();
            this.bexit = new System.Windows.Forms.Button();
            this.bmodify = new System.Windows.Forms.Button();
            this.bsave = new System.Windows.Forms.Button();
            this.badd = new System.Windows.Forms.Button();
            this.dexittime = new System.Windows.Forms.DateTimePicker();
            this.dentrytime = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.tname = new System.Windows.Forms.TextBox();
            this.tsno = new System.Windows.Forms.TextBox();
            this.cdept = new System.Windows.Forms.ComboBox();
            this.cclass = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lname = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Red;
            this.label1.Font = new System.Drawing.Font("Corbel", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, -1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1033, 60);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lab Utilization";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Black;
            this.groupBox1.Controls.Add(this.tdesc);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.cdevice);
            this.groupBox1.Controls.Add(this.bdelete);
            this.groupBox1.Controls.Add(this.bexit);
            this.groupBox1.Controls.Add(this.bmodify);
            this.groupBox1.Controls.Add(this.bsave);
            this.groupBox1.Controls.Add(this.badd);
            this.groupBox1.Controls.Add(this.dexittime);
            this.groupBox1.Controls.Add(this.dentrytime);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.tname);
            this.groupBox1.Controls.Add(this.tsno);
            this.groupBox1.Controls.Add(this.cdept);
            this.groupBox1.Controls.Add(this.cclass);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(12, 99);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(662, 440);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // tdesc
            // 
            this.tdesc.Location = new System.Drawing.Point(487, 44);
            this.tdesc.Multiline = true;
            this.tdesc.Name = "tdesc";
            this.tdesc.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tdesc.Size = new System.Drawing.Size(160, 63);
            this.tdesc.TabIndex = 24;
            this.tdesc.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tdesc_KeyDown);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(354, 60);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(112, 20);
            this.label10.TabIndex = 23;
            this.label10.Text = "Description:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(35, 277);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 20);
            this.label9.TabIndex = 22;
            this.label9.Text = "Device:";
            // 
            // cdevice
            // 
            this.cdevice.FormattingEnabled = true;
            this.cdevice.Location = new System.Drawing.Point(163, 277);
            this.cdevice.Name = "cdevice";
            this.cdevice.Size = new System.Drawing.Size(139, 24);
            this.cdevice.TabIndex = 21;
            this.cdevice.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cdevice_KeyDown);
            // 
            // bdelete
            // 
            this.bdelete.BackColor = System.Drawing.Color.Maroon;
            this.bdelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bdelete.Location = new System.Drawing.Point(416, 374);
            this.bdelete.Name = "bdelete";
            this.bdelete.Size = new System.Drawing.Size(108, 49);
            this.bdelete.TabIndex = 20;
            this.bdelete.Text = "Delete";
            this.bdelete.UseVisualStyleBackColor = false;
            this.bdelete.Click += new System.EventHandler(this.bdelete_Click);
            // 
            // bexit
            // 
            this.bexit.BackColor = System.Drawing.Color.Maroon;
            this.bexit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bexit.Location = new System.Drawing.Point(542, 373);
            this.bexit.Name = "bexit";
            this.bexit.Size = new System.Drawing.Size(114, 50);
            this.bexit.TabIndex = 19;
            this.bexit.Text = "Exit";
            this.bexit.UseVisualStyleBackColor = false;
            this.bexit.Click += new System.EventHandler(this.bexit_Click);
            // 
            // bmodify
            // 
            this.bmodify.BackColor = System.Drawing.Color.Maroon;
            this.bmodify.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bmodify.Location = new System.Drawing.Point(282, 374);
            this.bmodify.Name = "bmodify";
            this.bmodify.Size = new System.Drawing.Size(118, 51);
            this.bmodify.TabIndex = 18;
            this.bmodify.Text = "Update";
            this.bmodify.UseVisualStyleBackColor = false;
            this.bmodify.Click += new System.EventHandler(this.bmodify_Click);
            // 
            // bsave
            // 
            this.bsave.BackColor = System.Drawing.Color.Maroon;
            this.bsave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bsave.Location = new System.Drawing.Point(150, 374);
            this.bsave.Name = "bsave";
            this.bsave.Size = new System.Drawing.Size(117, 51);
            this.bsave.TabIndex = 17;
            this.bsave.Text = "Save";
            this.bsave.UseVisualStyleBackColor = false;
            this.bsave.Click += new System.EventHandler(this.bsave_Click);
            // 
            // badd
            // 
            this.badd.BackColor = System.Drawing.Color.Maroon;
            this.badd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.badd.Location = new System.Drawing.Point(20, 375);
            this.badd.Name = "badd";
            this.badd.Size = new System.Drawing.Size(115, 50);
            this.badd.TabIndex = 16;
            this.badd.Text = "Add";
            this.badd.UseVisualStyleBackColor = false;
            this.badd.Click += new System.EventHandler(this.badd_Click);
            // 
            // dexittime
            // 
            this.dexittime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dexittime.Location = new System.Drawing.Point(496, 260);
            this.dexittime.Name = "dexittime";
            this.dexittime.Size = new System.Drawing.Size(151, 22);
            this.dexittime.TabIndex = 15;
            this.dexittime.ValueChanged += new System.EventHandler(this.dexittime_ValueChanged);
            this.dexittime.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dexittime_KeyDown);
            // 
            // dentrytime
            // 
            this.dentrytime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dentrytime.Location = new System.Drawing.Point(496, 201);
            this.dentrytime.Name = "dentrytime";
            this.dentrytime.Size = new System.Drawing.Size(151, 22);
            this.dentrytime.TabIndex = 14;
            this.dentrytime.ValueChanged += new System.EventHandler(this.dentrytime_ValueChanged);
            this.dentrytime.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dentrytime_KeyDown);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(496, 130);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(151, 22);
            this.dateTimePicker1.TabIndex = 13;
            this.dateTimePicker1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dateTimePicker1_KeyDown);
            // 
            // tname
            // 
            this.tname.Location = new System.Drawing.Point(146, 106);
            this.tname.Name = "tname";
            this.tname.Size = new System.Drawing.Size(166, 22);
            this.tname.TabIndex = 10;
            this.tname.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tname_KeyDown);
            this.tname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tname_KeyPress);
            // 
            // tsno
            // 
            this.tsno.Location = new System.Drawing.Point(146, 42);
            this.tsno.MaxLength = 10;
            this.tsno.Name = "tsno";
            this.tsno.Size = new System.Drawing.Size(166, 22);
            this.tsno.TabIndex = 9;
            this.tsno.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tsno_KeyDown);
            this.tsno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tsno_KeyPress);
            // 
            // cdept
            // 
            this.cdept.FormattingEnabled = true;
            this.cdept.Location = new System.Drawing.Point(159, 222);
            this.cdept.Name = "cdept";
            this.cdept.Size = new System.Drawing.Size(143, 24);
            this.cdept.TabIndex = 8;
            this.cdept.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cdept_KeyDown);
            // 
            // cclass
            // 
            this.cclass.FormattingEnabled = true;
            this.cclass.Location = new System.Drawing.Point(159, 171);
            this.cclass.Name = "cclass";
            this.cclass.Size = new System.Drawing.Size(143, 24);
            this.cclass.TabIndex = 7;
            this.cclass.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cclass_KeyDown);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(372, 262);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 20);
            this.label8.TabIndex = 6;
            this.label8.Text = "Exit Time:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(360, 201);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 20);
            this.label7.TabIndex = 5;
            this.label7.Text = "Entry Time:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(411, 130);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 20);
            this.label6.TabIndex = 4;
            this.label6.Text = "Date:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(31, 226);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "Department:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(31, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Class:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(31, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Sr.No:";
            // 
            // lname
            // 
            this.lname.FormattingEnabled = true;
            this.lname.ItemHeight = 16;
            this.lname.Location = new System.Drawing.Point(696, 99);
            this.lname.Name = "lname";
            this.lname.Size = new System.Drawing.Size(220, 372);
            this.lname.TabIndex = 2;
            this.lname.DoubleClick += new System.EventHandler(this.lname_DoubleClick);
            // 
            // LabUtilization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1032, 598);
            this.Controls.Add(this.lname);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "LabUtilization";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LabUtilization";
            this.Load += new System.EventHandler(this.LabUtilization_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button bsave;
        private System.Windows.Forms.Button badd;
        private System.Windows.Forms.DateTimePicker dexittime;
        private System.Windows.Forms.DateTimePicker dentrytime;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox tname;
        private System.Windows.Forms.TextBox tsno;
        private System.Windows.Forms.ComboBox cdept;
        private System.Windows.Forms.ComboBox cclass;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cdevice;
        private System.Windows.Forms.Button bdelete;
        private System.Windows.Forms.Button bexit;
        private System.Windows.Forms.Button bmodify;
        private System.Windows.Forms.ListBox lname;
        private System.Windows.Forms.TextBox tdesc;
        private System.Windows.Forms.Label label10;
    }
}