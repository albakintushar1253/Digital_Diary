﻿using Digital_Diary.Bussiness_Logic_layer;
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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void Home_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void createeventbutton_Click(object sender, EventArgs e)
        {
            CreateEvent ce = new CreateEvent();
            ce.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            

        }

        private void Home_Load(object sender, EventArgs e)
        {
            CreateEventService CES = new CreateEventService();
            loadCreateEventDataGridView.DataSource = CES.GetCreateEventsList();



        }

        private void modifybutton_Click(object sender, EventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }
    }
}
