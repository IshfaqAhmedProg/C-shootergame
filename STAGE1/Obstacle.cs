using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
namespace STAGE1
{
    class Obstacle:PictureBox
    {
        int speed=5;
        public Timer oT = new Timer();
        public Obstacle(int x,int y,Form form,Image image)
        {
            this.BackColor = Color.Transparent;
            this.Size = new Size(40, 80);
            this.Left = x;
            this.Top = y;
            this.Tag = "power";
            this.Image = image;
            form.Controls.Add(this);
            this.BringToFront();
           
        }
        public void oT_Tick(object sender, EventArgs e)
        {
            this.Top += speed;
        }
    }
}
