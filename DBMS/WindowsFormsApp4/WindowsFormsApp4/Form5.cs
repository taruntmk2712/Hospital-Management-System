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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new Form8().Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new Form10().Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connetionString = "Provider=OraOLEDB.Oracle;Data Source=orcl;User Id=SYSTEM;Password=T20a1run;";
            OleDbConnection connection = new OleDbConnection(connetionString);
            connection.Open();

            string sql = "select * from doctor where d_id='" + textBox1.Text + "'";
            OleDbDataAdapter dataadapter = new OleDbDataAdapter(sql, connection);
            DataTable dt = new DataTable();

            dataadapter.Fill(dt);

            dataGridView1.DataSource = dt;

            connection.Close();
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            new Form17().Show();
            this.Hide();
        }
    }
}
