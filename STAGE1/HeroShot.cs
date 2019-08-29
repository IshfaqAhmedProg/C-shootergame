using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
namespace STAGE1
{
    class HeroShot: Bullet
    {
        override public void makebullet(Form form)
        {
            this.speed = 5;
            this.pb.BackColor = Color.Black;
            this.pb.Size = new Size(10, 10);
            this.pb.Tag = "bullet";
            this.pb.Left = bulletLeft;
            this.pb.Top = bulletTop;
            form.Controls.Add(pb);
            this.pb.BringToFront();
            this.pb.Image = Properties.Resources.Bullet;
            Timer.Interval = this.speed;
            Timer.Tick += new EventHandler(Timer_Tick);
            Timer.Start();
        }
        public override void makebullet(int x, Form form)
        {
            throw new NotImplementedException();
        }
        override public void Timer_Tick(object sender, EventArgs e)
        {
            if (right == true)
            {
                pb.Left += speed;
            }
            if (right == false)
            {
                pb.Left -= speed;
            }
            if (this.pb.Left < 0 || pb.Left > 810)
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
