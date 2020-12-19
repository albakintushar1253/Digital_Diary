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
    public partial class CreateEvent : Form
    {
        public CreateEvent()
        {
            InitializeComponent();
        }

        private void CreateEvent_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Home h = new Home();
            h.Show();
            this.Hide();
        }

        private void uploadImage_Click(object sender, EventArgs e)
        {
            String imageLocation = "";

            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "jpg files(*.jpg)|*.jpg| PNG files(*.png)|*.png| All Files(*.*)|*.*";

                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    imageLocation = dialog.FileName;

                    pictureBox1.ImageLocation = imageLocation;
                }

            }

            catch (Exception)
            {

                MessageBox.Show("An Error Occured", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        void Reset()
        {
            enametextbox.Text = comboBox.Text = edtextbox.Text = "";
        }

        private void savebutton_Click(object sender, EventArgs e)
        {
            CreateEventService CES = new CreateEventService();
           int result= CES.AddNewCreateEvent(enametextbox.Text, datepiker.Value, comboBox.Text, edtextbox.Text);
            MessageBox.Show("Save SSuccesfully !");
            Reset();

            
        }




    }
}
