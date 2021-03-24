using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL_1st_Sem_Gr12
{
    public partial class Seatform3 : Form
    {
        Panel panel1;
        public Seatform3(Panel panForm)
        {
            InitializeComponent();
            panel1 = panForm;
        }

        string cinema = "2";
        string time = "11:00AM";
        private void buttonClick(Button btn, string seatNumber)
        {
            string seatNum = seatNumber;
            btn.BackColor = Color.Red;
            openForm(new GetInfoForm(cinema, time, seatNum));

            this.Hide();
            // GetInfoForm aForm = new GetInfoForm(cinema, time);
            //aForm.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            buttonClick(button1, "A1");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            buttonClick(button2, "A2");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            buttonClick(button3, "A3");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            buttonClick(button4, "A4");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            buttonClick(button5, "A5");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            buttonClick(button6, "A6");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            buttonClick(button7, "A7");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            buttonClick(button8, "A8");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            buttonClick(button9, "A9");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            buttonClick(button10, "A10");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            buttonClick(button11, "B1");
        }

        private void button12_Click(object sender, EventArgs e)
        {
            buttonClick(button12, "B2");
        }

        private void button13_Click(object sender, EventArgs e)
        {
            buttonClick(button13, "B3");
        }

        private void button14_Click(object sender, EventArgs e)
        {
            buttonClick(button14, "B4");
        }

        private void button15_Click(object sender, EventArgs e)
        {
            buttonClick(button15, "B5");
        }

        private void button16_Click(object sender, EventArgs e)
        {
            buttonClick(button16, "B6");
        }

        private void button17_Click(object sender, EventArgs e)
        {
            buttonClick(button17, "B7");
        }

        private void button18_Click(object sender, EventArgs e)
        {
            buttonClick(button18, "B8");
        }

        private void button19_Click(object sender, EventArgs e)
        {
            buttonClick(button19, "B9");
        }

        private void button20_Click(object sender, EventArgs e)
        {
            buttonClick(button20, "B10");
        }

        private void button21_Click(object sender, EventArgs e)
        {
            buttonClick(button21, "C1");
        }

        private void button22_Click(object sender, EventArgs e)
        {
            buttonClick(button22, "C2");

        }

        private void button23_Click(object sender, EventArgs e)
        {
            buttonClick(button23, "C3");
        }

        private void button24_Click(object sender, EventArgs e)
        {
            buttonClick(button24, "C4");
        }

        private void button25_Click(object sender, EventArgs e)
        {
            buttonClick(button25, "C5");
        }

        private void button26_Click(object sender, EventArgs e)
        {
            buttonClick(button26, "C6");
        }

        private void button27_Click(object sender, EventArgs e)
        {
            buttonClick(button27, "C7");
        }

        private void button28_Click(object sender, EventArgs e)
        {
            buttonClick(button28, "C8");
        }

        private void button29_Click(object sender, EventArgs e)
        {
            buttonClick(button29, "C9");
        }

        private void button30_Click(object sender, EventArgs e)
        {
            buttonClick(button30, "C10");
        }

        private Form activeForm = null;

        private void openForm(Form panelForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = panelForm;
            panelForm.TopLevel = false;
            panelForm.FormBorderStyle = FormBorderStyle.None;
            panelForm.Dock = DockStyle.Fill;
            panel1.Controls.Add(panelForm);
            panel1.Tag = panelForm;
            panelForm.BringToFront();
            panelForm.Show();
        }

    }
}
