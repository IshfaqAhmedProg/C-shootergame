using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
namespace STAGE1
{
    class Obstacle2:Obstacle
    {
        public Timer oT2 = new Timer();
        public Obstacle2(int x, int y,Form form, Image image) : base(x, y, form, image)
        {
            this.Size=new Size(80,40);
        }
        public void oT2_Tick(object sender, EventArgs e)
        {
            this.Left -= 5;
        }
    }
}
