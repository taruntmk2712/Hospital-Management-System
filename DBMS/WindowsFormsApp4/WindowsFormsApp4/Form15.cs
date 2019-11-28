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
    public partial class Form15 : Form
    {
        DataSet ds;
        public Form15()
        {
            InitializeComponent();
        }
        public void ConnectString()
        {
            string connetionString = "Provider=OraOLEDB.Oracle;Data Source=orcl;User Id=SYSTEM;Password=T20a1run;";
            string sql = "SELECT * FROM department";
            OleDbConnection connection = new OleDbConnection(connetionString);
            OleDbDataAdapter dataadapter = new OleDbDataAdapter(sql, connection);
            ds = new DataSet();
            connection.Open();
            dataadapter.Fill(ds, "department");
            connection.Close();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Regex Myexp = new Regex(@"^[a-zA-Z0-9]+[a-zA-Z0-9\.]*[a-zA-Z0-9]+)@(gmail)\.{10}");
            Regex Myno = new Regex("^[0-9]{10}");
            Match nomat = Myno.Match(textBox5.Text);
            Match nmat = Myexp.Match(textBox3.Text);

            if (nmat.Success)
            {
                if (nomat.Success)
                { 
                    string connetionString = "Provider=OraOLEDB.Oracle;Data Source=orcl;User Id=SYSTEM;Password=T20a1run;";
                string sql = "SELECT * FROM department";
                OleDbConnection connection = new OleDbConnection(connetionString);
                OleDbDataAdapter dataadapter = new OleDbDataAdapter(sql, connection);
                ds = new DataSet();
                connection.Open();
                dataadapter.Fill(ds, "department");

                string sql1 = "Insert into department VALUES ('" + textBox1.Text + "', '" + textBox2.Text + "', '" + textBox3.Text + "', '" + textBox4.Text + "','" + textBox5.Text + "' )";
                dataadapter.InsertCommand = new OleDbCommand(sql1, connection);
                dataadapter.InsertCommand.ExecuteNonQuery();
                MessageBox.Show("Row(s) Inserted !! ");
                connection.Close();

                new Form15().Show();
                this.Hide();
            }
            else
                MessageBox.Show("Ivalid Phone No. !!!");
            }
            else
                MessageBox.Show("Invalid Email ID !!!");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            this.Hide();
        }
    }
}
