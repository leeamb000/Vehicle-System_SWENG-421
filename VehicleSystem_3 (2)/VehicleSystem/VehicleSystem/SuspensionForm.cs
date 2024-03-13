using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VehicleSystem
{
    public partial class SuspensionForm : Form
    {
        public string type;
        public string cb1 = "", cb2 = "", cb3 = "";
        public SuspensionForm()
        {
            InitializeComponent();
            button2.Enabled = false;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void SuspensionForm_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            button2.Enabled = true;
        }

        private void strutCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void springCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            type = listBox1.SelectedItem.ToString();
            if (strutCheckBox.Checked) { cb1 = strutCheckBox.Text; }
            if (springCheckBox.Checked) { cb2 = springCheckBox.Text; }
            if(shockCheckBox.Checked) { cb3 = shockCheckBox.Text; }
            this.Close();
        }

        private void rearRadioButton_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
