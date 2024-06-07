using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ISAD_project_assignment
{
    public partial class splashFromcs : Form
    {
        public splashFromcs()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            circle.Value += 1;   
            if(circle.Value >= 100)
            {
                timer1.Stop();
                this.Hide();
                new signin().ShowDialog();
            }
        }
    }
}
