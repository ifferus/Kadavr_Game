using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;


namespace Kadavr
{
    internal class MapController
    {
        public int posXRender = 120;
        public int posYRender = 380;
        public int speed = 10;
        public void MoveLeft()
        {
            posXRender -= speed;
        }
        public void MoveRight()
        {
                posXRender += speed;
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
            Rectangle mapTestLand = new Rectangle(1400 - posXRender, 340, 1280, 350);
            LinearGradientBrush brush_Down1 = new LinearGradientBrush(mapTestLand, Color.Brown, Color.Black, LinearGradientMode.Vertical);
            g.FillRectangle(brush_Down1, mapTestLand);

            //Солнце
            Rectangle mapSun = new Rectangle(100, 140, 150, 150);
            LinearGradientBrush brush_Sun = new LinearGradientBrush(mapSun, Color.GhostWhite, Color.Yellow, LinearGradientMode.Vertical);
            g.DrawEllipse(Pens.Yellow, mapSun);
            g.FillEllipse(brush_Sun, mapSun);
        }
    }
}
