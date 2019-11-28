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
    public partial class Form16 : Form
    {
        public Form16()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string connetionString = "Provider=OraOLEDB.Oracle;Data Source=orcl;User Id=SYSTEM;Password=T20a1run;";
            string sql = "SELECT * FROM login";
            OleDbConnection connection = new OleDbConnection(connetionString);
            OleDbDataAdapter dataadapter = new OleDbDataAdapter(sql, connection);
            DataSet ds = new DataSet();
            connection.Open();
            string sql1 = "SELECT count(*) FROM login where username='"+textBox1.Text+"' and pwd='"+textBox2.Text+"'";

            OleDbCommand cmd = new OleDbCommand(sql1, connection);

            int check = Convert.ToInt32(cmd.ExecuteScalar());

            if (check == 1)
            {
                new Form1().Show();
                this.Hide();
            }
            else
                MessageBox.Show("Invalid username/password");
        }

        
    }
}
