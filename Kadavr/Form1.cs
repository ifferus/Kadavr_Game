using System.Drawing.Drawing2D;
using System.Drawing;
using System.Numerics;
using static Kadavr.Player;
using System.Reflection.Metadata;

namespace Kadavr
{
    public partial class Kadavr_Game : Form
    {
        PictureBox[] bird;
        PictureBox[] bullets;
        Player player;
        EnemyWolf enemyWolf;
        MapController map;
        public int count = 0;
        Random rnd;
        public int backgroundspeed;
        int bulletsSpeed;

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

        public void DrawMaps(Graphics g)
        {
            //Горизонт
            Rectangle mapSkyLine = new Rectangle(0, 320, 1280, 20);
            g.FillRectangle(Brushes.Black, mapSkyLine);

            //Небо
            Rectangle mapSky = new Rectangle(0, 0, 1280, 320);
            LinearGradientBrush brush_Top = new LinearGradientBrush(mapSky, Color.Red, Color.Yellow, LinearGradientMode.Vertical);
            g.FillRectangle(brush_Top, mapSky);

            //Земля
            Rectangle mapLand = new Rectangle(0, 340, 1280, 350);
            LinearGradientBrush brush_Down = new LinearGradientBrush(mapLand, Color.Brown, Color.SaddleBrown, LinearGradientMode.Vertical);
            g.FillRectangle(brush_Down, mapLand);

            //Земля
            Rectangle mapTestLand = new Rectangle(1400-player.posXRender, 340, 1280, 350);
            LinearGradientBrush brush_Down1 = new LinearGradientBrush(mapTestLand, Color.Brown, Color.Black, LinearGradientMode.Vertical);
            g.FillRectangle(brush_Down1, mapTestLand);

            //Солнце
            Rectangle mapSun = new Rectangle(100, 140, 150, 150);
            LinearGradientBrush brush_Sun = new LinearGradientBrush(mapSun, Color.GhostWhite, Color.Yellow, LinearGradientMode.Vertical);
            g.DrawEllipse(Pens.Yellow, mapSun);
            g.FillEllipse(brush_Sun, mapSun);
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            player = new Player();
            enemyWolf= new EnemyWolf();
            map = new MapController();
            bird = new PictureBox[20];
            bullets = new PictureBox[1];
            bulletsSpeed = 80;
            rnd = new Random();
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
        }

        private void Kadavr_Game_Paint(object sender, PaintEventArgs e)
        {
            Graphics demos = e.Graphics;
            map.DrawMaps(demos);
            enemyWolf.DrawWolf(demos);
            player.DrawPlayer(demos);
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
            //player.posX += 1;
            //player.posY += 1;
            Refresh();
        }

        private void Kadavr_Game_KeyDown(object sender, KeyEventArgs e)
        {
            CordY.Text = Convert.ToString(player.posY);
            CordX.Text = Convert.ToString(player.posX);
            //if (e.KeyCode == Keys.Up)
            //{
            //    player.Move(Direction.Up);
            //    upPressed = true;
            //}

            //if (e.KeyCode == Keys.Down)
            //{
            //    player.Move(Direction.Down);
            //    downPressed = true;
            //}

            //if (e.KeyCode == Keys.Left)
            //{
            //    player.Move(Direction.Left);
            //    leftPressed = true;
            //}

            //if (e.KeyCode == Keys.Right)
            //{
            //    player.Move(Direction.Right);
            //    rightPressed = true;
            //}
            switch (e.KeyCode)
            {
                case Keys.Left:
                    player.MoveLeft();
                    if (player.posX < 250)
                    {
                        map.MoveLeft();
                    }
                    break;
                case Keys.Right:
                    player.MoveRight();
                    if (player.posX < 500)
                    {
                        map.MoveLeft();
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
                        //Intercect();
                        if (bullets[i].Left > 1280)
                        {
                            bullets[i].Location = new Point(player.posX + 25 + i * 100, player.posY + 88);
                        }
                    }
                    break;
            }
        }

        //            if (e.KeyCode == Keys.Up)
        //{
        //    player.Move(Direction.Up);

        //}

        //if (e.KeyCode == Keys.Down)
        //{
        //    player.Move(Direction.Down);
        //}

        //if (e.KeyCode == Keys.Left)
        //{
        //    player.Move(Direction.Left);
        //}

        //if (e.KeyCode == Keys.Right)
        //{
        //    player.Move(Direction.Right);
        //}

        //if (e.KeyCode == Keys.Space)
        //{
        //    for (int i = 0; i < bullets.Length; i++)
        //    {
        //        //Intercect();
        //        if (bullets[i].Left > 1280)
        //        {
        //            bullets[i].Location = new Point(player.posX + 25 + i * 100, player.posY + 88);
        //        }
        //    }
        //}
    //}
        private void Kadavr_Game_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void moveBulletsTimer_Tick_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < bullets.Length; i++)
            {
                bullets[i].Left += bulletsSpeed;
            }
        }
    }
}