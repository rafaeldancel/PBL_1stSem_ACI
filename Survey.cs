using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace PBL_1st_Sem_Gr12
{
    public partial class Survey : Form
    {
        public Survey(string nameTransfer)
        {
            InitializeComponent();
            textBox1.Text = nameTransfer;
        }
        string q1answer = "";
        string q2answer = "";
        string q3answer = "";
        string q4answer = "";
        string q5answer = "";
        string q6answer = "";
        string q7answer = "";
        string q8answer = "";
        string q9answer = "";
        string q10answer = "";
        string q11answer = "";

        
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            checkBox2.Checked = false;
            q1answer = "Yes";
        }
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            checkBox1.Checked = false;
            q1answer = "No";
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            checkBox4.Checked = false;
            q2answer = "Yes";
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            checkBox3.Checked = false;
            q2answer = "No";
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            checkBox6.Checked = false;
            q3answer = "Yes";
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            checkBox5.Checked = false;
            q3answer = "No";
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            checkBox8.Checked = false;
            q4answer = "Yes";
        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            checkBox7.Checked = false;
            q4answer = "No";
        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {
            checkBox10.Checked = false;
            q5answer = "Yes";
        }

        private void checkBox10_CheckedChanged(object sender, EventArgs e)
        {
            checkBox9.Checked = false;
            q5answer = "No";
        }

        private void checkBox11_CheckedChanged(object sender, EventArgs e)
        {
            checkBox12.Checked = false;
            q6answer = "Yes";
        }

        private void checkBox12_CheckedChanged(object sender, EventArgs e)
        {
            checkBox11.Checked = false;
            q6answer = "No";
        }

        private void checkBox13_CheckedChanged(object sender, EventArgs e)
        {
            checkBox14.Checked = false;
            q7answer = "Yes";
        }

        private void checkBox14_CheckedChanged(object sender, EventArgs e)
        {
            checkBox13.Checked = false;
            q7answer = "No";
        }

        private void checkBox15_CheckedChanged(object sender, EventArgs e)
        {
            checkBox16.Checked = false;
            q8answer = "Yes";
        }

        private void checkBox16_CheckedChanged(object sender, EventArgs e)
        {
            checkBox15.Checked = false;
            q8answer = "No";
        }

        private void checkBox17_CheckedChanged(object sender, EventArgs e)
        {
            checkBox18.Checked = false;
            q9answer = "Yes";
        }

        private void checkBox18_CheckedChanged(object sender, EventArgs e)
        {
            checkBox17.Checked = false;
            q9answer = "No";
        }

        private void checkBox19_CheckedChanged(object sender, EventArgs e)
        {
            checkBox20.Checked = false;
            q10answer = "Yes";
        }

        private void checkBox20_CheckedChanged(object sender, EventArgs e)
        {
            checkBox19.Checked = false;
            q10answer = "No";
        }

        private void checkBox21_CheckedChanged(object sender, EventArgs e)
        {
            checkBox22.Checked = false;
            q11answer = "Yes";
        }

        private void checkBox22_CheckedChanged(object sender, EventArgs e)
        {
            checkBox21.Checked = false;
            q11answer = "No";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //dito nalang natin lagay yung mga sesend sa database
            string nameString = textBox1.Text;
            //ifelseStatement();
            string connectionString = "Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = PBL; Integrated Security = True;";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            string queryString = "INSERT INTO surveyPBL VALUES(@Name, @Q1, @Q2, @Q3, @Q4, @Q5, @Q6, @Q7, @Q8, @Q9, @Q10, @Q11)";
            SqlParameter param1 = new SqlParameter("@Name", nameString);
            SqlParameter param2 = new SqlParameter("@Q1", q1answer);
            SqlParameter param3 = new SqlParameter("@Q2", q2answer);
            SqlParameter param4 = new SqlParameter("@Q3", q3answer);
            SqlParameter param5 = new SqlParameter("@Q4", q4answer);
            SqlParameter param6 = new SqlParameter("@Q5", q5answer);
            SqlParameter param7 = new SqlParameter("@Q6", q6answer);
            SqlParameter param8 = new SqlParameter("@Q7", q7answer);
            SqlParameter param9 = new SqlParameter("@Q8", q8answer);
            SqlParameter param10 = new SqlParameter("@Q9", q9answer);
            SqlParameter param11 = new SqlParameter("@Q10", q10answer);
            SqlParameter param12 = new SqlParameter("@Q11", q11answer);
            SqlCommand command = new SqlCommand(queryString, connection);
            command.Parameters.Add(param1);
            command.Parameters.Add(param2);
            command.Parameters.Add(param3);
            command.Parameters.Add(param4);
            command.Parameters.Add(param5);
            command.Parameters.Add(param6);
            command.Parameters.Add(param7);
            command.Parameters.Add(param8);
            command.Parameters.Add(param9);
            command.Parameters.Add(param10);
            command.Parameters.Add(param11);
            command.Parameters.Add(param12);
            command.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Thank you for your cooperation.", "Covid Survey", MessageBoxButtons.OK, MessageBoxIcon.Information);
            checkBox1.Checked = false; checkBox2.Checked = false; checkBox3.Checked = false; checkBox4.Checked = false;
            checkBox5.Checked = false; checkBox6.Checked = false; checkBox7.Checked = false; checkBox8.Checked = false;
            checkBox9.Checked = false; checkBox10.Checked = false; checkBox11.Checked = false;
            this.Close();
            SeatForm2 aForm = new SeatForm2();
            aForm.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Survey_Load(object sender, EventArgs e)
        {

        }
    }
}
