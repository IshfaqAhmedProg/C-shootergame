using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace STAGE1
{
    class Boss
    {
        int x, y;
        bool left=true, right=false, jump, crouch;
        int speed;
        int hp, damage;
        public PictureBox boss = new PictureBox();
       
        public void Makeboss(int x, int y, int hp, int speed, int damage, Form form)
        {
            this.Hp = hp;
            this.Damage = damage;
            this.speed = speed;
            this.boss.Top = y ;
            this.boss.Left = x ;
            this.boss.BackColor = Color.Transparent;
            this.boss.SizeMode = PictureBoxSizeMode.AutoSize;
            this.boss.Tag = "Villain";
            form.Controls.Add(boss);
            this.boss.BringToFront();
        }
       
        public int X { get => x; set => x = value; }
        public int Y { get => y; set => y = value; }
        public int Speed { get => speed; set => speed = value; }
        public int Hp { get => hp; set => hp = value; }
        public int Damage { get => damage; set => damage = value; }
        public bool Left { get => left; set => left = value; }
        public bool Right { get => right; set => right = value; }
        public bool Jump { get => jump; set => jump = value; }
        public void bossHit(int damage)
        {
            this.Hp -= damage;
        }
    }
}

