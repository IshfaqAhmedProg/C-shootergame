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
    public partial class STAGE1Frame : Form
    {
        Label Bhit = new Label();
        Label Phit=new Label();
        public bool stage1,stage2;
        int h1=100, h2=100, h3=100;
        public bool gameover = false;
        int gametime = 300,bosstime=0;
        int g = 19;
        int force;
        PauseMenu p;
        bool Hero1 = true, Hero2, Hero3;
        bool directionR = true;
        Player char1 = new Player();
        Image charstandL;
        Image charshootL;
        Image charshootR;
        Image charstandR;
        Image charJumpL;
        Image charJumpR;
        Image charWalkL;
        Image charWalkR;
        Image charcrouchL;
        Image charcrouchR;
        Image charcrouchshootL;
        Image charcrouchshootR;
        Image chardeath;
        Image bossstandL;
        Image bossshootL;
        Image bossshootR;
        Image bossstandR;
        Image bossWalkL;
        Image bossWalkR;
        Image bossstandspec;
        Image bossdeath;
        Image bosspower;
        Boss boss1 = new Boss();
        public Timer gametimer = new Timer { Interval = 1000 };
        public Timer bsT = new Timer();
        Random rnd = new Random();
        PictureBox BlockL = new PictureBox();
        PictureBox BlockR = new PictureBox();
        PictureBox Fire = new PictureBox();
        public STAGE1Frame(int i)
        {
            InitializeComponent();
            if (i == 0)
            {
                stage1 = true;
                stage2 = false;
            }
            else if (i == 1)
            {
                stage1 = false;
                stage2 = true;
            }
            startGameTimer();
           
        }
        private void STAGE1Frame_Load(object sender, EventArgs e)
        {
            if (stage1 == true)
            {
                char1.MakePlayer(50, 200, h1, 10, 30, this);
                boss1.Makeboss(670, 165, 1000, 9, 20, this);
                assignImage();
                BlockL.Size = new Size(340, 78);
                BlockL.Location = new Point(0, 312);
                BlockR.Size = new Size(282, 78);
                BlockR.Location = new Point(510, 312);
                Fire.Size = new Size(158, 66);
                Fire.Location = new Point(346, 324);
                Fire.Tag = "Fire";
                char1avatar.Location=new Point(0,0);
                char2avatar.Location = new Point(74, 0);
                char3avatar.Location = new Point(148, 0);
                Char1HPbar.Location = new Point(0, 51);
                Char2HPbar.Location = new Point(74, 51);
                Char3HPbar.Location = new Point(149, 51);
            }
            else if (stage2==true)
            {
                char1.MakePlayer(50, 0, h1, 10, 30, this);
                boss1.Makeboss(590, 37, 1000, 9, 20, this);
                assignImage();
                BlockL.Size = new Size(211,200);
                BlockL.Location = new Point(0, 191);
                BlockL.BackColor = Color.Red;
                BlockR.Size = new Size(211,200);
                BlockR.Location = new Point(581,191);
                BlockR.BackColor = Color.Red;
                Fire.Size = new Size(773,21);
                Fire.Location = new Point(9,364);
                Fire.Tag = "Fire";
                VillainHPbar.Size = new Size(342, 15);
                VillainHPbar.Location = new Point(257, 324);
            }
            assignImage();
            this.Phit.Font = new Font(FontFamily.GenericSansSerif, 12.0F, FontStyle.Bold);
            this.Phit.ForeColor = Color.Red;
            this.Phit.BackColor = Color.Transparent;
            this.Phit.Size = new Size(30, 30);
            this.Bhit.Font = new Font(FontFamily.GenericSansSerif, 12.0F, FontStyle.Bold);
            this.Bhit.ForeColor = Color.Green;
            this.Bhit.BackColor = Color.Transparent;
            this.Bhit.Size = new Size(44, 30);
        }

        private void STAGE1Frame_KeyDown(object sender, KeyEventArgs e)
        {
            if(this.gameover)
            {
                return;
            }
            if(e.KeyCode==Keys.Enter)
            {
                if(Hero1==true)
                {
                    Hero1 = false;
                    Hero2 = true;
                    Hero3 = false;
                }
                else if(Hero2==true)
                {
                    Hero1 = false;
                    Hero2 = false;
                    Hero3 = true;
                }
                else if(Hero3==true)
                {
                    Hero1 = true;
                    Hero2 = false;
                    Hero3 = false;
                }
                this.assignImage();
                this.char1.player.Image = charstandR;
            }
            if (this.char1.Jump != true)
            {
                if (e.KeyCode == Keys.Up)
                {
                    if (directionR == true)
                        this.char1.player.Image = charJumpR;
                    else
                        this.char1.player.Image = charJumpL;
                    this.char1.Jump = true;
                    this.force = g;
                }
            }
            if (e.KeyCode == Keys.Right)
            {
                this.char1.player.Image = charWalkR;
                this.char1.Right = true;
                this.directionR = true;
            }
            if (e.KeyCode == Keys.Left)
            {
                this.char1.player.Image = charWalkL;
                this.char1.Left = true;
                this.directionR = false;
            }
            if (e.KeyCode ==Keys.Space)
            {
                if (char1.Crouch != true)
                {
                    if (directionR == true)
                    {
                        this.char1.player.Image = charshootR;
                    }
                    else
                    {
                        this.char1.player.Image = charshootL;
                    }
                }
                else
                {
                    if (directionR == true)
                    {
                        this.char1.player.Image = charcrouchshootR;
                    }
                    else
                    {
                        this.char1.player.Image = charcrouchshootL;
                    }
                }
                shoot(this.directionR);
            }
            if(e.KeyCode==Keys.Down)
            {
                if(char1.Jump==false)
                {
                    if (directionR == true)
                    {
                        this.char1.player.Image = charcrouchR;
                    }
                    else
                    {
                        this.char1.player.Image = charcrouchL;
                    }
                    char1.Crouch = true;
                }
            }
            if(e.KeyCode==Keys.Escape)
            {
                p = new PauseMenu(this);
                this.Hide();
                p.Show();
                this.DamageTimer.Stop();
                this.DamageTimer.Enabled = false;

                this.gametimer.Stop();
                this.gametimer.Enabled = false;
                this.HealthTimer.Stop();
                this.HealthTimer.Enabled = false;
                this.BossAttack.Stop();
                this.BossAttack.Enabled = false;
                this.bsT.Stop();
                this.bsT.Enabled = false;
                
            }
        }
        private void STAGE1Frame_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
            {
                this.char1.Right = false;
                this.char1.player.Image = charstandR;
            }
            if (e.KeyCode == Keys.Left)
            {
                this.char1.Left = false;
                this.char1.player.Image = charstandL;
            }
            if (e.KeyCode == Keys.Space)
            {
                if (char1.Crouch != true)
                {
                    if (directionR == true)
                    {
                        this.char1.player.Image = charstandR;
                    }
                    else
                    {
                        this.char1.player.Image = charstandL;
                    }
                }
                else
                {
                    if (directionR == true)
                    {
                        this.char1.player.Image = charcrouchR;
                    }
                    else
                    {
                        this.char1.player.Image = charcrouchL;
                    }
                }

            }
            if (e.KeyCode == Keys.Down)
            {
                if (directionR == true)
                {
                    this.char1.player.Image = charstandR;
                }
                else
                {
                    this.char1.player.Image = charstandL;
                }
                char1.Crouch = false;    
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (gameover == true)
            {
                timer1.Stop();
                Gameover();
                timer1.Enabled = false;
                return;
            }
            Invalidate();
            //Side collision L
            if (char1.player.Right > BlockL.Left && this.char1.player.Left < BlockL.Right - this.char1.player.Width / 2 && this.char1.player.Bottom > BlockL.Top + 3)
            {
                this.char1.Right = false;
            }
            if (this.char1.player.Left < BlockL.Right && this.char1.player.Right > BlockL.Left + this.char1.player.Width / 2 && this.char1.player.Bottom > BlockL.Top + 3)
            {
                this.char1.Left = false;
            }
            //side collision R
            if (this.char1.player.Right > BlockR.Left && this.char1.player.Left < BlockR.Right - this.char1.player.Width / 2 && this.char1.player.Bottom > BlockR.Top + 3)
            {
                this.char1.Right = false;
            }
            if (this.char1.player.Left < BlockR.Right && this.char1.player.Right > BlockR.Left + this.char1.player.Width / 2 && this.char1.player.Bottom > BlockR.Top + 3)
            {
                this.char1.Left = false;
            }
            //movement
            if (this.char1.Left == true && this.char1.player.Left > BackgroundPB.Left)
            {
                this.char1.player.Left -= this.char1.Speed;
            }
            if (this.char1.Right == true && this.char1.player.Left + this.char1.player.Width < BackgroundPB.Left + BackgroundPB.Width)
            {
                this.char1.player.Left += this.char1.Speed;
            }
            //jump
            if (this.char1.Jump == true)
            {
                this.char1.player.Top -= force;
                force -= 1;
            }
            if (this.char1.player.Top + this.char1.player.Height >= BackgroundPB.Height)
            {
                if (stage1 == true)
                {
                    this.char1.player.Top = BackgroundPB.Height - this.char1.player.Height;
                }
                else if(stage2==true)
                {
                    this.char1.player.Top = 0;
                    this.char1.player.Left = 50;
                }
                this.char1.Jump = false;
                if (directionR == true)
                    this.char1.player.Image = charstandR;
                else
                    this.char1.player.Image = charstandL;
            }
            else
            {
                this.char1.player.Top += 5;
            }
            //top collision
            if (this.char1.player.Left + this.char1.player.Width - 1 > BlockL.Left && this.char1.player.Left + this.char1.player.Width + 5 < BlockL.Left + BlockL.Width + this.char1.player.Width && this.char1.player.Top + this.char1.player.Height >= BlockL.Top && this.char1.player.Top < BlockL.Top+5)
            {
                this.char1.player.Top = BackgroundPB.Height - BlockL.Height - this.char1.player.Height;
                force = 0;
                this.char1.Jump = false;
            }

            if (this.char1.player.Left + this.char1.player.Width - 1 > BlockR.Left && this.char1.player.Left + this.char1.player.Width + 5 < BlockR.Left + BlockR.Width + this.char1.player.Width && this.char1.player.Top + this.char1.player.Height >= BlockR.Top && this.char1.player.Top < BlockR.Top+5)
            {
                this.char1.player.Top = BackgroundPB.Height - BlockR.Height - this.char1.player.Height;
                force = 0;
                this.char1.Jump = false;
            }
        }
        private void startGameTimer()
        {
            if(gameover==true)
            {
                gametimer.Stop();
                gametimer.Enabled = false;
                return;
            }
            gametimer.Start();
            gametimer.Tick += delegate
              {
                  gametime--;
                  if (gametime==0)
                  {
                      gameover = true;
                  }
                  var ssTime = TimeSpan.FromSeconds(gametime);
                  string str = string.Format("  {0}:{1}",ssTime.Minutes,ssTime.Seconds);
                  Timer.Text = str;
              };
        }

        private void shoot(bool dir)
        {
            HeroShot shoot = new HeroShot();
            if (gameover == true)
            {
                shoot.Timer.Stop();
                shoot.Timer.Enabled = false;
                return;
            }
            
            shoot.right = dir;
            shoot.bulletLeft = this.char1.player.Left + (this.char1.player.Width / 2)+20;
            shoot.bulletTop = this.char1.player.Top + (this.char1.player.Height / 2)-18;
            shoot.makebullet(this);
        }
        private void bossShoot()
        {
            BossPower powershot = new BossPower();
            if (gameover == true)
            {
                powershot.Timer.Stop();
                powershot.Timer.Enabled = false;
                return;
            }
            
            powershot.bulletLeft = this.boss1.boss.Left + (this.boss1.boss.Width / 2)-60;
            powershot.bulletTop = this.boss1.boss.Top + (this.boss1.boss.Height / 2)-40;
            boss1.boss.Image = bossshootR;
            powershot.makebullet(this);
            
        }
        private void Gameover()
        {
            if (gameover == true)
            {
                GameOver goframe = new GameOver();
                this.Hide();
                goframe.Show();
            }
        }

        private void DamageLabel_Tick(object sender, EventArgs e)
        {
            this.Phit.Hide();
            this.Bhit.Hide();
        }

        private void bossObstacle()
        {
            Obstacle obstacle;
            Obstacle2 obstacle2;
            if (stage1==true)
            {
                obstacle = new Obstacle(rnd.Next(char1.player.Left - 50, char1.player.Left + 50), 0, this,bosspower);
                this.boss1.boss.BringToFront();
                obstacle.oT.Interval = 5;
                obstacle.oT.Tick += new EventHandler(obstacle.oT_Tick);
                obstacle.oT.Start();
                if (gameover == true)
                {
                    obstacle.oT.Stop();
                    obstacle.oT.Enabled = false;
                    return;
                }
            }
            else if(stage2==true)
            {
                obstacle2 = new Obstacle2(BackgroundPB.Width, rnd.Next(char1.player.Top - 50, char1.player.Top + 50), this,bosspower);
                this.boss1.boss.BringToFront();
                obstacle2.oT2.Interval = 5;
                obstacle2.oT2.Tick += new EventHandler(obstacle2.oT2_Tick);
                obstacle2.oT2.Start();
                if (gameover == true)
                {
                    obstacle2.oT.Stop();
                    obstacle2.oT.Enabled = false;
                    return;
                }
            }

           
        }
        private void assignImage()
        {
            bossdeath = Properties.Resources.boss1_death;
            chardeath = Properties.Resources.hero_death;
            if (stage1 == true)
            {
                this.Villainavatar.Image = Properties.Resources.b1;
                this.BackgroundImage = Properties.Resources.backs1;
                bossstandL = Properties.Resources.b1_stand;
                bossshootL = Properties.Resources.b1_shoot_rev;
                bossshootR = Properties.Resources.b1_shoot;
                bossstandR = Properties.Resources.b1_stand_reverse;
                bossWalkL = Properties.Resources.b1_spec_mode_on_walk;
                bossWalkR = Properties.Resources.b1_spec_mode_on_walk_rev;
                bossstandspec = Properties.Resources.b1_spec;
                bosspower = Properties.Resources.b1_fireball_spec;

            }
            else if(stage2==true)
            {
                this.Villainavatar.Image = Properties.Resources.b2;
                this.BackgroundImage= Properties.Resources.backs2;
                bossstandL = Properties.Resources.b2_stand;
                bossshootL = Properties.Resources.b2_shoot_rev;
                bossshootR = Properties.Resources.b2_shoot;
                bossstandR = Properties.Resources.b2_stand_rev;
                bossWalkL = Properties.Resources.b2_spec_mode_on_walk;
                bossWalkR = Properties.Resources.b2_spec_mode_on_walk_rev;
                bossstandspec = Properties.Resources.b2_spec;
                bosspower = Properties.Resources.b2_wave_spec;
            }
            if (Hero1 == true)
            {

                char1avatar.Image = Properties.Resources.h1;
                char2avatar.Image = Properties.Resources.h2_off;
                char3avatar.Image = Properties.Resources.h3_off;
                char1.Hp = h1;
                charstandL = Properties.Resources.h1_stand_rev;
                charshootL = Properties.Resources.h1_shoot_rev;
                charshootR = Properties.Resources.h1_shoot;
                charstandR = Properties.Resources.h1_stand;
                charJumpL = Properties.Resources.h1_jump_rev;
                charJumpR = Properties.Resources.h1_jump;
                charWalkL = Properties.Resources.h1_move_left;
                charWalkR = Properties.Resources.h1_move_right;
                charcrouchL = Properties.Resources.h1_crouch_rev;
                charcrouchR = Properties.Resources.h1_crouch;
                charcrouchshootL = Properties.Resources.h1_crouch_shoot_rev;
                charcrouchshootR = Properties.Resources.h1_crouch_shoot;
            }
            else if (Hero2 == true)
            {
                char1avatar.Image = Properties.Resources.h1_off;
                char2avatar.Image = Properties.Resources.h2_off;
                char3avatar.Image = Properties.Resources.h3;
                char1.Hp = h2;
                charstandL = Properties.Resources.H2stand_rev;
                charshootL = Properties.Resources.h2_shoot_rev;
                charshootR = Properties.Resources.h2shoot;
                charstandR = Properties.Resources.h2_stand;
                charJumpL = Properties.Resources.h2jump_rev;
                charJumpR = Properties.Resources.h2jump;
                charWalkL = Properties.Resources.h2_run_rev;
                charWalkR = Properties.Resources.h2run;
                charcrouchL = Properties.Resources.h2_crouch_rev;
                charcrouchR = Properties.Resources.h2_crouch;
                charcrouchshootL = Properties.Resources.h2_crouch_shoot_rev;
                charcrouchshootR = Properties.Resources.h2_crouch_shoot;
            }
            else if (Hero3 == true)
            {
                char1avatar.Image = Properties.Resources.h1_off;
                char2avatar.Image = Properties.Resources.h2;
                char3avatar.Image = Properties.Resources.h3_off;
                char1.Hp = h3;
                charstandL = Properties.Resources.stand_rev;
                charshootL = Properties.Resources.shoot_rev;
                charshootR = Properties.Resources.shoot;
                charstandR = Properties.Resources.stand;
                charJumpL = Properties.Resources.jump_rev;
                charJumpR = Properties.Resources.jump1;
                charWalkL = Properties.Resources.run_rev;
                charWalkR = Properties.Resources.run;
                charcrouchL = Properties.Resources.h3_crouch_rev;
                charcrouchR = Properties.Resources.h3_crouch;
                charcrouchshootL = Properties.Resources.h3_crouch_shoot_rev;
                charcrouchshootR = Properties.Resources.h3_crouch_shoot;
            }
        }
        //Boss Attack and special Attack
        private void BossAttack_Tick(object sender, EventArgs e)
        {
            if (gameover == true)
            {
                BossAttack.Stop();
                BossAttack.Enabled = false;
                return;
            }
            if (bosstime > 4 && bosstime < 8 || bosstime > 14 && bosstime < 18 && stage1 == true)
            {
                boss1.boss.Image = bossstandspec;
                bossObstacle();
                bsT.Interval = 500;
                bsT.Tick += new EventHandler(bsT_Tick);
                bsT.Start();
            }
            else
            {
                boss1.boss.Image = bossstandL;
                bsT.Stop();
                bsT.Dispose();
                bossShoot();
            }
            
            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && x.Tag == "power")
                {
                    if (((PictureBox)x).Top + (x.Height / 2) > this.char1.player.Top + (char1.player.Height / 2))
                    {
                        x.Top -= 9;
                    }
                    if (((PictureBox)x).Top+(x.Height/2) < this.char1.player.Top+(char1.player.Height/2)+10)
                    {
                        x.Top += 9;
                    }
                }
            }
            bosstime++;
        }
        
        private void HealthTimer_Tick(object sender, EventArgs e)
        {
            if (gameover == true)
            {
                HealthTimer.Stop();
                HealthTimer.Enabled = false;
                return;
            }
            if(this.char1.Hp<=0)
            {
                this.char1.Hp = 0;
            }
            if (this.char1.Hp >0)
            {
                foreach (Control x in this.Controls)
                {
                    if (x is PictureBox && x.Tag == "power")
                    {
                        if (((PictureBox)x).Bounds.IntersectsWith(char1.player.Bounds))
                        {
                            this.Phit.Text = "-4";
                            this.Phit.Location = new Point(this.char1.player.Location.X+30,this.char1.player.Location.Y-50);
                            this.Controls.Add(Phit);
                            this.Phit.Visible = true;
                            this.Phit.BringToFront();
                            this.char1.Hp -= 4;
                            this.Controls.Remove(x);
                            x.Dispose();
                        }
                    }
                    if (x is PictureBox && x.Tag == "Fire")
                    {
                        if (((PictureBox)x).Bounds.IntersectsWith(char1.player.Bounds))
                        {
                            this.char1.Hp -=3;
                        }
                    }
                    if (x is PictureBox && x.Tag == "Villain")
                    {
                        if (((PictureBox)x).Bounds.IntersectsWith(char1.player.Bounds))
                        {
                            this.char1.Hp -= 1;
                        }
                    }
                }
            }
            else if (char1.Hp == 0)
            {
                char1.player.Image = chardeath;
                gameover = true;
            }
            if (Hero1 == true)
            {
                h1 = this.char1.Hp;
                Char1HPbar.Value = this.char1.Hp;
            }
            else if(Hero2==true)
            {
                h2 = this.char1.Hp;
                Char3HPbar.Value = this.char1.Hp;
            }
            else if (Hero3 == true)
            {
                
                h3 = this.char1.Hp;
                Char2HPbar.Value = this.char1.Hp;
            }
            
        }

        private void DamageTimer_Tick(object sender, EventArgs e)
        {
            if (gameover == true)
            {
                DamageTimer.Stop();
                DamageTimer.Enabled = false;
                return;
            }
            foreach (Control x in this.Controls)
            {
                if(boss1.Hp>0)
                { 
                    if (x is PictureBox && x.Tag == "bullet")
                    {
                        if (((PictureBox)x).Bounds.IntersectsWith(this.boss1.boss.Bounds) && this.boss1.Hp > 0)
                        {

                            this.Bhit.Text = "-10";
                            this.Bhit.Location = new Point(this.boss1.boss.Location.X-30, this.boss1.boss.Location.Y - 50);
                            this.Controls.Add(Bhit);
                            this.Bhit.Visible = true;
                            this.Bhit.BringToFront();
                            this.boss1.Hp -= 10;
                            this.Controls.Remove(x);
                            x.Dispose();
                        }
                    }
                }
                if (boss1.Hp == 0)
                {
                    boss1.boss.Image = bossdeath;
                    gameover = true;
                }
            }
            VillainHPbar.Value = this.boss1.Hp;
        }
        private void bsT_Tick(object sender, EventArgs e)
        {
            if(gameover==true)
            {
                bsT.Stop();
                bsT.Enabled = false;
                return;
            }
            if (boss1.boss.Left >= BlockR.Left&& boss1.boss.Left + boss1.boss.Width <= BlockR.Left + BlockR.Width)
            {
              
                if (boss1.Left == true)
                {
                    boss1.boss.Image = bossWalkL;
                    boss1.boss.Left -= 4;
                    Console.WriteLine("l>{0} ,{1}", boss1.boss.Left.ToString(), BlockR.Left.ToString());
                }
                if (boss1.boss.Left == BlockR.Left)
                {
                    boss1.Left = false;
                    boss1.Right = true;
                }
                if (boss1.boss.Left + boss1.boss.Width == BlockR.Left + BlockR.Width)
                {
                    boss1.Left = true;
                    boss1.Right = false;
                }
                if (boss1.Right==true)
                {
                    boss1.boss.Image = bossWalkR;
                    boss1.boss.Left += 4;
                    Console.WriteLine("r>{0} ,{1}", boss1.boss.Left.ToString(), BlockR.Left.ToString());
                }
            }
        }
    }
}
