using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace STAGE1
{
    public partial class Start_Game : Form
    {
        public Start_Game()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
           STAGE1Frame s= new STAGE1Frame(0);
            s.Closed += (a, args) => this.Close();
            s.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            STAGE1Frame s = new STAGE1Frame(1);
            s.Closed += (a, args) => this.Close();
            s.Show();

        }
    }
}
