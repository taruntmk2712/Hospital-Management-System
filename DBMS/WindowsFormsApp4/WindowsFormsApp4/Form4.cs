using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Data.OleDb;

namespace WindowsFormsApp4
{
    public partial class Form4 : Form
    {
        
        DataSet ds;

        public void ConnectString()
        {
            string connetionString = "Provider=OraOLEDB.Oracle;Data Source=orcl;User Id=Shreyas;Password=bmscecse;";
            string sql = "SELECT * FROM patient";
            OleDbConnection connection = new OleDbConnection(connetionString);
            OleDbDataAdapter dataadapter = new OleDbDataAdapter(sql, connection);
            ds = new DataSet();
            connection.Open();
            dataadapter.Fill(ds, "patient");
            connection.Close();
        }

        public Form4()
        {
            InitializeComponent();
            
        }


        private void button1_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            this.Hide();
        }     

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void button2_Click(object sender, EventArgs e)
        {
            Regex Myno = new Regex("^[0-9]{10}");
            Match nomat = Myno.Match(p_phone.Text);

            if (nomat.Success)
            {
                string connetionString = "Provider=OraOLEDB.Oracle;Data Source=orcl;User Id=SYSTEM;Password=T20a1run;";
                string sql = "SELECT * FROM patient";
                OleDbConnection connection = new OleDbConnection(connetionString);
                OleDbDataAdapter dataadapter = new OleDbDataAdapter(sql, connection);
                ds = new DataSet();
                connection.Open();
                dataadapter.Fill(ds, "patient");

                string status = "in";
                string sql1 = "Insert into patient VALUES ('" + p_id.Text + "', '" + p_name.Text + "', '" + p_phone.Text + "', '" + p_add.Text + "','" + p_gender.Text + "','"+p_dob.Text+"','" + status + "' )";
                dataadapter.InsertCommand = new OleDbCommand(sql1, connection);
                dataadapter.InsertCommand.ExecuteNonQuery();
                MessageBox.Show("Row(s) Inserted !! ");
                connection.Close();

                new Form14().Show();
                this.Hide();
            }
            else {
                MessageBox.Show("Invalid Phone no. !!!");
                }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
