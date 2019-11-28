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
using System.Text.RegularExpressions;
namespace WindowsFormsApp4
{
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            this.Hide();
        }
        public void ConnectString()
        {
            string connetionString = "Provider=OraOLEDB.Oracle;Data Source=orcl;User Id=SYSTEM;Password=T20a1run;";
            string sql = "SELECT * FROM doctor";
            OleDbConnection connection = new OleDbConnection(connetionString);
            OleDbDataAdapter dataadapter = new OleDbDataAdapter(sql, connection);
            DataSet ds = new DataSet();
            connection.Open();
            dataadapter.Fill(ds, "doctor");
            connection.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Regex Myno = new Regex("^[0-9]{10}");
            Match nomat = Myno.Match(d_phone.Text);

            if (nomat.Success)
            {
                string connetionString = "Provider=OraOLEDB.Oracle;Data Source=orcl;User Id=SYSTEM;Password=T20a1run;";
                string sql1 = "Insert into doctor VALUES ('" + d_id.Text + "', '" + d_name.Text + "', '" + d_phone.Text + "', '" + d_add.Text + "','" + d_gender.Text + "','" + d_sal.Text + "','" + d_dfrom.Text + "','" + d_dto.Text + "' )";
                OleDbConnection connection = new OleDbConnection(connetionString);
                OleDbDataAdapter dataadapter = new OleDbDataAdapter(sql1, connection);
                connection.Open();
                dataadapter.InsertCommand = new OleDbCommand(sql1, connection);
                dataadapter.InsertCommand.ExecuteNonQuery();
                MessageBox.Show("Row(s) Inserted !! ");
                connection.Close();
                new Form13().Show();
                this.Hide();
            }
            else
                MessageBox.Show("Invalid Phone No. !!!");
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.DEPARTMENT' table. You can move, or remove it, as needed.
            //this.dEPARTMENTTableAdapter.Fill(this.dataSet1.DEPARTMENT);

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
