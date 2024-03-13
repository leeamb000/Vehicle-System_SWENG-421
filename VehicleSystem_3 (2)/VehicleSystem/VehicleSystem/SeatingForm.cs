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
    public partial class SeatingCapacityForm : Form
    {
        public static int seats;
        public SeatingCapacityForm()
        {
            InitializeComponent();
            
        }

        private void SeatingCapacityForm_Load(object sender, EventArgs e)
        {
            
        }

        private void addSeatsBtn_Click(object sender, EventArgs e)
        {
            seats = (int)numericUpDown1.Value;
           
            this.Close();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            
        }
    }
}
