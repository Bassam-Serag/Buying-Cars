using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BuyCar
{
    public partial class Splash : Form
    {
        public Splash()
        {
            InitializeComponent();
            timer1.Start();
        }
        int start = 0;

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value == 100)
            {
                timer1.Stop();
                progressBar1.Value = 0;
                Login frm = new Login();
                frm.Show();
                this.Hide();

            }
            else
            {
                start += 2;
                progressBar1.Value = start;
                Precentge.Text = start + "%";
            }
        }

        private void Splash_Load(object sender, EventArgs e)
        {

        }
    }
}
