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
        public int posX = 400;
        public int posY = 500;

        public void DrawWolf(Graphics g)
        {
            //тело
            Rectangle wolfBody = new Rectangle(posX, posY, 100, 40);
            LinearGradientBrush wolfBodyBrush = new LinearGradientBrush(wolfBody, Color.DarkSlateGray, Color.Gray, LinearGradientMode.Horizontal);
            g.FillRectangle(wolfBodyBrush, wolfBody);

            //Голова
            Rectangle wolfHead = new Rectangle(posX, posY, 40, 50);
            LinearGradientBrush wolfHeadBrush = new LinearGradientBrush(wolfHead, Color.DarkSlateGray, Color.Gray, LinearGradientMode.Horizontal);
            g.FillRectangle(wolfHeadBrush, wolfHead);

            ////Земля
            //Rectangle mapLand = new Rectangle(0, 340, 1280, 350);
            //LinearGradientBrush brush_Down = new LinearGradientBrush(mapLand, Color.Brown, Color.SaddleBrown, LinearGradientMode.Vertical);
            //g.FillRectangle(brush_Down, mapLand);

            ////Земля
            //Rectangle mapTestLand = new Rectangle(1400 - player.posXRender, 340, 1280, 350);
            //LinearGradientBrush brush_Down1 = new LinearGradientBrush(mapTestLand, Color.Brown, Color.Black, LinearGradientMode.Vertical);
            //g.FillRectangle(brush_Down1, mapTestLand);
        }
    }
}
