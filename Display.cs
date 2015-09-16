﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyClock
{
    public partial class Display : Form
    {
        public Display()
        {
            InitializeComponent();
        }

        private void secTimer_Tick(object sender, EventArgs e)
        {
            SetDisplayTime();
        }

        private void Display_Load(object sender, EventArgs e)
        {
            SetDisplayTime();
        }

        private void SetDisplayTime() 
        {
            timeNow.Text = DateTime.Now.ToString("yyyy/MM/dd\nHH:mm:ss");
        }

        private void timeNow_Click(object sender, EventArgs e)
        {

        }
    }
}
