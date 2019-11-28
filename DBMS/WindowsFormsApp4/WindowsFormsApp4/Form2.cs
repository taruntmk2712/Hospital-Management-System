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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connetionString = "Provider=OraOLEDB.Oracle;Data Source=orcl;User Id=SYSTEM;Password=T20a1run;";
            //string sql = "select d.d_id, d.d_name, d.d_phone, d.d_address, d.d_gender, d.salary from doctor d, department dep, belongs b where d.d_id = b.d_id and dep.dep_id = b.dep_id and dep.dep_name ='" + comboBox1.Text + "'";
            string sql= "select d.d_id, d.d_name, d.d_phone, d.d_address, d.d_gender, d.salary from doctor d, department dep, belongs b where d.d_id = b.d_id and dep.dep_id = b.dep_id and dep.dep_name = '"+comboBox1.Text+"' ";
            OleDbConnection connection = new OleDbConnection(connetionString);
            OleDbDataAdapter dataadapter = new OleDbDataAdapter(sql, connection);
            DataSet ds1 = new DataSet();
            connection.Open();
            dataadapter.Fill(ds1,"department");
            connection.Close();
            dataGridView1.DataSource = ds1;
            dataGridView1.DataMember = "department";         
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        /*private void button3_Click(object sender, EventArgs e)
        {
            new Form15().Show();
            this.Hide();
        }*/
    }
}
