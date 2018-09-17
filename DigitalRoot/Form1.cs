using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DigitalRoot
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void RunBTN_Click(object sender, EventArgs e)
        {
            var testing = new DigitalRoot();

            if (NumberField.Text == string.Empty)
            {
                MessageBox.Show("Please enter a value number");
            }
            else
            {
                int result = testing.GetValue(Convert.ToInt32(NumberField.Text));
                DigitalRootResult.Text = $"Result: {result}";
            }

        }
    }
}
