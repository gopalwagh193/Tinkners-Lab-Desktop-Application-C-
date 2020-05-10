namespace abc
{
    partial class Form1
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
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tuser = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tpass = new System.Windows.Forms.TextBox();
            this.exit = new System.Windows.Forms.Button();
            this.login = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Red;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(0, -1);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(795, 55);
            this.label3.TabIndex = 6;
            this.label3.Text = "LOGIN                                             ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::abc.Properties.Resources.tinker;
            this.pictureBox1.Location = new System.Drawing.Point(53, 150);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(189, 209);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(354, 198);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 24);
            this.label1.TabIndex = 11;
            this.label1.Text = "User ID:";
            // 
            // tuser
            // 
            this.tuser.Location = new System.Drawing.Point(478, 200);
            this.tuser.Name = "tuser";
            this.tuser.Size = new System.Drawing.Size(148, 22);
            this.tuser.TabIndex = 13;
            this.tuser.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tuser_KeyDown_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(354, 279);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 24);
            this.label2.TabIndex = 12;
            this.label2.Text = "Password";
            // 
            // tpass
            // 
            this.tpass.Location = new System.Drawing.Point(478, 281);
            this.tpass.Name = "tpass";
            this.tpass.Size = new System.Drawing.Size(148, 22);
            this.tpass.TabIndex = 14;
            this.tpass.DoubleClick += new System.EventHandler(this.tpass_DoubleClick);
            this.tpass.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tpass_KeyDown_1);
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.Color.Maroon;
            this.exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit.Location = new System.Drawing.Point(557, 357);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(104, 37);
            this.exit.TabIndex = 10;
            this.exit.Text = "Exit";
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Click += new System.EventHandler(this.exit_Click_1);
            // 
            // login
            // 
            this.login.BackColor = System.Drawing.Color.Maroon;
            this.login.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login.Location = new System.Drawing.Point(419, 357);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(99, 37);
            this.login.TabIndex = 9;
            this.login.Text = "Login";
            this.login.UseVisualStyleBackColor = false;
            this.login.Click += new System.EventHandler(this.login_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(790, 593);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tuser);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tpass);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.login);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tuser;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tpass;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Button login;
    }
}

