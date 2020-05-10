namespace abc
{
    partial class DMenu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.entryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newDeviceEntryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportDeviceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labUtilizationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newDeviceDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportDeviceDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labUtilizationDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.Color.Red;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.entryToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.logOutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(790, 50);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // entryToolStripMenuItem
            // 
            this.entryToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newDeviceEntryToolStripMenuItem,
            this.exportDeviceToolStripMenuItem,
            this.labUtilizationToolStripMenuItem});
            this.entryToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.entryToolStripMenuItem.Name = "entryToolStripMenuItem";
            this.entryToolStripMenuItem.Size = new System.Drawing.Size(72, 46);
            this.entryToolStripMenuItem.Text = "Entry";
            // 
            // newDeviceEntryToolStripMenuItem
            // 
            this.newDeviceEntryToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.newDeviceEntryToolStripMenuItem.Name = "newDeviceEntryToolStripMenuItem";
            this.newDeviceEntryToolStripMenuItem.Size = new System.Drawing.Size(246, 30);
            this.newDeviceEntryToolStripMenuItem.Text = "New Device Entry";
            this.newDeviceEntryToolStripMenuItem.Click += new System.EventHandler(this.newDeviceEntryToolStripMenuItem_Click);
            // 
            // exportDeviceToolStripMenuItem
            // 
            this.exportDeviceToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.exportDeviceToolStripMenuItem.Name = "exportDeviceToolStripMenuItem";
            this.exportDeviceToolStripMenuItem.Size = new System.Drawing.Size(246, 30);
            this.exportDeviceToolStripMenuItem.Text = "Export Device";
            this.exportDeviceToolStripMenuItem.Click += new System.EventHandler(this.exportDeviceToolStripMenuItem_Click);
            // 
            // labUtilizationToolStripMenuItem
            // 
            this.labUtilizationToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.labUtilizationToolStripMenuItem.Name = "labUtilizationToolStripMenuItem";
            this.labUtilizationToolStripMenuItem.Size = new System.Drawing.Size(246, 30);
            this.labUtilizationToolStripMenuItem.Text = "Lab Utilization";
            this.labUtilizationToolStripMenuItem.Click += new System.EventHandler(this.labUtilizationToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newDeviceDetailsToolStripMenuItem,
            this.exportDeviceDetailsToolStripMenuItem,
            this.labUtilizationDetailsToolStripMenuItem});
            this.viewToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(67, 46);
            this.viewToolStripMenuItem.Text = "View";
            this.viewToolStripMenuItem.Click += new System.EventHandler(this.viewToolStripMenuItem_Click);
            // 
            // newDeviceDetailsToolStripMenuItem
            // 
            this.newDeviceDetailsToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.newDeviceDetailsToolStripMenuItem.Name = "newDeviceDetailsToolStripMenuItem";
            this.newDeviceDetailsToolStripMenuItem.Size = new System.Drawing.Size(282, 30);
            this.newDeviceDetailsToolStripMenuItem.Text = "New Device Details";
            this.newDeviceDetailsToolStripMenuItem.Click += new System.EventHandler(this.newDeviceDetailsToolStripMenuItem_Click);
            // 
            // exportDeviceDetailsToolStripMenuItem
            // 
            this.exportDeviceDetailsToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.exportDeviceDetailsToolStripMenuItem.Name = "exportDeviceDetailsToolStripMenuItem";
            this.exportDeviceDetailsToolStripMenuItem.Size = new System.Drawing.Size(282, 30);
            this.exportDeviceDetailsToolStripMenuItem.Text = "Export Device Details";
            this.exportDeviceDetailsToolStripMenuItem.Click += new System.EventHandler(this.exportDeviceDetailsToolStripMenuItem_Click);
            // 
            // labUtilizationDetailsToolStripMenuItem
            // 
            this.labUtilizationDetailsToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.labUtilizationDetailsToolStripMenuItem.Name = "labUtilizationDetailsToolStripMenuItem";
            this.labUtilizationDetailsToolStripMenuItem.Size = new System.Drawing.Size(282, 30);
            this.labUtilizationDetailsToolStripMenuItem.Text = "Lab Utilization Details";
            this.labUtilizationDetailsToolStripMenuItem.Click += new System.EventHandler(this.labUtilizationDetailsToolStripMenuItem_Click);
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logOutToolStripMenuItem1});
            this.logOutToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(96, 46);
            this.logOutToolStripMenuItem.Text = "Log Out";
            // 
            // logOutToolStripMenuItem1
            // 
            this.logOutToolStripMenuItem1.ForeColor = System.Drawing.Color.Black;
            this.logOutToolStripMenuItem1.Name = "logOutToolStripMenuItem1";
            this.logOutToolStripMenuItem1.Size = new System.Drawing.Size(181, 30);
            this.logOutToolStripMenuItem1.Text = "Log Out";
            this.logOutToolStripMenuItem1.Click += new System.EventHandler(this.logOutToolStripMenuItem1_Click);
            // 
            // DMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(790, 593);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "DMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DMenu";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem entryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newDeviceEntryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exportDeviceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem labUtilizationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newDeviceDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportDeviceDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem labUtilizationDetailsToolStripMenuItem;
    }
}