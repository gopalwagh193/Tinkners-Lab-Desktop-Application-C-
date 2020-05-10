using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace abc
{
    public partial class DMenu : Form
    {
        public DMenu()
        {
            InitializeComponent();
        }

        private void newDeviceEntryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeviceEntry de = new DeviceEntry();
            de.Show();
        }

        private void exportDeviceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExportDevice ed = new ExportDevice();
            ed.Show();
        }

        private void labUtilizationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LabUtilization lu = new LabUtilization();
            lu.Show();
        }

        private void logOutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form1 fm = new Form1();
            fm.Show();
        }

        private void labUtilizationDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewLabUtilization vlu = new ViewLabUtilization();
            vlu.Show();
        }

        private void exportDeviceDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewExportDevice ved = new ViewExportDevice();
            ved.Show();
        }

        private void newDeviceDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewDeviceEntry vd = new ViewDeviceEntry();
            vd.Show();
        }

        private void viewToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
