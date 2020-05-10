namespace abc
{
    partial class DeviceEntry
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
            this.label15 = new System.Windows.Forms.Label();
            this.trate = new System.Windows.Forms.TextBox();
            this.tcost = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.tqty = new System.Windows.Forms.TextBox();
            this.tauthority = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tgpr = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tdesc = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.tsno = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.trno = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.cclass = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tphno = new System.Windows.Forms.TextBox();
            this.cdept = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.bexit = new System.Windows.Forms.Button();
            this.bdelete = new System.Windows.Forms.Button();
            this.badd = new System.Windows.Forms.Button();
            this.bsave = new System.Windows.Forms.Button();
            this.bmodify = new System.Windows.Forms.Button();
            this.lname = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Red;
            this.label1.Font = new System.Drawing.Font("Corbel", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(-2, -2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1158, 54);
            this.label1.TabIndex = 0;
            this.label1.Text = "New Device Entry      ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cdevice);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.trate);
            this.groupBox1.Controls.Add(this.tcost);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.tqty);
            this.groupBox1.Controls.Add(this.tauthority);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.tgpr);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.tdesc);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.tsno);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(26, 80);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(856, 500);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // cdevice
            // 
            this.cdevice.FormattingEnabled = true;
            this.cdevice.Location = new System.Drawing.Point(683, 81);
            this.cdevice.Name = "cdevice";
            this.cdevice.Size = new System.Drawing.Size(140, 24);
            this.cdevice.TabIndex = 31;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(589, 81);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(73, 20);
            this.label15.TabIndex = 30;
            this.label15.Text = "Device:";
            // 
            // trate
            // 
            this.trate.Location = new System.Drawing.Point(450, 222);
            this.trate.Name = "trate";
            this.trate.Size = new System.Drawing.Size(115, 22);
            this.trate.TabIndex = 28;
            this.trate.TextChanged += new System.EventHandler(this.trate_TextChanged);
            this.trate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.trate_KeyPress);
            // 
            // tcost
            // 
            this.tcost.Location = new System.Drawing.Point(662, 224);
            this.tcost.Name = "tcost";
            this.tcost.Size = new System.Drawing.Size(112, 22);
            this.tcost.TabIndex = 27;
            this.tcost.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tcost_KeyPress);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(589, 224);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(54, 20);
            this.label13.TabIndex = 26;
            this.label13.Text = "Cost:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(377, 224);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(54, 20);
            this.label12.TabIndex = 25;
            this.label12.Text = "Rate:";
            // 
            // tqty
            // 
            this.tqty.Location = new System.Drawing.Point(215, 225);
            this.tqty.Name = "tqty";
            this.tqty.Size = new System.Drawing.Size(124, 22);
            this.tqty.TabIndex = 24;
            this.tqty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tqty_KeyPress);
            // 
            // tauthority
            // 
            this.tauthority.Location = new System.Drawing.Point(244, 161);
            this.tauthority.Name = "tauthority";
            this.tauthority.Size = new System.Drawing.Size(187, 22);
            this.tauthority.TabIndex = 23;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(16, 224);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(178, 20);
            this.label11.TabIndex = 22;
            this.label11.Text = "Number of Quantity:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(16, 161);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(197, 20);
            this.label10.TabIndex = 21;
            this.label10.Text = "Authority to Purchase:";
            // 
            // tgpr
            // 
            this.tgpr.Location = new System.Drawing.Point(544, 23);
            this.tgpr.MaxLength = 10;
            this.tgpr.Name = "tgpr";
            this.tgpr.Size = new System.Drawing.Size(192, 22);
            this.tgpr.TabIndex = 20;
            this.tgpr.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tgpr_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(418, 23);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(98, 20);
            this.label9.TabIndex = 19;
            this.label9.Text = "G.P.R. No:";
            // 
            // tdesc
            // 
            this.tdesc.Location = new System.Drawing.Point(260, 82);
            this.tdesc.Multiline = true;
            this.tdesc.Name = "tdesc";
            this.tdesc.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tdesc.Size = new System.Drawing.Size(270, 58);
            this.tdesc.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(6, 82);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(228, 20);
            this.label8.TabIndex = 12;
            this.label8.Text = "Description of Equipment:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(649, 163);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(174, 24);
            this.dateTimePicker1.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(465, 163);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(162, 20);
            this.label7.TabIndex = 10;
            this.label7.Text = "Date of Purchase:";
            // 
            // tsno
            // 
            this.tsno.Location = new System.Drawing.Point(127, 21);
            this.tsno.MaxLength = 10;
            this.tsno.Name = "tsno";
            this.tsno.Size = new System.Drawing.Size(187, 22);
            this.tsno.TabIndex = 5;
            this.tsno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tsno_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Sr. No:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.trno);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.cclass);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.tphno);
            this.groupBox2.Controls.Add(this.cdept);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.tname);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.bexit);
            this.groupBox2.Controls.Add(this.bdelete);
            this.groupBox2.Controls.Add(this.badd);
            this.groupBox2.Controls.Add(this.bsave);
            this.groupBox2.Controls.Add(this.bmodify);
            this.groupBox2.Location = new System.Drawing.Point(0, 253);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(856, 247);
            this.groupBox2.TabIndex = 29;
            this.groupBox2.TabStop = false;
            // 
            // trno
            // 
            this.trno.Location = new System.Drawing.Point(155, 32);
            this.trno.MaxLength = 10;
            this.trno.Name = "trno";
            this.trno.Size = new System.Drawing.Size(100, 22);
            this.trno.TabIndex = 20;
            this.trno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.trno_KeyPress);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(27, 32);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(77, 20);
            this.label14.TabIndex = 19;
            this.label14.Text = "Roll No:";
            // 
            // cclass
            // 
            this.cclass.FormattingEnabled = true;
            this.cclass.Location = new System.Drawing.Point(155, 88);
            this.cclass.Name = "cclass";
            this.cclass.Size = new System.Drawing.Size(121, 24);
            this.cclass.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(27, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Class:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(27, 141);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(138, 20);
            this.label6.TabIndex = 8;
            this.label6.Text = "Phone Number:";
            // 
            // tphno
            // 
            this.tphno.Location = new System.Drawing.Point(184, 141);
            this.tphno.MaxLength = 10;
            this.tphno.Name = "tphno";
            this.tphno.Size = new System.Drawing.Size(140, 22);
            this.tphno.TabIndex = 9;
            this.tphno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tphno_KeyPress);
            // 
            // cdept
            // 
            this.cdept.FormattingEnabled = true;
            this.cdept.Location = new System.Drawing.Point(522, 84);
            this.cdept.Name = "cdept";
            this.cdept.Size = new System.Drawing.Size(121, 24);
            this.cdept.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(368, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Department:";
            // 
            // tname
            // 
            this.tname.Location = new System.Drawing.Point(522, 34);
            this.tname.Name = "tname";
            this.tname.Size = new System.Drawing.Size(140, 22);
            this.tname.TabIndex = 6;
            this.tname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tname_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(418, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Name:";
            // 
            // bexit
            // 
            this.bexit.BackColor = System.Drawing.Color.Maroon;
            this.bexit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bexit.Location = new System.Drawing.Point(583, 184);
            this.bexit.Name = "bexit";
            this.bexit.Size = new System.Drawing.Size(109, 46);
            this.bexit.TabIndex = 18;
            this.bexit.Text = "Exit";
            this.bexit.UseVisualStyleBackColor = false;
            this.bexit.Click += new System.EventHandler(this.bexit_Click);
            // 
            // bdelete
            // 
            this.bdelete.BackColor = System.Drawing.Color.Maroon;
            this.bdelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bdelete.Location = new System.Drawing.Point(453, 184);
            this.bdelete.Name = "bdelete";
            this.bdelete.Size = new System.Drawing.Size(112, 46);
            this.bdelete.TabIndex = 17;
            this.bdelete.Text = "Delete";
            this.bdelete.UseVisualStyleBackColor = false;
            this.bdelete.Click += new System.EventHandler(this.bdelete_Click);
            // 
            // badd
            // 
            this.badd.BackColor = System.Drawing.Color.Maroon;
            this.badd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.badd.Location = new System.Drawing.Point(45, 184);
            this.badd.Name = "badd";
            this.badd.Size = new System.Drawing.Size(120, 46);
            this.badd.TabIndex = 14;
            this.badd.Text = "Add";
            this.badd.UseVisualStyleBackColor = false;
            this.badd.Click += new System.EventHandler(this.badd_Click);
            // 
            // bsave
            // 
            this.bsave.BackColor = System.Drawing.Color.Maroon;
            this.bsave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bsave.Location = new System.Drawing.Point(184, 184);
            this.bsave.Name = "bsave";
            this.bsave.Size = new System.Drawing.Size(120, 46);
            this.bsave.TabIndex = 15;
            this.bsave.Text = "Save";
            this.bsave.UseVisualStyleBackColor = false;
            this.bsave.Click += new System.EventHandler(this.bsave_Click);
            // 
            // bmodify
            // 
            this.bmodify.BackColor = System.Drawing.Color.Maroon;
            this.bmodify.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bmodify.Location = new System.Drawing.Point(325, 184);
            this.bmodify.Name = "bmodify";
            this.bmodify.Size = new System.Drawing.Size(116, 46);
            this.bmodify.TabIndex = 16;
            this.bmodify.Text = "Update";
            this.bmodify.UseVisualStyleBackColor = false;
            this.bmodify.Click += new System.EventHandler(this.bmodify_Click);
            // 
            // lname
            // 
            this.lname.FormattingEnabled = true;
            this.lname.ItemHeight = 16;
            this.lname.Location = new System.Drawing.Point(888, 91);
            this.lname.Name = "lname";
            this.lname.Size = new System.Drawing.Size(256, 436);
            this.lname.TabIndex = 2;
            this.lname.DoubleClick += new System.EventHandler(this.lname_DoubleClick);
            // 
            // DeviceEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1156, 608);
            this.Controls.Add(this.lname);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "DeviceEntry";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New Device Entry";
            this.Load += new System.EventHandler(this.DeviceEntry_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tphno;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cdept;
        private System.Windows.Forms.TextBox tname;
        private System.Windows.Forms.TextBox tsno;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cclass;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tdesc;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button bsave;
        private System.Windows.Forms.Button badd;
        private System.Windows.Forms.Button bexit;
        private System.Windows.Forms.Button bdelete;
        private System.Windows.Forms.Button bmodify;
        private System.Windows.Forms.TextBox tgpr;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox trate;
        private System.Windows.Forms.TextBox tcost;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tqty;
        private System.Windows.Forms.TextBox tauthority;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox trno;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ListBox lname;
        private System.Windows.Forms.ComboBox cdevice;
        private System.Windows.Forms.Label label15;
    }
}