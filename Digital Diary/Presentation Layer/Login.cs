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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void loginbutton_Click(object sender, EventArgs e)
        {
            if (usernametextBox.Text == "" || passwordtextBox.Text == "")
            {
                MessageBox.Show("Username or Password Can not be Empty !");
            }
            else   
            {
              // UserService us = new UserService();
              // bool result = us.LoginValidation(usernametextBox.Text, passwordtextBox.Text);

              //  if(result)
            //   {
                    Home h = new Home();
                    h.Show();
                    this.Hide();
              // }
              //else
                
                //   MessageBox.Show("Invalid Username or Password !");
                
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Registration registration = new Registration();
            registration.Show();
            this.Hide();
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
