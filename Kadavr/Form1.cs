using System.Drawing.Drawing2D;
using System.Drawing;
using System.Numerics;
using static Kadavr.Player;
using System.Reflection.Metadata;
using WMPLib;
using System.Net.Mail;

namespace Kadavr
{
    public partial class Kadavr_Game : Form
    {
        PictureBox[] bird;
        PictureBox[] bullets;
        Player player;
        EnemyWolf[] enemyWolfs;
        EnemyCactus[] enemyCactus;
        MapController map;
        public int count = 0;
        Random rnd;
        public int backgroundspeed;
        public int bulletsSpeed;
        public int wolfsCount;
        public int cactusCount;
        public int speedWolfs;
        Sounds sound;


        public Kadavr_Game()
        {
            InitializeComponent();
            Init();
        }

        public void Init()
        {
            backgroundspeed = 1;
            Invalidate();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            sound = new Sounds();
            player = new Player();
            enemyWolfs = new EnemyWolf[wolfsCount];
            enemyCactus = new EnemyCactus[cactusCount];
            map = new MapController();
            bird = new PictureBox[20];
            bullets = new PictureBox[1];
            bulletsSpeed = 80;
            rnd = new Random();
            sound.StopAllSounds();
            sound.SoundsMainTheme();
            for (int i = 0; i < bird.Length; i++)
            {
                bird[i] = new PictureBox();
                bird[i].BorderStyle = BorderStyle.None;
                bird[i].Location = new Point(rnd.Next(-1000, 1280), rnd.Next(30, 200));
                if (i % 2 == 1)
                {
                    bird[i].Size = new Size(rnd.Next(100, 255), rnd.Next(30, 70));
                    bird[i].BackColor = Color.FromArgb(rnd.Next(50, 125), 255, 200, 200);
                }
                else
                {
                    bird[i].Size = new Size(150, 60);
                    bird[i].BackColor = Color.FromArgb(rnd.Next(80, 125), 255, 210, 205);
                }

                this.Controls.Add(bird[i]);
            }

            for (int i = 0; i < bullets.Length; i++)
            {
                bullets[i] = new PictureBox();
                bullets[i].BorderStyle = BorderStyle.None;
                bullets[i].Size = new Size(20, 5);
                bullets[i].BackColor = Color.White;

                this.Controls.Add(bullets[i]);
            }

            for (int i = 0; i < enemyWolfs.Length; i++)
            {
                enemyWolfs[i] = new EnemyWolf();
                enemyWolfs[i].SpawnWolf(rnd.Next(1400, 5000), rnd.Next(340, 500));
            }

            for (int i = 0; i < enemyCactus.Length; i++)
            {
                enemyCactus[i] = new EnemyCactus();
                enemyCactus[i].SpawnCactus(rnd.Next(1400, 3000), rnd.Next(340, 500));
            }
        }

        private void Kadavr_Game_Paint(object sender, PaintEventArgs e)
        {
            Graphics demos = e.Graphics;
            map.DrawMaps(demos);
            player.DrawPlayer(demos);

            for (int i = 0; i < enemyCactus.Length; i++)
            {
                //enemyWolfs[i].SpawnWolf(rnd.Next(300, 400), rnd.Next(500, 600));
                enemyCactus[i].DrawCactus(demos);
            }

            for (int i = 0; i <  enemyWolfs.Length; i++)
            {
                //enemyWolfs[i].SpawnWolf(rnd.Next(300, 400), rnd.Next(500, 600));
                enemyWolfs[i].DrawWolf(demos);
            }


            //enemyWolf.DrawWolf(demos);
        }

        private void updateBackground_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < bird.Length; i++)
            {
                bird[i].Left += backgroundspeed;
                if (bird[i].Left >= 1280)
                {
                    bird[i].Left = bird[i].Height;
                }
            }

