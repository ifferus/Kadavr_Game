using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kadavr
{
    internal class EnemyCactus
    {
        Random rnd = new Random();
        public int speed = 5;
        public int posXRender = 120;
        public int posYRender = 380;
        public int posX = 320;
        public int posY = 380;
        public Rectangle heatBoxCactus;
        public int heatPoint = 30;
        public int damage;

        public void SpawnCactus(int x, int y)
        {
            posX = x;
            posY = y;
            damage = rnd.Next(1, 3);
        }

        public void MoveLeftCactus()
        {
            posXRender -= speed;
        }
        public void MoveRightCactus()
        {
            posXRender += speed;
        }

        public void MoveCactusOnPlayer(int posXPlayer)
        {
            posXRender += posXPlayer;
        }

        public void DrawCactus(Graphics g)
        {
            heatBoxCactus = new Rectangle(posX - posXRender - 20, posY, 60, 100);

            Rectangle bodyCactus = new Rectangle(posX - 5 - posXRender, posY, 30, 80);
            g.DrawEllipse(Pens.Green, bodyCactus);
            g.FillEllipse(Brushes.Green, bodyCactus);

            Rectangle armCactus = new Rectangle(posX - 20 - posXRender, posY + 20 , 60, 10);
            g.DrawEllipse(Pens.Green, armCactus);
            g.FillEllipse(Brushes.Green, armCactus);

            Rectangle mainBodyCactus = new Rectangle(posX - posXRender, posY, 20, 100);
            g.FillRectangle(Brushes.Green, mainBodyCactus);
        }

        public void RegisterDamage()
        {
            heatPoint -= 10;
            if (heatPoint == 0)
            {
                posX = 5000;
                posY = 5000;
            }
        }
    }
}
