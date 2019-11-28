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
    public partial class Form17 : Form
    {
        public Form17()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string connetionString = "Provider=OraOLEDB.Oracle;Data Source=orcl;User Id=SYSTEM;Password=T20a1run;";
            string sql = "select * from patient p, attends a where a.d_id='" + textBox1.Text + "'and a.p_id=p.p_id ";
            OleDbConnection connection = new OleDbConnection(connetionString);
            OleDbDataAdapter dataadapter = new OleDbDataAdapter(sql, connection);
            DataSet ds1 = new DataSet();
            connection.Open();
            dataadapter.Fill(ds1, "department");
            connection.Close();
            dataGridView1.DataSource = ds1;
            dataGridView1.DataMember = "department";
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            this.Hide();
        }
    }
}
