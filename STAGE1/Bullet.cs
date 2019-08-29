using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace STAGE1
{
    abstract class Bullet:PictureBox
    {
        protected int speed;
        public bool right;
        protected PictureBox pb = new PictureBox();
        public Timer Timer = new Timer();
        public int bulletLeft, bulletTop;
        abstract public void makebullet(Form form);
        abstract public void makebullet(int x, Form form);
        abstract public void Timer_Tick(object sender, EventArgs e);
    }
}
