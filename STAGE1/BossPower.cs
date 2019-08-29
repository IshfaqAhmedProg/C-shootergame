using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace STAGE1
{
    class BossPower:Bullet
    {
        override public void makebullet(Form form)
        {
            this.speed = 5;
            pb.BackColor = Color.Transparent;
            pb.Size = new Size(20, 20);
            pb.Tag = "power";
            pb.Image = Properties.Resources.b1_fireball;
            pb.Left = bulletLeft;
            pb.Top = bulletTop;
            form.Controls.Add(pb);
            pb.BringToFront();
            Timer.Interval = speed;
            Timer.Tick += new EventHandler(Timer_Tick);
            Timer.Start();
        }
        override public void makebullet(int x, Form form)
        {
            throw new NotImplementedException();
        }
        override public void Timer_Tick(object sender, EventArgs e)
        {
            pb.Left -= speed;
            if (pb.Left < 0 || pb.Left > 810)
            {
                Timer.Stop();
                Timer.Dispose();
                pb.Dispose();
                Timer = null;
                pb = null;
            }
        }
    }
}
