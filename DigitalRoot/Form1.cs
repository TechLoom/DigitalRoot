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
            var Testing = new DigitalRoot();
            Testing.GetDigitalRoot(Convert.ToInt32(NumberField.Text));
        }
    }
}
