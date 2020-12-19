using Digital_Diary.Bussiness_Logic_layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Digital_Diary.Presentation_Layer
{
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Login l = new Login();
            l.Show();
            this.Hide();
        }

        private void Registration_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }


        void Reset()
        {
            textBox1.Text= textBox2.Text= textBox3.Text= textBox4.Text= textBox5.Text=comboBox1.Text= comboBox2.Text = "";
        }
        private void button1_Click(object sender, EventArgs e)
        {

            UserService US = new UserService();
            int result = US.AddNewuser(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text, comboBox1.Text, comboBox2.Text);
            MessageBox.Show("Data Insert Succesfully !");
            Reset();

            Login ln = new Login();
            ln.Show();
            this.Hide();
        }
    }
}
