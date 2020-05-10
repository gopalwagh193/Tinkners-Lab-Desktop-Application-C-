namespace abc
{
    partial class ExportDevice
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
            this.cdevice = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.bexit = new System.Windows.Forms.Button();
            this.bdelete = new System.Windows.Forms.Button();
            this.bmodify = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.tdesc = new System.Windows.Forms.TextBox();
            this.cdept = new System.Windows.Forms.ComboBox();
            this.cclass = new System.Windows.Forms.ComboBox();
            this.tphno = new System.Windows.Forms.TextBox();
            this.tname = new System.Windows.Forms.TextBox();
            this.tsno = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bsave = new System.Windows.Forms.Button();
            this.badd = new System.Windows.Forms.Button();
            this.lname = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Red;
            this.label1.Font = new System.Drawing.Font("Corbel", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.AliceBlue;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1034, 60);
            this.label1.TabIndex = 0;
            this.label1.Text = "Export Device                                                           ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cdevice);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.bexit);
            this.groupBox1.Controls.Add(this.bdelete);
            this.groupBox1.Controls.Add(this.bmodify);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.tdesc);
            this.groupBox1.Controls.Add(this.cdept);
            this.groupBox1.Controls.Add(this.cclass);
            this.groupBox1.Controls.Add(this.tphno);
            this.groupBox1.Controls.Add(this.tname);
            this.groupBox1.Controls.Add(this.tsno);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.bsave);
            this.groupBox1.Controls.Add(this.badd);
            this.groupBox1.Location = new System.Drawing.Point(12, 94);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(692, 417);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // cdevice
            // 
            this.cdevice.FormattingEnabled = true;
            this.cdevice.Location = new System.Drawing.Point(482, 152);
            this.cdevice.Name = "cdevice";
            this.cdevice.Size = new System.Drawing.Size(121, 24);
            this.cdevice.TabIndex = 20;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(371, 152);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 20);
            this.label9.TabIndex = 19;
            this.label9.Text = "Device:";
            // 
            // bexit
            // 
            this.bexit.BackColor = System.Drawing.Color.Maroon;
            this.bexit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bexit.Location = new System.Drawing.Point(549, 348);
            this.bexit.Name = "bexit";
            this.bexit.Size = new System.Drawing.Size(117, 47);
            this.bexit.TabIndex = 18;
            this.bexit.Text = "Exit";
            this.bexit.UseVisualStyleBackColor = false;
            this.bexit.Click += new System.EventHandler(this.bexit_Click);
            // 
            // bdelete
            // 
            this.bdelete.BackColor = System.Drawing.Color.Maroon;
            this.bdelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bdelete.Location = new System.Drawing.Point(422, 348);
            this.bdelete.Name = "bdelete";
            this.bdelete.Size = new System.Drawing.Size(109, 47);
            this.bdelete.TabIndex = 17;
            this.bdelete.Text = "Delete";
            this.bdelete.UseVisualStyleBackColor = false;
            this.bdelete.Click += new System.EventHandler(this.bdelete_Click);
            // 
            // bmodify
            // 
            this.bmodify.BackColor = System.Drawing.Color.Maroon;
            this.bmodify.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bmodify.Location = new System.Drawing.Point(285, 348);
            this.bmodify.Name = "bmodify";
            this.bmodify.Size = new System.Drawing.Size(116, 47);
            this.bmodify.TabIndex = 16;
            this.bmodify.Text = "Update";
            this.bmodify.UseVisualStyleBackColor = false;
            this.bmodify.Click += new System.EventHandler(this.bmodify_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(482, 94);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(162, 24);
            this.dateTimePicker1.TabIndex = 15;
            // 
            // tdesc
            // 
            this.tdesc.Location = new System.Drawing.Point(482, 202);
            this.tdesc.Multiline = true;
            this.tdesc.Name = "tdesc";
            this.tdesc.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tdesc.Size = new System.Drawing.Size(162, 45);
            this.tdesc.TabIndex = 14;
            // 
            // cdept
            // 
            this.cdept.FormattingEnabled = true;
            this.cdept.Location = new System.Drawing.Point(167, 202);
            this.cdept.Name = "cdept";
            this.cdept.Size = new System.Drawing.Size(121, 24);
            this.cdept.TabIndex = 13;
            // 
            // cclass
            // 
            this.cclass.FormattingEnabled = true;
            this.cclass.Location = new System.Drawing.Point(167, 148);
            this.cclass.Name = "cclass";
            this.cclass.Size = new System.Drawing.Size(121, 24);
            this.cclass.TabIndex = 12;
            // 
            // tphno
            // 
            this.tphno.Location = new System.Drawing.Point(166, 261);
            this.tphno.MaxLength = 10;
            this.tphno.Name = "tphno";
            this.tphno.Size = new System.Drawing.Size(153, 22);
            this.tphno.TabIndex = 11;
            this.tphno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tphno_KeyPress);
            // 
            // tname
            // 
            this.tname.Location = new System.Drawing.Point(157, 94);
            this.tname.Name = "tname";
            this.tname.Size = new System.Drawing.Size(153, 22);
            this.tname.TabIndex = 10;
            this.tname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tname_KeyPress);
            // 
            // tsno
            // 
            this.tsno.Location = new System.Drawing.Point(157, 36);
            this.tsno.MaxLength = 10;
            this.tsno.Name = "tsno";
            this.tsno.Size = new System.Drawing.Size(153, 22);
            this.tsno.TabIndex = 9;
            this.tsno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tsno_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(22, 263);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(138, 20);
            this.label8.TabIndex = 8;
            this.label8.Text = "Phone Number:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(343, 215);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 20);
            this.label7.TabIndex = 7;
            this.label7.Text = "Description:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(389, 100);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "Date:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(22, 206);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Department:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(22, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Class:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Sr.No:";
            // 
            // bsave
            // 
            this.bsave.BackColor = System.Drawing.Color.Maroon;
            this.bsave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bsave.Location = new System.Drawing.Point(146, 348);
            this.bsave.Name = "bsave";
            this.bsave.Size = new System.Drawing.Size(121, 47);
            this.bsave.TabIndex = 1;
            this.bsave.Text = "Save";
            this.bsave.UseVisualStyleBackColor = false;
            this.bsave.Click += new System.EventHandler(this.bsave_Click);
            // 
            // badd
            // 
            this.badd.BackColor = System.Drawing.Color.Maroon;
            this.badd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.badd.Location = new System.Drawing.Point(15, 348);
            this.badd.Name = "badd";
            this.badd.Size = new System.Drawing.Size(114, 47);
            this.badd.TabIndex = 0;
            this.badd.Text = "Add";
            this.badd.UseVisualStyleBackColor = false;
            this.badd.Click += new System.EventHandler(this.badd_Click);
            // 
            // lname
            // 
            this.lname.FormattingEnabled = true;
            this.lname.ItemHeight = 16;
            this.lname.Location = new System.Drawing.Point(726, 112);
            this.lname.Name = "lname";
            this.lname.Size = new System.Drawing.Size(265, 372);
            this.lname.TabIndex = 2;
            this.lname.DoubleClick += new System.EventHandler(this.lname_DoubleClick);
            // 
            // ExportDevice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1032, 598);
            this.Controls.Add(this.lname);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "ExportDevice";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ExportDevice";
            this.Load += new System.EventHandler(this.ExportDevice_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bsave;
        private System.Windows.Forms.Button badd;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tphno;
        private System.Windows.Forms.TextBox tname;
        private System.Windows.Forms.TextBox tsno;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox tdesc;
        private System.Windows.Forms.ComboBox cdept;
        private System.Windows.Forms.ComboBox cclass;
        private System.Windows.Forms.Button bexit;
        private System.Windows.Forms.Button bdelete;
        private System.Windows.Forms.Button bmodify;
        private System.Windows.Forms.ListBox lname;
        private System.Windows.Forms.ComboBox cdevice;
        private System.Windows.Forms.Label label9;
    }
}