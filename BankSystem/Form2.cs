using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankSystem
{
    public partial class Form2 : Form
    {
        Form1 ownerForm;
        public Form2(Form1 ownerForm, string answer)
        {
            ownerForm = ownerForm;
            InitializeComponent();
            textBox1.Text = answer;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
             
        }
    }
}