            for (int i = bird.Length; i < bird.Length; i++)
            {
                bird[i].Left += backgroundspeed - 10;
                if (bird[i].Left >= 1280)
                {
                    bird[i].Left = bird[i].Left;
                }
            }
            for (int i = 0; i < enemyWolfs.Length; i++)
            {
                //enemyWolfs[i].SpawnWolf(rnd.Next(300, 400), rnd.Next(500, 600));
                enemyWolfs[i].MoveWolf(speedWolfs);
            }
            Refresh();
        }

        private void Kadavr_Game_KeyDown(object sender, KeyEventArgs e)
        {
            if (player.playerIsDeath == true) return;
            CordY.Text = Convert.ToString(player.posY);
            CordX.Text = Convert.ToString(player.posX);
            switch (e.KeyCode)
            {
                case Keys.Left:
                    if (player.posX < 250)
                    {
                        map.MoveLeft();
                    }
                    if (player.posX > 25)
                    {
                        for (int i = 0; i < enemyWolfs.Length; i++)
                        {
                            enemyWolfs[i].MoveWolfOnPlayer(-player.speed);
                        }

                        for (int i = 0; i < enemyCactus.Length; i++)
                        {
                            enemyCactus[i].MoveRightCactus();
                            enemyCactus[i].MoveCactusOnPlayer(-player.speed);
                        }
                    }
                    for (int i = 0; i < enemyCactus.Length; i++)
                    {
                        enemyCactus[i].MoveLeftCactus();
                    }
                    player.MoveLeft();
                    break;
                case Keys.Right:
                    map.MoveRight();
                    if (player.posX < 500)
                    {
                        player.MoveRight();
                    }
                    if (player.posX > 500)
                    {
                        for (int i = 0; i < enemyWolfs.Length; i++)
                        {
                            enemyWolfs[i].MoveWolfOnPlayer(player.speed);
                        }

                        for (int i = 0; i < enemyCactus.Length; i++)
                        {
                            enemyCactus[i].MoveCactusOnPlayer(player.speed);
                        }
                    }
                    for (int i = 0; i < enemyCactus.Length; i++)
                    {
                        enemyCactus[i].MoveRightCactus();
                    }
                    break;
                case Keys.Up:
                    player.MoveUp();
                    break;
                case Keys.Down:
                    player.MoveDown();
                    break;
                case Keys.Space:
                    for (int i = 0; i < bullets.Length; i++)
                    {
                        sound.SoundsShoot();
                        if (bullets[i].Left > 1280)
                        {
                            bullets[i].Location = new Point(player.posX + 25 + i * 100, player.posY + 88);
                        }
                    }
                    break;
            }
        }
        private void Kadavr_Game_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void moveBulletsTimer_Tick_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < bullets.Length; i++)
            {
                Intercect();
                bullets[i].Left += bulletsSpeed;
            }
            hpBar.Text = Convert.ToString(player.heatPoint);
        }

        private void Intercect()
        {
            for (int i = 0; i < enemyWolfs.Length; i++)
            {
                if (enemyWolfs[i].heatBoxWolf.IntersectsWith(bullets[0].Bounds))
                {
                    enemyWolfs[i].SpawnWolf(3000, 5000);
                    bullets[0].Location = new Point(2000, player.posY + 500);
                    count++;
                    Score.Text = Convert.ToString(count);
                    sound.SoundsHit();
                    if (i % 5 == 0)
                    {
                        sound.SoundsHowl();
                    }
                    if (i % 8 == 0)
                    {
                        sound.SoundsSpeech();
                    }
                }

                if (player.heatBoxPlayer.IntersectsWith(enemyWolfs[i].heatBoxWolf))
                {
                    player.RegisterDamage(enemyWolfs[i].damage);
                    if (player.heatPoint <= 0)
                    {
                        GameOver();
                    }
                }
            }

            for (int j = 0; j < enemyCactus.Length; j++)
            {
                if (enemyCactus[j].heatBoxCactus.IntersectsWith(bullets[0].Bounds))
                {
                    bullets[0].Location = new Point(2000, player.posY + 500);
                    enemyCactus[j].RegisterDamage();
                }

                if (enemyCactus[j].heatBoxCactus.IntersectsWith(player.heatBoxPlayer))
                {
                    player.RegisterDamage(enemyCactus[j].damage);
                    if (player.heatPoint <= 0)
                    {
                        GameOver();
                    }
                }
            }
        }

        private void GameOver()
        {
            gameOverLabel.Visible = true;
            player.Death();
            map.MoveStop();
            sound.SoundsSpeechDeath();
        }
    }
}