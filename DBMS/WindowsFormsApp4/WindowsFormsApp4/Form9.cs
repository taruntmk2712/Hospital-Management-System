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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            this.Hide();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            Regex Myno = new Regex("^[0-9]{10}");
            Match nomat = Myno.Match(p_phone.Text);
            if (nomat.Success)
            {
                string connetionString = "Provider=OraOLEDB.Oracle;Data Source=orcl;User Id=SYSTEM;Password=T20a1run;";
                string sql = "SELECT * FROM patient";
                OleDbConnection connection = new OleDbConnection(connetionString);
                OleDbDataAdapter dataadapter = new OleDbDataAdapter(sql, connection);
                DataSet ds = new DataSet();
                connection.Open();
                dataadapter.Fill(ds, "patient");

                string sql1 = "Update patient set p_id='" + p_id.Text + "',p_name='" + p_name.Text + "', p_phone='" + p_phone.Text + "', p_address='" + p_address.Text + "' ,p_gender='" + p_gender.Text + "',p_dob='"+p_dob.Text+"' where p_id='" + p_id.Text + "'";
                dataadapter.UpdateCommand = new OleDbCommand(sql1, connection);
                dataadapter.Update(ds, "patient");
                dataadapter.UpdateCommand.ExecuteNonQuery();
                MessageBox.Show("Row(s) Updated !! ");
                connection.Close();
            }
            else
                MessageBox.Show("Invalid Phone No. !!!");

        }

        private void Form9_Load(object sender, EventArgs e)
        {

        }
    }
}
