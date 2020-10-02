using System;
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
    public partial class Parent : Form
    {
        public Parent()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Child child = new Child();
            child.OnChildTextChanged += new EventHandler(child_OnChildTextChanged);
            child.ShowDialog();
        }


        public event EventHandler OnForm1TextChanged;
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (OnForm1TextChanged != null)
                OnForm1TextChanged(tbParent.Text, null);
        }


        void child_OnChildTextChanged(object sender, EventArgs e)
        {
            tbParent.Text = (string)sender;
        }

      
    }

}
