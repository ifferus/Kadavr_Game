using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kadavr
{
    internal class EnemyWolf
    {
        /// <summary>
        /// Нужно сделать отдельный тайм тикет, чтобы тот работал на срабатывание плеера в лево и право 
        /// </summary>
        public int posXRender = 120;
        public int posYRender = 380;
        public int[,] wolf;
        public int posX;
        public int posY;
        Random rnd;



        public void SpawnWolf(int x, int y)
        {
            posX = x;
            posY = y;
        }
        public void MoveWolf()
        {
            rnd = new Random();
            posXRender += 5 +  rnd.Next(1,5) - rnd.Next(1,5);
        }

        public void MoveWolfOnPlayer(int posXPlayer)
        {
            posXRender += posXPlayer;
        }

        public Rectangle heatBoxWolf;

        public void DrawWolf(Graphics g)
        {
            heatBoxWolf = new Rectangle(posX - posXRender, posY, 100, 90);
            g.DrawRectangle(Pens.Black, heatBoxWolf);
            
            //Голова
            Rectangle headWolf = new Rectangle(posX - posXRender, posY, 20, 30);
            g.DrawEllipse(Pens.Gray, headWolf);
            g.FillEllipse(Brushes.Gray, headWolf);
            //Морда
            Rectangle wolfMuzzle = new Rectangle(posX - 10 -posXRender, posY + 10, 40, 20);
            g.DrawEllipse(Pens.Gray, wolfMuzzle);
            g.FillEllipse(Brushes.Gray, wolfMuzzle);

            //Шея
            Rectangle heckWolf = new Rectangle(posX + 10 - posXRender, posY-5, 15, 30);
            g.DrawEllipse(Pens.Gray, heckWolf);
            g.FillEllipse(Brushes.Gray, heckWolf);
            //Шея 2
            Rectangle heckWolf_2 = new Rectangle(posX + 15 - posXRender, posY + 10, 15, 30);
            g.DrawEllipse(Pens.Gray, heckWolf_2);
            g.FillEllipse(Brushes.Gray, heckWolf_2);

            //Ноги передние
            //Нога передняя внутренняя
            Rectangle legFrontInternalWolf = new Rectangle(posX + 25 - posXRender, posY + 40, 10, 50);
            g.FillRectangle(Brushes.DarkSlateGray, legFrontInternalWolf);
            //Нога передняя внешняя
            Rectangle legFrontExternalWolf = new Rectangle(posX + 30 - posXRender, posY + 50, 10, 40);
            g.FillRectangle(Brushes.Gray, legFrontExternalWolf);

            //Ноги сзадние
            //Нога задния внутренняя
            Rectangle legBackInternalWolf = new Rectangle(posX + 80 - posXRender, posY + 40, 10, 50);
            g.FillRectangle(Brushes.DarkSlateGray, legBackInternalWolf);
            //Нога задния внешняя
            Rectangle legBackExternalWolf = new Rectangle(posX + 85 - posXRender, posY + 50, 10, 40);
            g.FillRectangle(Brushes.Gray, legBackExternalWolf);

            //Переход Шея-тело
            Rectangle heckToBodyWolf = new Rectangle(posX + 20 - posXRender, posY + 15, 15, 30);
            g.DrawEllipse(Pens.Gray, heckToBodyWolf);
            g.FillEllipse(Brushes.Gray, heckToBodyWolf);
            //Тело
            Rectangle BodyWolf = new Rectangle(posX + 25 - posXRender, posY + 20, 20, 45);
            g.DrawEllipse(Pens.Gray, BodyWolf);
            g.FillEllipse(Brushes.Gray, BodyWolf);
            //Тело 2
            Rectangle BodyWolf_2 = new Rectangle(posX + 35 - posXRender, posY + 20, 45, 40);
            g.DrawEllipse(Pens.Gray, BodyWolf_2);
            g.FillEllipse(Brushes.Gray, BodyWolf_2);
            //Тело 3
            Rectangle BodyWolf_3 = new Rectangle(posX + 55 - posXRender, posY + 20, 50, 45);
            g.DrawEllipse(Pens.Gray, BodyWolf_3);
            g.FillEllipse(Brushes.Gray, BodyWolf_3);

            //Хвост
            Rectangle tailWolf = new Rectangle(posX + 95 - posXRender, posY + 20, 10, 20);
            g.FillRectangle(Brushes.Gray, tailWolf);
        }
        
    }
}
