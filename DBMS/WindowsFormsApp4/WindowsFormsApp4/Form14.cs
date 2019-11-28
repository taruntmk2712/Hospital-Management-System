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
    public partial class Form14 : Form
    {
        public Form14()
        {
            InitializeComponent();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            string connetionString = "Provider=OraOLEDB.Oracle;Data Source=orcl;User Id=SYSTEM;Password=T20a1run;";

            OleDbConnection connection = new OleDbConnection(connetionString);
            
            connection.Open();
            string sql = "select count(*) from patient p, doctor d where p.p_id = '"+textBox1.Text+"' and d.d_id = '"+textBox2.Text+"'";

             OleDbDataAdapter dataadapter = new OleDbDataAdapter(sql, connection);
            DataTable dt = new DataTable();
            dataadapter.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                string sql1 = "Insert into attends VALUES ('" + textBox1.Text + "', '" + textBox2.Text + "' )";
                OleDbDataAdapter dataadapter1 = new OleDbDataAdapter(sql1, connection);
                dataadapter1.InsertCommand = new OleDbCommand(sql1, connection);
                dataadapter1.InsertCommand.ExecuteNonQuery();
                MessageBox.Show("Row(s) Inserted !! ");
                connection.Close();
            }
            else
            {
                MessageBox.Show("Record(s) not found!!");
            }

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            new Form12().Show();
            this.Hide();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            this.Hide();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }
    }
}
