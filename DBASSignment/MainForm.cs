﻿using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBASSignment
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // فتح الفورم AddClient
            AddClientForm addClient = new AddClientForm();
            addClient.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddWorkerForm addWorker = new AddWorkerForm();
            addWorker.ShowDialog(); // يظهر الفورم ويوقف الرئيسي
        }
    }
}
