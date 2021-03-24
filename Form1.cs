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
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
            design();
        }
        private void design()
        {
            //Hides Panel of View and Help
            panelView.Visible = false;
            panelHelp.Visible = false;
        }

        private void hideSubMenu()
        {
            //Hides if One of the Panel is Open
            if (panelView.Visible == true)
                panelView.Visible = false;
            if (panelHelp.Visible == true)
                panelHelp.Visible = false;
        }

        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }
        //Movie Button
        private void buttonMovie_Click_1(object sender, EventArgs e)
        {
            comboBox1.Text = " ";
            comboBox2.Text = " ";
            pictureBox3.Visible = false;
            this.comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            this.comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            panelMain.BringToFront();
            hideSubMenu();
            panelMain.Visible = true;
            seat1Button.Visible = true;
            seat2Button.Visible = true;
            seat3Button.Visible = true;
            seat4Button.Visible = true;

        }
        //View Button
        private void buttonView_Click(object sender, EventArgs e)
        {
            showSubMenu(panelView);
        }
        private void buttonViewSeats_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void buttonViewRecords_Click(object sender, EventArgs e)
        {
            recordPanel.BringToFront();
            hideSubMenu();
        }

        //Submit Button
        private void button1_Click_1(object sender, EventArgs e)
        {
            string time = comboBox1.Text;
            if (time == "11:00AM")
            {
                seat1Button.BringToFront();
            }
            if (time == "4:00PM")
            {
                seat2Button.BringToFront();
            }
            string time2 = comboBox2.Text;
            if (time2 == "11:00AM")
            {
                seat3Button.BringToFront();
            }
            if (time2 == "4:00PM")
            {
                seat4Button.BringToFront();
                //openForm(new Seatform4(panelMain));
            }
            //if (time == " " || time2 == " ")
            //{
            //    MessageBox.Show("Invalid Time Entry! Please Try Again.", "Invalid Entry", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return;
            //}
        }
        //Help Button
        private void buttonHelp_Click(object sender, EventArgs e)
        {
            showSubMenu(panelHelp);
        }

        private Form activeForm = null;

        private void openForm(Form panelForm, Panel panelName)
        {
           // if (activeForm != null)
              //  activeForm.Close();
            activeForm = panelForm;
            panelForm.TopLevel = false;
            panelForm.FormBorderStyle = FormBorderStyle.None;
            panelForm.Dock = DockStyle.Fill;
            panelName.Controls.Add(panelForm);
            panelName.Tag = panelForm;
            panelForm.BringToFront();
            panelForm.Show();
            //recordPanel.BringToFront();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Text = " ";
            comboBox2.Text = " ";
            pictureBox3.Visible = false;
            this.comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            this.comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            panelMain.BringToFront();
            //hideSubMenu();
            openForm(new RecordForm(), recordPanel);
            openForm(new SeatForm2(), rulePanel);
            openForm(new SeatForm(), aboutPanel);
            //RecordForm aForm = new RecordForm();
            //aForm.Show();
            hideSubMenu();
        }
        string cinema1 = "1", cinema2 = "2";
        //Cinema1SeatControl
        private void button1_Click(object sender, EventArgs e)
        {
            buttonClick("A1", cinema1, time1, panel2);
          //  panelMain.BringToFront();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            buttonClick("A2", cinema1, time1, panel2);
           // panelMain.BringToFront();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            buttonClick("A3", cinema1, time1, panel2);
          //  panelMain.BringToFront();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            buttonClick("A4", cinema1, time1, panel2);
           // panelMain.BringToFront();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            buttonClick("A5", cinema1, time1, panel2);
           // panelMain.BringToFront();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            buttonClick("A6", cinema1, time1, panel2);
           // panelMain.BringToFront();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            buttonClick("A7", cinema1, time1, panel2);
         //   panelMain.BringToFront();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            buttonClick("A8", cinema1, time1, panel2);
          //  panelMain.BringToFront();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            buttonClick("A9", cinema1, time1, panel2);
          //  panelMain.BringToFront();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            buttonClick("A10", cinema1, time1, panel2);
          //  panelMain.BringToFront();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            buttonClick("B1", cinema1, time1, panel2);
          //  panelMain.BringToFront();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            buttonClick("B2", cinema1, time1, panel2);
          //  panelMain.BringToFront();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            buttonClick("B3", cinema1, time1, panel2);
           // panelMain.BringToFront();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            buttonClick("B4", cinema1, time1, panel2);
           // panelMain.BringToFront();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            buttonClick("B5", cinema1, time1, panel2);
           // panelMain.BringToFront();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            buttonClick("B6", cinema1, time1, panel2);
           // panelMain.BringToFront();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            buttonClick("B7", cinema1, time1, panel2);
           // panelMain.BringToFront();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            buttonClick("B8", cinema1, time1, panel2);
          //  panelMain.BringToFront();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            buttonClick("B9", cinema1, time1, panel2);
           // panelMain.BringToFront();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            buttonClick("B10", cinema1, time1, panel2);
           // panelMain.BringToFront();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            buttonClick("C1", cinema1, time1, panel2);
           // panelMain.BringToFront();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            buttonClick("C2", cinema1, time1, panel2);
          //  panelMain.BringToFront();
        }

        private void button23_Click(object sender, EventArgs e)
        {
            buttonClick("C3", cinema1, time1, panel2);
         //   panelMain.BringToFront();
        }

        private void button24_Click(object sender, EventArgs e)
        {
            buttonClick("C4", cinema1, time1, panel2);
          //  panelMain.BringToFront();
        }

        private void button25_Click(object sender, EventArgs e)
        {
            buttonClick("C5", cinema1, time1, panel2);
         //   panelMain.BringToFront();
        }

        private void button26_Click(object sender, EventArgs e)
        {
            buttonClick("C6", cinema1, time1, panel2);
          //  panelMain.BringToFront();
        }

        private void button27_Click(object sender, EventArgs e)
        {
            buttonClick("C7", cinema1, time1, panel2);
          //  panelMain.BringToFront();
        }

        private void button28_Click(object sender, EventArgs e)
        {
            buttonClick("C8", cinema1, time1, panel2);
          //  panelMain.BringToFront();
        }

        private void button29_Click(object sender, EventArgs e)
        {
            buttonClick("C9", cinema1, time1, panel2);
         //   panelMain.BringToFront();
        }

        private void button30_Click(object sender, EventArgs e)
        {
            buttonClick("C10", cinema1, time1, panel2);
       //     panelMain.BringToFront();
        }

        private void cinemaOneBtn_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void c1AM_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            seat1Button.BringToFront();
        }

        private void c1PM_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            seat2Button.BringToFront();
        }

        private void cinemaTwoBtn_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void c2AM_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            seat3Button.BringToFront();
        }

        private void c2PM_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            seat4Button.BringToFront();
        }

        private void ruleBtn_Click(object sender, EventArgs e)
        {
            //SeatForm2 aForm = new SeatForm2();
            //aForm.Show();
            rulePanel.BringToFront();
            hideSubMenu();
        }

        private void button90_Click(object sender, EventArgs e)
        {
            buttonClick("A1", cinema1, time2, panel5);
         //   panelMain.BringToFront();
        }

        private void button89_Click(object sender, EventArgs e)
        {
            buttonClick("A2", cinema1, time2, panel5);
          //  panelMain.BringToFront();
            
        }

        private void button87_Click(object sender, EventArgs e)
        {
            buttonClick("A3", cinema1, time2, panel5);
         //   panelMain.BringToFront();
        }

        private void button84_Click(object sender, EventArgs e)
        {
            buttonClick("A4", cinema1, time2, panel5);
          //  panelMain.BringToFront();
        }

        private void button81_Click(object sender, EventArgs e)
        {
            buttonClick("A5", cinema1, time2, panel5);
          //  panelMain.BringToFront();
        }

        private void button78_Click(object sender, EventArgs e)
        {
            buttonClick("A6", cinema1, time2, panel5);
         //   panelMain.BringToFront();
        }

        private void button75_Click(object sender, EventArgs e)
        {
            buttonClick("A7", cinema1, time2, panel5);
          //  panelMain.BringToFront();
        }

        private void button72_Click(object sender, EventArgs e)
        {
            buttonClick("A8", cinema1, time2, panel5);
          //  panelMain.BringToFront();
        }

        private void button69_Click(object sender, EventArgs e)
        {
            buttonClick("A9", cinema1, time2, panel5);
          //  panelMain.BringToFront();
        }

        private void button66_Click(object sender, EventArgs e)
        {
            buttonClick("A10", cinema1, time2, panel5);
           // panelMain.BringToFront();
        }

        private void button88_Click(object sender, EventArgs e)
        {
            buttonClick("B1", cinema1, time2, panel5);
         //   panelMain.BringToFront();
        }

        private void button85_Click(object sender, EventArgs e)
        {
            buttonClick("B2", cinema1, time2, panel5);
         //   panelMain.BringToFront();
        }

        private void button82_Click(object sender, EventArgs e)
        {
            buttonClick("B3", cinema1, time2, panel5);
           // panelMain.BringToFront();
        }

        private void button79_Click(object sender, EventArgs e)
        {
            buttonClick("B4", cinema1, time2, panel5);
          //  panelMain.BringToFront();
        }

        private void button76_Click(object sender, EventArgs e)
        {
            buttonClick("B5", cinema1, time2, panel5);
           // panelMain.BringToFront();
        }

        private void button73_Click(object sender, EventArgs e)
        {
            buttonClick("B6", cinema1, time2, panel5);
           // panelMain.BringToFront();
        }

        private void button70_Click(object sender, EventArgs e)
        {
            buttonClick("B7", cinema1, time2, panel5);
           // panelMain.BringToFront();
        }

        private void button67_Click(object sender, EventArgs e)
        {
            buttonClick("B8", cinema1, time2, panel5);
          //  panelMain.BringToFront();
        }

        private void button64_Click(object sender, EventArgs e)
        {
            buttonClick("B9", cinema1, time2, panel5);
          //  panelMain.BringToFront();
        }

        private void button63_Click(object sender, EventArgs e)
        {
            buttonClick("B10", cinema1, time2, panel5);
          //  panelMain.BringToFront();
        }

        private void button86_Click(object sender, EventArgs e)
        {
            buttonClick("C1", cinema1, time2, panel5);
           // panelMain.BringToFront();
        }

        private void button83_Click(object sender, EventArgs e)
        {
            buttonClick("C2", cinema1, time2, panel5);
           // panelMain.BringToFront();
        }

        private void button80_Click(object sender, EventArgs e)
        {
            buttonClick("C3", cinema1, time2, panel5);
          //  panelMain.BringToFront();
        }

        private void button77_Click(object sender, EventArgs e)
        {
            buttonClick("C4", cinema1, time2, panel5);
           // panelMain.BringToFront();
        }

        private void button74_Click(object sender, EventArgs e)
        {
            buttonClick("C5", cinema1, time2, panel5);
           // panelMain.BringToFront();
        }

        private void button71_Click(object sender, EventArgs e)
        {
            buttonClick("C6", cinema1, time2, panel5);
           // panelMain.BringToFront();
        }

        private void button68_Click(object sender, EventArgs e)
        {
            buttonClick("C7", cinema1, time2, panel5);
           // panelMain.BringToFront();
        }

        private void button65_Click(object sender, EventArgs e)
        {
            buttonClick("C8", cinema1, time2, panel5);
            //panelMain.BringToFront();
        }

        private void button62_Click(object sender, EventArgs e)
        {
            buttonClick("C9", cinema1, time2, panel5);
           // panelMain.BringToFront();
        }

        private void button61_Click(object sender, EventArgs e)
        {
            buttonClick("C10", cinema1, time2, panel5);
           // panelMain.BringToFront();
        }

        private void aboutUsBtn_Click(object sender, EventArgs e)
        {
            aboutPanel.BringToFront();
            hideSubMenu();
        }

        string time1 = "11:00AM", time2 = "4:00PM";
        //Cinema2SeatControl
        private void button119_Click(object sender, EventArgs e)
        {
            buttonClick("A2", cinema2, time1, panel6);
        }

        private void button117_Click(object sender, EventArgs e)
        {
            buttonClick("A3", cinema2, time1, panel6);
        }

        private void button114_Click(object sender, EventArgs e)
        {
            buttonClick("A4", cinema2, time1, panel6);
        }

        private void button111_Click(object sender, EventArgs e)
        {
            buttonClick("A5", cinema2, time1, panel6);
        }

        private void button108_Click(object sender, EventArgs e)
        {
            buttonClick("A6", cinema2, time1, panel6);
        }

        private void button105_Click(object sender, EventArgs e)
        {
            buttonClick("A7", cinema2, time1, panel6);
        }

        private void button102_Click(object sender, EventArgs e)
        {
            buttonClick("A8", cinema2, time1, panel6);
        }

        private void button99_Click(object sender, EventArgs e)
        {
            buttonClick("A9", cinema2, time1, panel6);
        }

        private void button96_Click(object sender, EventArgs e)
        {
            buttonClick("A10", cinema2, time1, panel6);
        }

        private void button118_Click(object sender, EventArgs e)
        {
            buttonClick("B1", cinema2, time1, panel6);
        }

        private void button115_Click(object sender, EventArgs e)
        {
            buttonClick("B2", cinema2, time1, panel6);
        }

        private void button112_Click(object sender, EventArgs e)
        {
            buttonClick("B3", cinema2, time1, panel6);
        }

        private void button109_Click(object sender, EventArgs e)
        {
            buttonClick("B4", cinema2, time1, panel6);
        }

        private void button106_Click(object sender, EventArgs e)
        {
            buttonClick("B5", cinema2, time1, panel6);
        }

        private void button103_Click(object sender, EventArgs e)
        {
            buttonClick("B6", cinema2, time1, panel6);
        }

        private void button100_Click(object sender, EventArgs e)
        {
            buttonClick("B7", cinema2, time1, panel6);
        }

        private void button97_Click(object sender, EventArgs e)
        {
            buttonClick("B8", cinema2, time1, panel6);
        }

        private void button94_Click(object sender, EventArgs e)
        {
            buttonClick("B9", cinema2, time1, panel6);
        }

        private void button93_Click(object sender, EventArgs e)
        {
            buttonClick("B10", cinema2, time1, panel6);
        }

        private void button116_Click(object sender, EventArgs e)
        {
            buttonClick("C1", cinema2, time1, panel6);
        }

        private void button113_Click(object sender, EventArgs e)
        {
            buttonClick("C2", cinema2, time1, panel6);
        }

        private void button110_Click(object sender, EventArgs e)
        {
            buttonClick("C3", cinema2, time1, panel6);
        }

        private void button107_Click(object sender, EventArgs e)
        {
            buttonClick("C4", cinema2, time1, panel6);
        }

        private void button104_Click(object sender, EventArgs e)
        {
            buttonClick("C5", cinema2, time1, panel6);
        }

        private void button101_Click(object sender, EventArgs e)
        {
            buttonClick("C6", cinema2, time1, panel6);
        }

        private void button98_Click(object sender, EventArgs e)
        {
            buttonClick("C7", cinema2, time1, panel6);
        }

        private void button95_Click(object sender, EventArgs e)
        {
            buttonClick("C8", cinema2, time1, panel6);
        }

        private void button92_Click(object sender, EventArgs e)
        {
            buttonClick("C9", cinema2, time1, panel6);
        }

        private void button91_Click(object sender, EventArgs e)
        {
            buttonClick("C10", cinema2, time1, panel6);
        }

        private void button60_Click(object sender, EventArgs e)
        {
            buttonClick("A1", cinema2, time2, panel3);
        }

        private void button59_Click(object sender, EventArgs e)
        {
            buttonClick("A2", cinema2, time2, panel3);
        }

        private void button57_Click(object sender, EventArgs e)
        {
            buttonClick("A3", cinema2, time2, panel3);
        }

        private void button54_Click(object sender, EventArgs e)
        {
            buttonClick("A4", cinema2, time2, panel3);
        }

        private void button51_Click(object sender, EventArgs e)
        {
            buttonClick("A5", cinema2, time2, panel3);
        }

        private void button48_Click(object sender, EventArgs e)
        {
            buttonClick("A6", cinema2, time2, panel3);
        }

        private void button45_Click(object sender, EventArgs e)
        {
            buttonClick("A7", cinema2, time2, panel3);
        }

        private void button42_Click(object sender, EventArgs e)
        {
            buttonClick("A8", cinema2, time2, panel3);
        }

        private void button39_Click(object sender, EventArgs e)
        {
            buttonClick("A9", cinema2, time2, panel3);
        }

        private void button36_Click(object sender, EventArgs e)
        {
            buttonClick("A10", cinema2, time2, panel3);
        }

        private void button58_Click(object sender, EventArgs e)
        {
            buttonClick("B1", cinema2, time2, panel3);
        }

        private void button55_Click(object sender, EventArgs e)
        {
            buttonClick("B2", cinema2, time2, panel3);
        }

        private void button52_Click(object sender, EventArgs e)
        {
            buttonClick("B3", cinema2, time2, panel3);
        }

        private void button49_Click(object sender, EventArgs e)
        {
            buttonClick("B4", cinema2, time2, panel3);
        }

        private void button46_Click(object sender, EventArgs e)
        {
            buttonClick("B5", cinema2, time2, panel3);
        }

        private void button43_Click(object sender, EventArgs e)
        {
            buttonClick("B6", cinema2, time2, panel3);
        }

        private void button40_Click(object sender, EventArgs e)
        {
            buttonClick("B7", cinema2, time2, panel3);
        }

        private void button37_Click(object sender, EventArgs e)
        {
            buttonClick("B8", cinema2, time2, panel3);
        }

        private void button34_Click(object sender, EventArgs e)
        {
            buttonClick("B9", cinema2, time2, panel3);
        }

        private void button33_Click(object sender, EventArgs e)
        {
            buttonClick("B10", cinema2, time2, panel3);
        }

        private void button56_Click(object sender, EventArgs e)
        {
            buttonClick("C1", cinema2, time2, panel3);
        }

        private void button53_Click(object sender, EventArgs e)
        {
            buttonClick("C2", cinema2, time2, panel3);
        }

        private void button50_Click(object sender, EventArgs e)
        {
            buttonClick("C3", cinema2, time2, panel3);
        }

        private void button47_Click(object sender, EventArgs e)
        {
            buttonClick("C4", cinema2, time2, panel3);
        }

        private void button44_Click(object sender, EventArgs e)
        {
            buttonClick("C5", cinema2, time2, panel3);
        }

        private void button41_Click(object sender, EventArgs e)
        {
            buttonClick("C6", cinema2, time2, panel3);
        }

        private void button38_Click(object sender, EventArgs e)
        {
            buttonClick("C7", cinema2, time2, panel3);
        }

        private void button35_Click(object sender, EventArgs e)
        {
            buttonClick("C8", cinema2, time2, panel3);
        }

        private void button32_Click(object sender, EventArgs e)
        {
            buttonClick("C9", cinema2, time2, panel3);
        }

        private void button31_Click(object sender, EventArgs e)
        {
            buttonClick("C10", cinema2, time2, panel3);
        }

        private void button120_Click(object sender, EventArgs e)
        {
            buttonClick("A1", cinema2, time1, panel6);
        }

        private void buttonClick(string seatNumber, string cinema, string time, Panel panelName)
        {
            string seatNum = seatNumber;
            string ciNum = cinema;
            string timeNum = time;
            foreach (Control button in panelName.Controls.OfType<Button>())
            {
                if (button.Text == seatNum)
                {
                    button.BackColor = Color.Red;
                    button.Enabled = false;
                }
            }
            //openForm(new GetInfoForm(cinema, time, seatNum), recordPanel);
            //recordPanel.BringToFront();
            GetInfoForm aForm = new GetInfoForm(cinema, time, seatNum);
            aForm.Show();
            panelMain.BringToFront();
        }
    }
}
