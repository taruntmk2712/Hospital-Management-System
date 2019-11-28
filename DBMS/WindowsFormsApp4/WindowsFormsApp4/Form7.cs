using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace WindowsFormsApp4
{
    public partial class Form7 : Form
    {
     
        public Form7()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connetionString = "Provider=OraOLEDB.Oracle;Data Source=orcl;User Id=SYSTEM;Password=T20a1run;";
            OleDbConnection connection = new OleDbConnection(connetionString);
            connection.Open();

            

            string sql1 = "select count(*) from ward where p_id='" + textBox1.Text + "'";
            OleDbDataAdapter data1 = new OleDbDataAdapter(sql1, connection);
            OleDbDataAdapter data = new OleDbDataAdapter(sql1, connection);

            DataTable dt1 = new DataTable();
            data1.Fill(dt1);

            if (dt1.Rows[0][0].ToString()!="1")
            {
                MessageBox.Show("Record Not Found");
            }
            else
            {
                string sql_del_ward = "delete from ward where p_id='" + textBox1.Text + "'";
                OleDbCommand cmd = new OleDbCommand(sql_del_ward, connection);
                cmd.ExecuteNonQuery();

                string status = "out";

                string sql = "Update patient set p_status='"+status+"'  where p_id='" + textBox1.Text + "'";
                data.UpdateCommand = new OleDbCommand(sql, connection);
                data.UpdateCommand.ExecuteNonQuery();


                MessageBox.Show("Record Deleted");
            }

            connection.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            this.Hide();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
