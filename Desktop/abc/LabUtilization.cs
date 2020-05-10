using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace abc
{
    public partial class LabUtilization : Form
    {
        SqlConnection db;//open the database
        SqlDataAdapter da, da1, da2;//connection table
        DataSet ds, ds1, ds2;//access the database
        SqlCommand cmd;////connection table
        SqlCommandBuilder cb;//connection table
        DataRow dr;//add the data to database


        private void bdelete_Click(object sender, EventArgs e)
        {
            dr.Delete();
            da.Update(ds.Tables["labutilization"]);
            MessageBox.Show("Data Deleted Successfully");

            tsno.Text = "";
            tname.Text = "";
            cclass.Text = "";
            cdept.Text = "";
            cdevice.Text = "";
            tdesc.Text = "";
            dateTimePicker1.Text = "";
            dentrytime.Text = "";
            dexittime.Text = "";


            bmodify.Enabled = false;
            bdelete.Enabled = false;
            badd.Enabled = true;
            badd.Focus();
        }

        private void bmodify_Click(object sender, EventArgs e)
        {
            dr.BeginEdit();
            dr["sr_no"] = tsno.Text;
            dr["name"] = tname.Text;
            dr["class"] = cclass.Text;
            dr["dept"] = cdept.Text;
            dr["device"] = cdevice.Text;
            dr["description"] = tdesc.Text;
            dr["date"] = dateTimePicker1.Text;
            dr["entry_time"] = dentrytime.Text;
            dr["exit_time"] = dexittime.Text;
            dr.EndEdit();
            da.Update(ds.Tables["labutilization"]);
            if (tsno.Text == "")
            {
                MessageBox.Show("Please enter Sr.No.");
                tsno.Focus();
            }
            else if(tname.Text == "")
            {
                MessageBox.Show("Please enter Name");
                tname.Focus();
            }
            else if (cclass.Text == "")
            {
                MessageBox.Show("Please select class");
                cclass.Focus();
            }
            else if (cdept.Text == "")
            {
                MessageBox.Show("Please select department");
                cdept.Focus();
            }
            else if (cdevice.Text == "")
            {
                MessageBox.Show("Please select device type");
                cdevice.Focus();
            }
            else if (tdesc.Text == "")
            {
                MessageBox.Show("Please enter description");
                tdesc.Focus();
            }
            else if (dateTimePicker1.Text == "")
            {
                MessageBox.Show("Please select date");
                dateTimePicker1.Focus();
            }
            else if (dentrytime.Text == "")
            {
                MessageBox.Show("Please select entry time");
                dentrytime.Focus();
            }
            else if (dexittime.Text == "")
            {
                MessageBox.Show("Please select exit time");
                dexittime.Focus();
            }
            else
            {
                MessageBox.Show("Data Upadated Successfully");
            }
        }

        private void lname_DoubleClick(object sender, EventArgs e)
        {
            dr = ds.Tables["labutilization"].Rows[lname.SelectedIndex];
            tsno.Text = "" + dr[1];
            tname.Text = "" + dr[2];
            cclass.Text = "" + dr[3];
            cdept.Text = "" + dr[4];
            cdevice.Text = "" + dr[5];
            tdesc.Text = "" + dr[6];
            dateTimePicker1.Text = "" + dr[7];
            dentrytime.Text = "" + dr[8];
            dexittime.Text = "" + dr[9];

            bmodify.Enabled = true;
            bdelete.Enabled = true;

            badd.Enabled = false;
        }

        private void bsave_Click(object sender, EventArgs e)
        {
            if (tsno.Text == "")
            {
                MessageBox.Show("Please enter Sr.No.");
                tsno.Focus();
            }
            else if (tname.Text == "")
            {
                MessageBox.Show("Please enter Name");
                tname.Focus();
            }
            else if (cclass.Text == "")
            {
                MessageBox.Show("Please select class");
                cclass.Focus();
            }
            else if (cdept.Text == "")
            {
                MessageBox.Show("Please select department");
                cdept.Focus();
            }
            else if (cdevice.Text == "")
            {
                MessageBox.Show("Please select device type");
                cdevice.Focus();
            }
            else if (tdesc.Text == "")
            {
                MessageBox.Show("Please enter description");
                tdesc.Focus();
            }
            else if (dateTimePicker1.Text == "")
            {
                MessageBox.Show("Please select date");
                dateTimePicker1.Focus();
            }
            else if (dentrytime.Text == "")
            {
                MessageBox.Show("Please select entry time");
                dentrytime.Focus();
            }
            else if (dexittime.Text == "")
            {
                MessageBox.Show("Please select exit time");
                dexittime.Focus();
            }
            else
            {

                dr = ds.Tables["labutilization"].NewRow();
                dr["keyy"] = keyy;
                dr["sr_no"] = tsno.Text;
                dr["name"] = tname.Text;
                dr["class"] = cclass.Text;
                dr["dept"] = cdept.Text;
                dr["device"] = cdevice.Text;
                dr["description"] = tdesc.Text;
                dr["date"] = dateTimePicker1.Text;
                dr["entry_time"] = dentrytime.Text;
                dr["exit_time"] = dexittime.Text;

                ds.Tables["labutilization"].Rows.Add(dr);
                da.Update(ds.Tables["labutilization"]);


                MessageBox.Show("All Data Saved Successfully");
                tsno.Text = "";
                tname.Text = "";
                cclass.Text = "";
                cdept.Text = "";
                cdevice.Text = "";
                tdesc.Text = "";
                dateTimePicker1.Text = "";
                dentrytime.Text = "";
                dexittime.Text = "";


                bsave.Enabled = false;//save button disabled
                bmodify.Enabled = false;
                bdelete.Enabled = false;
            }
        }

        private void dentrytime_ValueChanged(object sender, EventArgs e)
        {
           dentrytime.Format= DateTimePickerFormat.Time;
            dentrytime.ShowUpDown = true;
        }

        private void dexittime_ValueChanged(object sender, EventArgs e)
        {
            dexittime.Format = DateTimePickerFormat.Time;
            dexittime.ShowUpDown = true;
        }

        private void bexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar)
       && !char.IsDigit(e.KeyChar)
     )
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if (e.KeyChar == '.'
                && (sender as TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
        }

        private void tname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar)
      && char.IsDigit(e.KeyChar)
      )
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if (e.KeyChar == '.'
                && (sender as TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
        }

        private void tsno_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                tname.Focus();
            }
            else if (e.KeyData == Keys.Escape)
            {
                badd.Focus();
            }
        }

        private void tname_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                tsno.Focus();
            }
            else if (e.KeyData == Keys.Escape)
            {
                cclass.Focus();
            }
        }

        private void cclass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                tname.Focus();
            }
            else if (e.KeyData == Keys.Escape)
            {
                cdept.Focus();
            }
        }

        private void cdept_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                cclass.Focus();
            }
            else if (e.KeyData == Keys.Escape)
            {
                cdevice.Focus();
            }
        }

        private void cdevice_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                cdept.Focus();
            }
            else if (e.KeyData == Keys.Escape)
            {
                tdesc.Focus();
            }
        }

        private void tdesc_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                dateTimePicker1.Focus();
            }
            else if (e.KeyData == Keys.Escape)
            {
                cdevice.Focus();
            }
        }

        private void dateTimePicker1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                tdesc.Focus();
            }
            else if (e.KeyData == Keys.Escape)
            {
                dentrytime.Focus();
            }
        }

        private void dentrytime_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                dexittime.Focus();
            }
            else if (e.KeyData == Keys.Escape)
            {
                dateTimePicker1.Focus();
            }
        }

        private void dexittime_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                dentrytime.Focus();
            }
            else if(e.KeyData == Keys.Escape)
            {
                bsave.Focus();
            }
        }

        int count = 0, keyy;
        public LabUtilization()
        {
            InitializeComponent();
            this.ActiveControl = badd;
        }

        private void LabUtilization_Load(object sender, EventArgs e)
        {
            cclass.Items.Add("FE");
            cclass.Items.Add("SE");
            cclass.Items.Add("TE");
            cclass.Items.Add("BE");
            cdept.Items.Add("Computer");
            cdept.Items.Add("IT");
            cdept.Items.Add("Mechanical");
            cdept.Items.Add("Civil");
            cdept.Items.Add("Electronics");
            cdevice.Items.Add("Consumable");
            cdevice.Items.Add("Non-Consumable");
            bsave.Enabled = false;//save button disabled
            bmodify.Enabled = false;
            bdelete.Enabled = false;

            db = new SqlConnection();
            da = new SqlDataAdapter();
            ds = new DataSet();
            cmd = new SqlCommand();
            cb = new SqlCommandBuilder();

            db.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\Visual projects Demo\abc\db\tinkers.mdf;Integrated Security=True";
            db.Open();//open the connection

            cmd.Connection = db;
            cmd.CommandText = "select * from labutilization";
            da.SelectCommand = cmd;
            da.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            da.Fill(ds, "labutilization");//dataadapter is filling the data using dataset of student
            cb.DataAdapter = da;

            lname.DataSource = ds.Tables["labutilization"];
            lname.DisplayMember = "sr_no";
        }

        private void badd_Click(object sender, EventArgs e)
        {
            count = ds.Tables["labutilization"].Rows.Count;
            if (count == 0)
            {
                keyy = 1;
            }
            else
            {
                dr = ds.Tables["labutilization"].Rows[count - 1];
                keyy = Convert.ToInt32(dr[0]) + 1;
            }

            bsave.Enabled = true;//save button enabled
            bmodify.Enabled = true;
            bdelete.Enabled = true;
            tsno.Text = "";
            tname.Text = "";
            cclass.Text = "";
            cdept.Text = "";
            cdevice.Text = "";
            tdesc.Text = "";
            dateTimePicker1.Text = "";
            dentrytime.Text = "";
            dexittime.Text = "";

        }
    }
}
