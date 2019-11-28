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
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Regex Myno = new Regex("^[0-9]{10}");
            Match nomat = Myno.Match(d_phone.Text);

            if (nomat.Success)
            {
                string connetionString = "Provider=OraOLEDB.Oracle;Data Source=orcl;User Id=SYSTEM;Password=T20a1run;";
                string sql = "SELECT * FROM doctor";
                OleDbConnection connection = new OleDbConnection(connetionString);
                OleDbDataAdapter dataadapter = new OleDbDataAdapter(sql, connection);
                DataSet ds = new DataSet();
                connection.Open();
                dataadapter.Fill(ds, "doctor");

                string sql1 = "Update doctor set d_id='" + d_id.Text + "', d_name='" + d_name.Text + "',d_phone='" + d_phone.Text + "',d_address='" + d_address.Text + "',d_gender='" + d_gender.Text + "',salary='" + d_salary.Text + "',d_dfrom='" + d_dfrom.Text + "',d_dto='" + d_dto.Text + "' where d_id='" + d_id.Text + "'";
                dataadapter.UpdateCommand = new OleDbCommand(sql1, connection);
                dataadapter.Update(ds, "doctor");
                dataadapter.UpdateCommand.ExecuteNonQuery();
                MessageBox.Show("Row(s) Updated !! ");
                connection.Close();
            }
            else
                MessageBox.Show("Invalid Phone No. !!!");
        }
    }
}
