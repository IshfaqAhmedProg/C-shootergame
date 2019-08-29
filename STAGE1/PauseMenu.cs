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
    public partial class PauseMenu : Form
    {
        STAGE1Frame p;
        public PauseMenu(STAGE1Frame s)
        {
            InitializeComponent();
            p = s;
        }

        public void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void button1_Click(object sender, EventArgs e)
        {
            this.Hide();

            p.DamageTimer.Start();
            p.DamageTimer.Enabled = true;

            p.gametimer.Start();
            p.gametimer.Enabled = true;
            p.HealthTimer.Start();
            p.HealthTimer.Enabled = true;
            p.BossAttack.Start();
            p.BossAttack.Enabled = true;
            p.bsT.Start();
            p.bsT.Enabled = true;
            p.Show();
        }
    }
}
