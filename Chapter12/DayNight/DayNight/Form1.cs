using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DayNight
{
    public partial class DayNightForm : Form
    {
        public DayNightForm()
        {
            InitializeComponent();
        }

        private void DayButton_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Yellow;
        }

        private void NightButton_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.DarkBlue;
        }
    }
}
