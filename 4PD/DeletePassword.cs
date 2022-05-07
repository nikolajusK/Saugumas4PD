﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace PasswordManagerViko
{
    public partial class DeletePassword : Form
    {
        List<PassInfo> passList = new List<PassInfo>();
        Form1 currForm;
        public DeletePassword(List<PassInfo> pList, Form1 form)
        {
            passList = pList;
            currForm = form; 
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PassInfo a = null;
            a = passList.FirstOrDefault(x => x.name == textBox1.Text);
            // MessageBox.Show(a.ToString());
            if (a != null)
            {
                currForm.passList.Remove(a);
                currForm.LoadInfo(currForm.passList);
                MessageBox.Show("Istrinta");


            }
            else
            {
                MessageBox.Show("Nerasta");
            }
        }
    }
}
