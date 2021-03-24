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
    public partial class RecordForm : Form
    {
        string connectString = "Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = PBL; Integrated Security = True;";
        SqlConnection connection;
        SqlDataAdapter adapt;
        DataTable table;

        public RecordForm()
        {
            InitializeComponent();
            connection = new SqlConnection(connectString);
            connection.Open();
            string queryString = "SELECT * FROM infoPBL;";
            SqlCommand command1 = new SqlCommand(queryString, connection);
            adapt = new SqlDataAdapter(queryString, connection);
            table = new DataTable();
            adapt.Fill(table);
            this.dataGridView1.DataSource = table;
            command1.ExecuteNonQuery();
            dataGridView1.BackColor = Color.WhiteSmoke;
            string surveyString = "SELECT * FROM surveyPBL;";
            SqlCommand command2 = new SqlCommand(surveyString, connection);
            adapt = new SqlDataAdapter(surveyString, connection);
            table = new DataTable();
            adapt.Fill(table);
            this.dataGridView2.DataSource = table;
            command2.ExecuteNonQuery();
            dataGridView2.BackColor = Color.WhiteSmoke;
            connection.Close();
        }

        private void RecordForm_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            connection = new SqlConnection(connectString);
            connection.Open();
            string queryString = "SELECT * FROM infoPBL;";
            SqlCommand command = new SqlCommand(queryString, connection);
            adapt = new SqlDataAdapter(queryString, connection);
            table = new DataTable();
            adapt.Fill(table);
            this.dataGridView1.DataSource = table;
            command.ExecuteNonQuery();
            connection.Close();
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            connection = new SqlConnection(connectString);
            connection.Open();
            adapt = new SqlDataAdapter("SELECT * FROM infoPBL WHERE Name LIKE '" + textBox1.Text + "%'", connection);
            table = new DataTable();
            adapt.Fill(table);
            dataGridView1.DataSource = table;
            adapt = new SqlDataAdapter("SELECT * FROM surveyPBL WHERE Name LIKE '" + textBox1.Text + "%'", connection);
            table = new DataTable();
            adapt.Fill(table);
            dataGridView2.DataSource = table;
            connection.Close();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            connection = new SqlConnection(connectString);
            connection.Open();
            adapt = new SqlDataAdapter("SELECT * FROM infoPBL WHERE CinemaNumber = 1", connection);
            table = new DataTable();
            adapt.Fill(table);
            dataGridView1.DataSource = table;
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            connection = new SqlConnection(connectString);
            connection.Open();
            adapt = new SqlDataAdapter("SELECT * FROM infoPBL WHERE CinemaNumber = 2", connection);
            table = new DataTable();
            adapt.Fill(table);
            dataGridView1.DataSource = table;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            connection = new SqlConnection(connectString);
            connection.Open();
            adapt = new SqlDataAdapter("SELECT * FROM infoPBL WHERE Time = '11:00AM' AND CinemaNumber = 1", connection);
            table = new DataTable();
            adapt.Fill(table);
            dataGridView1.DataSource = table;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            connection = new SqlConnection(connectString);
            connection.Open();
            adapt = new SqlDataAdapter("SELECT * FROM infoPBL WHERE Time = '4:00PM' AND CinemaNumber = 1", connection);
            table = new DataTable();
            adapt.Fill(table);
            dataGridView1.DataSource = table;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            connection = new SqlConnection(connectString);
            connection.Open();
            adapt = new SqlDataAdapter("SELECT * FROM infoPBL WHERE Time = '11:00AM' AND CinemaNumber = 2", connection);
            table = new DataTable();
            adapt.Fill(table);
            dataGridView1.DataSource = table;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            connection = new SqlConnection(connectString);
            connection.Open();
            adapt = new SqlDataAdapter("SELECT * FROM infoPBL WHERE Time = '4:00PM' AND CinemaNumber = 2", connection);
            table = new DataTable();
            adapt.Fill(table);
            dataGridView1.DataSource = table;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string name = " ";
            //string nem = "";
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                name = row.Cells[0].Value.ToString();
                textBox2.Text = name;
            }
            textBox2.Text = name;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult confirm = MessageBox.Show("Are you sure you want to delete this Record?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm == DialogResult.Yes)
            {
               string connectionString = "Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = PBL; Integrated Security = True;";

                connection = new SqlConnection(connectionString);
                foreach (DataGridViewCell selectedCell in dataGridView1.SelectedCells)
                {
                    if (selectedCell.Selected)
                    {
                        //dataGridView1.Rows.RemoveAt(selectedCell.RowIndex);
                        try
                        {
                            connection.Open();
                            SqlCommand cmd = new SqlCommand("DELETE FROM infoPBL WHERE Name = @Name", connection);

                            cmd.Parameters.AddWithValue("@Name", textBox2.Text);

                            cmd.ExecuteNonQuery();
                            SqlCommand cmb = new SqlCommand("DELETE FROM surveyPBL WHERE Name = @Name", connection);

                            cmb.Parameters.AddWithValue("@Name", textBox2.Text);

                            cmb.ExecuteNonQuery();

                            dataGridView1.Update();
                            dataGridView1.Refresh();
                            dataGridView2.Update();
                            dataGridView2.Refresh();
                            MessageBox.Show("Deleted Successfully!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            connection.Close();
                            connection = new SqlConnection(connectString);
                            connection.Open();
                            string queryString = "SELECT * FROM infoPBL;";
                            SqlCommand command = new SqlCommand(queryString, connection);
                            adapt = new SqlDataAdapter(queryString, connection);
                            table = new DataTable();
                            adapt.Fill(table);
                            this.dataGridView1.DataSource = table;
                            command.ExecuteNonQuery();
                            string surveyString = "SELECT * FROM surveyPBL;";
                            SqlCommand commando = new SqlCommand(surveyString, connection);
                            adapt = new SqlDataAdapter(surveyString, connection);
                            table = new DataTable();
                            adapt.Fill(table);
                            this.dataGridView2.DataSource = table;
                            connection.Close();
                            textBox2.Text = string.Empty;
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }

                }
            }
        }
    }
}
