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
    public partial class GetInfoForm : Form
    {
        public GetInfoForm(string stringCinema, string stringTime, string seatNumber)
        {
            InitializeComponent();
            comboBox2.Text = stringCinema;
            comboBox3.Text = stringTime;
            textBox6.Text = seatNumber;
            this.comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            this.comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            this.comboBox3.DropDownStyle = ComboBoxStyle.DropDownList;
            this.comboBox4.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // SUBMIT BUTTON CLICK
            string nameString = textBox1.Text;
            string ageString = textBox2.Text;
            string genderString = comboBox1.Text;
            string contactNumberString = textBox3.Text;
            string addressString = textBox4.Text;
            string emailString = textBox5.Text;
            string cinemaNumberString = comboBox2.Text;
            string seatNumberString = textBox6.Text;
            string timeString = comboBox3.Text;
            string dateString = comboBox4.Text;
            bool allPopulatedBool = nameString != string.Empty && ageString != string.Empty && genderString != string.Empty && contactNumberString != string.Empty && emailString != string.Empty && addressString != string.Empty && cinemaNumberString != string.Empty && timeString != string.Empty && seatNumberString != string.Empty && dateString != string.Empty;

            if (allPopulatedBool)
            {
                //Setup connection to database PBL
                string connectionString = "Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = PBL; Integrated Security = True;";
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
                string queryString = "INSERT INTO infoPBL VALUES(@Name, @Age, @Gender, @ContactNumber, @Address, @Email, @CinemaNumber, @SeatNumber, @Time, @Date)";
                SqlParameter param1 = new SqlParameter("@Name", nameString);
                SqlParameter param2 = new SqlParameter("@Age", int.Parse(ageString));
                SqlParameter param3 = new SqlParameter("@Gender", genderString);
                SqlParameter param4 = new SqlParameter("@ContactNumber", contactNumberString);
                SqlParameter param5 = new SqlParameter("@Address", addressString);
                SqlParameter param6 = new SqlParameter("@Email", emailString);
                SqlParameter param7 = new SqlParameter("@CinemaNumber", cinemaNumberString);
                SqlParameter param8 = new SqlParameter("@SeatNumber", seatNumberString);
                SqlParameter param9 = new SqlParameter("@Time", timeString);
                SqlParameter param10 = new SqlParameter("@Date", dateString);
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
                command.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Your information has been registered succesfully.", "New Registration", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Survey aForm = new Survey(nameString);
                aForm.Show();
                this.Hide();
            }
            if (!allPopulatedBool)
            {
                // This instance wherein not all fields are populated
                MessageBox.Show("Please fill out all information. ", "Incomplete Entry of Customer Details", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GetInfoForm_Load(object sender, EventArgs e)
        {

        }
    }
}
