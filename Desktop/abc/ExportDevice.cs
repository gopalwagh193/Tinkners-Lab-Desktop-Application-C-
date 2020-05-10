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
    public partial class ExportDevice : Form
    {
        SqlConnection db;//open the database
        SqlDataAdapter da, da1, da2;//connection table
        DataSet ds, ds1, ds2;//access the database
        SqlCommand cmd;////connection table
        SqlCommandBuilder cb;//connection table

        private void ExportDevice_Load(object sender, EventArgs e)
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
            cmd.CommandText = "select * from exportdevice";
            da.SelectCommand = cmd;
            da.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            da.Fill(ds, "exportdevice");//dataadapter is filling the data using dataset of student
            cb.DataAdapter = da;

            lname.DataSource = ds.Tables["exportdevice"];
            lname.DisplayMember = "sr_no";
        }

        private void badd_Click(object sender, EventArgs e)
        {
            count = ds.Tables["exportdevice"].Rows.Count;
            if (count == 0)
            {
                keyy = 1;
            }
            else
            {
                dr = ds.Tables["exportdevice"].Rows[count - 1];
                keyy = Convert.ToInt32(dr[0]) + 1;
            }

            bsave.Enabled = true;//save button enabled
            bmodify.Enabled = true;
            bdelete.Enabled = true;
            tsno.Text = "";
            tname.Text = "";
            cclass.Text = "";
            cdept.Text = "";
            tphno.Text = "";
            dateTimePicker1.Text = "";          
            cdevice.Text = "";
            tdesc.Text = "";
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
            else if (dateTimePicker1.Text == "")
            {
                MessageBox.Show("Please select date");
                dateTimePicker1.Focus();
            }
            else if (tphno.Text == "")
            {
                MessageBox.Show("Please enter phone no.");
                tphno.Focus();
            }
            else if (tdesc.Text == "")
            {
                MessageBox.Show("Please enter description");
                tdesc.Focus();
            }
            else
            {

                dr = ds.Tables["exportdevice"].NewRow();
                dr["keyy"] = keyy;
                dr["sr_no"] = tsno.Text;
                dr["name"] = tname.Text;
                dr["class"] = cclass.Text;
                dr["dept"] = cdept.Text;
                dr["ph_no"] = tphno.Text;
                dr["date"] = dateTimePicker1.Text;
                dr["device"] = cdevice.Text;
               
                dr["description"] = tdesc.Text;

                ds.Tables["exportdevice"].Rows.Add(dr);
                da.Update(ds.Tables["exportdevice"]);


                MessageBox.Show("All Data Saved Successfully");
                tsno.Text = "";
                tname.Text = "";
                cclass.Text = "";
                cdept.Text = "";
                cdevice.Text = "";
                dateTimePicker1.Text = "";
                tphno.Text = "";
                tdesc.Text = "";


                bsave.Enabled = false;//save button disabled
                bmodify.Enabled = false;
                bdelete.Enabled = false;
            }
        }

        private void lname_DoubleClick(object sender, EventArgs e)
        {
            dr = ds.Tables["exportdevice"].Rows[lname.SelectedIndex];
            tsno.Text = "" + dr[1];
            tname.Text = "" + dr[2];
            cclass.Text = "" + dr[3];
            cdept.Text = "" + dr[4];
            tphno.Text = "" + dr[5];
            dateTimePicker1.Text = "" + dr[6];
            cdevice.Text = "" + dr[7];
            tdesc.Text = "" + dr[8];

            bmodify.Enabled = true;
            bdelete.Enabled = true;

            badd.Enabled = false;
        }

        private void bmodify_Click(object sender, EventArgs e)
        {
            dr.BeginEdit();
            dr["sr_no"] = tsno.Text;
            dr["name"] = tname.Text;
            dr["class"] = cclass.Text;
            dr["dept"] = cdept.Text;
            dr["ph_no"] = tphno.Text;
            dr["date"] = dateTimePicker1.Text;
            dr["device"] = cdevice.Text;
            dr["description"] = tdesc.Text;
            
            dr.EndEdit();
            da.Update(ds.Tables["exportdevice"]);
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
            else if (dateTimePicker1.Text == "")
            {
                MessageBox.Show("Please select date");
                dateTimePicker1.Focus();
            }
            else if (tphno.Text == "")
            {
                MessageBox.Show("Please enter phone no.");
                tphno.Focus();
            }
            else if (tdesc.Text == "")
            {
                MessageBox.Show("Please enter description");
                tdesc.Focus();
            }
            else
            {
                MessageBox.Show("Data Upadated Successfully");
            }
        }

        private void bdelete_Click(object sender, EventArgs e)
        {
            dr.Delete();
            da.Update(ds.Tables["exportdevice"]);
            MessageBox.Show("Data Deleted Successfully");

            tsno.Text = "";
            tname.Text = "";
            cclass.Text = "";
            cdept.Text = "";
            cdevice.Text = "";
            dateTimePicker1.Text = "";
            tphno.Text = "";
            tdesc.Text = "";


            bmodify.Enabled = false;
            bdelete.Enabled = false;
            badd.Enabled = true;
            badd.Focus();
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

        DataRow dr;//add the data to database
        int count = 0, keyy;
        public ExportDevice()
        {
            InitializeComponent();
            this.ActiveControl = badd;
        }

        private void bexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
