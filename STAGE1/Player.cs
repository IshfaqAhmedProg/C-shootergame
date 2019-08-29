using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace STAGE1
{
    public class Player
    {
        int  x,y;
        bool left, right, jump,crouch;
        int speed;
        int hp, damage;
        int ammo;
        public PictureBox player=new PictureBox();
        public void MakePlayer(int x,int y,int hp,int speed,int damage,Form form)
        {
            this.Hp = hp;
            this.Damage = damage;
            this.speed = speed;
            this.player.Top = y-(player.Height/2);
            this.player.Left = x - (player.Width / 2);
            this.player.BackColor = Color.Transparent;
            this.player.SizeMode = PictureBoxSizeMode.AutoSize;
            this.player.Image = Properties.Resources.h1_stand;
            this.player.Size = new Size(60, 100);
            this.player.Tag = "Player";
            form.Controls.Add(player);
            this.player.BringToFront();
        }
        public int X { get => x; set => x = value; }
        public int Y { get => y; set => y = value; }
        public int Speed { get => speed; set => speed = value; }
        public int Hp { get => hp; set => hp = value; }
        public int Damage { get => damage; set => damage = value; }
        public bool Left { get => left; set => left = value; }
        public bool Right { get => right; set => right = value; }
        public bool Jump { get => jump; set => jump = value; }
        public bool Crouch { get => crouch; set => crouch = value; }
        public void playerHit(int damage)
        {
            this.Hp -= damage;
        }
    }
}
