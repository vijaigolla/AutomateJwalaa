﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CommunicateAutomate
{
    public partial class Child : Form
    {
        public Child()
        {
            InitializeComponent();
        }
        public event EventHandler OnChildTextChanged;
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (OnChildTextChanged != null)
                OnChildTextChanged(tbChild.Text, null);
        }

        
    }
}
