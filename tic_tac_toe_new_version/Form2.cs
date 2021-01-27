using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tic_tac_toe_new_version
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        Timer t = new Timer();
        private void timer1_Tick(object sender, EventArgs e)
        {

           
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            t.Interval = 2500*(1);
            t.Start();
            t.Tick += new EventHandler(f);

        }
        private void f(object sender, EventArgs e)
        {
            t.Stop();
            Form3 F3 = new Form3();
            this.Hide();
            F3.ShowDialog();
            this.Close();
            
        }
    }
}
