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
    public partial class Form11 : Form
    {
        DataSet ds;
        public Form11()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connetionString = "Provider=OraOLEDB.Oracle;Data Source=orcl;User Id=SYSTEM;Password=T20a1run;";
            string sql = "SELECT * FROM patient";
            OleDbConnection connection = new OleDbConnection(connetionString);
            OleDbDataAdapter dataadapter = new OleDbDataAdapter(sql, connection);
            ds = new DataSet();
            connection.Open();
            dataadapter.Fill(ds, "patient");
            int res = int.Parse(fee.Text) + int.Parse(lab.Text) + int.Parse(ward.Text) + int.Parse(icu.Text);
            label9.Text = res.ToString();
            string sql1 = "Insert into bill VALUES ('" + p_id.Text + "', '" + fee.Text + "', '" + lab.Text + "', '" + ward.Text + "','" + icu.Text + "','"+label9.Text+"')";
            dataadapter.InsertCommand = new OleDbCommand(sql1, connection);
            dataadapter.InsertCommand.ExecuteNonQuery();
            MessageBox.Show("Row(s) Inserted !! ");
            connection.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            this.Hide();
        }

        private void Form11_Load(object sender, EventArgs e)
        {

        }
    }
}
