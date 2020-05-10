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
    public partial class DeviceEntry : Form
    {
        SqlConnection db;//open the database
        SqlDataAdapter da;//connection table
        DataSet ds;//access the database
        SqlCommand cmd;////connection table
        SqlCommandBuilder cb;//connection table
        DataRow dr;//add the data to database

        int count = 0, keyy;

        private void bexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bsave_Click(object sender, EventArgs e)
        {
            if (tsno.Text == "")
            {
                MessageBox.Show("Please enter Sr.No.");
                tsno.Focus();
            }
           else if (tgpr.Text == "")
            {
                MessageBox.Show("Please enter GPR. No.");
                tgpr.Focus();
            }
            else if (tdesc.Text == "")
            {
                MessageBox.Show("Please enter Description.");
                tdesc.Focus();
            }
            else if (cdevice.Text == "")
            {
                MessageBox.Show("Please select device(consumable/non-consumable");
                cdevice.Focus();
            }
            else if (tauthority.Text == "")
            {
                MessageBox.Show("Please enter authority of purchase.");
                tauthority.Focus();
            }
            else if (dateTimePicker1.Text == "")
            {
                MessageBox.Show("Please enter date of purchase.");
                dateTimePicker1.Focus();
            }
            else if (tqty.Text == "")
            {
                MessageBox.Show("Please enter Quantity");
                tqty.Focus();
            }
            else if (trate.Text == "")
            {
                MessageBox.Show("Please enter rate");
                trate.Focus();
            }
            else if (tcost.Text == "")
            {
                MessageBox.Show("Please enter cost");
                tcost.Focus();
            }
            else if (trno.Text == "")
            {
                MessageBox.Show("Please enter roll no.");
                trno.Focus();
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
            else if (tphno.Text == "")
            {
                MessageBox.Show("Please enter phone No.");
                tphno.Focus();
            }

            else
            {

                dr = ds.Tables["newdentry"].NewRow();
                dr["keyy"] = keyy;
                dr["sr_no"] = tsno.Text;
                dr["gpr_no"] = tgpr.Text;
                dr["description"] = tdesc.Text;
                dr["device"] = cdevice.Text;
                dr["authority_of_purchase"] = tauthority.Text;
                dr["date_of_purchase"] = dateTimePicker1.Text;
                dr["quantity"] = tqty.Text;
                dr["rate"] = trate.Text;
                dr["cost"] = tcost.Text;
                dr["roll_no"] = trno.Text;
                dr["name"] = tname.Text;
                dr["class"] = cclass.Text;
                dr["dept"] = cdept.Text;
                dr["ph_no"] = tphno.Text;

                ds.Tables["newdentry"].Rows.Add(dr);
                da.Update(ds.Tables["newdentry"]);


                MessageBox.Show("All Data Saved Successfully");
                tsno.Text = "";
                tgpr.Text = "";
                tdesc.Text = "";
                cdevice.Text = "";
                tauthority.Text = "";
                dateTimePicker1.Text = "";
                tqty.Text = "";
                trate.Text = "";
                tcost.Text = "";
                trno.Text = "";
                tname.Text = "";
                cclass.Text = "";
                cdept.Text = "";
                tphno.Text = "";

                bsave.Enabled = false;//save button disabled
                bmodify.Enabled = false;
                bdelete.Enabled = false;
            }
        }

        private void DeviceEntry_Load(object sender, EventArgs e)
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
            cmd.CommandText = "select * from newdentry";
            da.SelectCommand = cmd;
            da.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            da.Fill(ds, "newdentry");//dataadapter is filling the data using dataset of student
            cb.DataAdapter = da;

            lname.DataSource = ds.Tables["newdentry"];
            lname.DisplayMember = "gpr_no";
        }

        private void lname_DoubleClick(object sender, EventArgs e)
        {
            dr = ds.Tables["newdentry"].Rows[lname.SelectedIndex];
            tsno.Text = "" + dr[1];
            tgpr.Text = "" + dr[2];
            tdesc.Text = "" + dr[3];
            cdevice.Text = "" + dr[4];
            tauthority.Text = "" + dr[5];
            dateTimePicker1.Text = "" + dr[6];
            tqty.Text = "" + dr[7];
            trate.Text = "" + dr[8];
            tcost.Text = "" + dr[9];
            trno.Text = "" + dr[10];
            tname.Text = "" + dr[11];
            cclass.Text = "" + dr[12];
            cdept.Text = "" + dr[13];
            tphno.Text = "" + dr[14];

            bmodify.Enabled = true;
            bdelete.Enabled = true;

            badd.Enabled = false;
        }

        private void badd_Click(object sender, EventArgs e)
        {
            count = ds.Tables["newdentry"].Rows.Count;
            if (count == 0)
            {
                keyy = 1;
            }
            else
            {
                dr = ds.Tables["newdentry"].Rows[count - 1];
                keyy = Convert.ToInt32(dr[0]) + 1;
            }

            bsave.Enabled = true;//save button enabled
            bmodify.Enabled = true;
            bdelete.Enabled = true;
            tsno.Text = "";
            tgpr.Text = "";
            tdesc.Text = "";
            cdevice.Text = "";
            tauthority.Text = "";
            dateTimePicker1.Text = "";
            tqty.Text = "";
            trate.Text = "";
            tcost.Text = "";
            trno.Text = "";
            tname.Text = "";
            cclass.Text = "";
            cdept.Text = "";
            tphno.Text = "";

        }

        private void bmodify_Click(object sender, EventArgs e)
        {
            dr.BeginEdit();
            dr["sr_no"] = tsno.Text;
            dr["gpr_no"] = tgpr.Text;
            dr["description"] = tdesc.Text;
            dr["device"] = cdevice.Text;
            dr["authority_of_purchase"] = tauthority.Text;
            dr["date_of_purchase"] = dateTimePicker1.Text;
            dr["quantity"] = tqty.Text;
            dr["rate"] = trate.Text;
            dr["cost"] = tcost.Text;
            dr["roll_no"] = trno.Text;
            dr["name"] = tname.Text;
            dr["class"] = cclass.Text;
            dr["dept"] = cdept.Text;
            dr["ph_no"] = tphno.Text;

            dr.EndEdit();
            da.Update(ds.Tables["newdentry"]);
            if (tsno.Text == "")
            {
                MessageBox.Show("Please enter Sr.No.");
                tsno.Focus();
            }
            else if (tgpr.Text == "")
            {
                MessageBox.Show("Please enter GPR No.");
                tgpr.Focus();
            }
            else if (tdesc.Text == "")
            {
                MessageBox.Show("Please enter description");
                tdesc.Focus();
            }
            else if (cdevice.Text == "")
            {
                MessageBox.Show("Please select device type (consumable/non-consumable)");
                cdevice.Focus();
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
            else if (tphno.Text == "")
            {
                MessageBox.Show("Please enter phone no.");
                tphno.Focus();
            }
            else if (dateTimePicker1.Text == "")
            {
                MessageBox.Show("Please select date");
                dateTimePicker1.Focus();
            }
          
           
            else
            {
                MessageBox.Show("Data Upadated Successfully");
            }
        }

        private void bdelete_Click(object sender, EventArgs e)
        {
            dr.Delete();
            da.Update(ds.Tables["newdentry"]);
            MessageBox.Show("Data Deleted Successfully");

            tsno.Text = "";
            tgpr.Text = "";
            tdesc.Text = "";
            cdevice.Text = "";
            tauthority.Text = "";
            dateTimePicker1.Text = "";
            tqty.Text = "";
            trate.Text = "";
            tcost.Text = "";
            trno.Text = "";
            tname.Text = "";
            cclass.Text = "";
            cdept.Text = "";
            tphno.Text = "";


            bmodify.Enabled = false;
            bdelete.Enabled = false;
            badd.Enabled = true;
            badd.Focus();
        }

        private void trate_TextChanged(object sender, EventArgs e)
        {
            if (tqty.Text.Length > 0 && trate.Text.Length > 0)
            {

                tcost.Text = Convert.ToString((Convert.ToInt32(tqty.Text) * Convert.ToInt32(trate.Text)));
            }
        }

        private void tphno_KeyPress(object sender, KeyPressEventArgs e)
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

        private void tgpr_KeyPress(object sender, KeyPressEventArgs e)
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

        private void trno_KeyPress(object sender, KeyPressEventArgs e)
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

        private void tqty_KeyPress(object sender, KeyPressEventArgs e)
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

        private void trate_KeyPress(object sender, KeyPressEventArgs e)
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

        private void tcost_KeyPress(object sender, KeyPressEventArgs e)
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

        public DeviceEntry()
        {
            InitializeComponent();
            this.ActiveControl = badd;
        }

        

       

       
    }
}
