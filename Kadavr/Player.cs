using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Kadavr
{
    internal class Player
    {
       
        public int posX = 120;
        public int posY = 380;
        public int posXRender = 120;
        public int posYRender = 380;
        public int speed = 5;
        //public enum Direction
        //{
        //    Up,
        //    Down,
        //    Left,
        //    Right,
        //    //UpLeft,
        //    //UpRight,
        //    //DownLeft,
        //    //DownRight
        //}

        public void MoveLeft()
        {
            if (posX > 25)
            {
                posX -= speed;
            }
        }
        public void MoveRight()
        {
            if(posX < 500)
            {
                posX += speed;
            }
        }
        public void MoveUp()
        {
            if (posY > 245 ) //345
            {
                posY -= speed;
            }
        }
        public void MoveDown()
        {
            if (posY < 490)
            {
                posY += speed;
            }
        }
        //public void Move(Direction direction)
        //{
        //    switch (direction)
        //    {
        //        case Direction.Up:
        //            if (posY > 345){
        //                posY -= speed;
        //                posYRender -= speed+10;
        //            }
        //            break;
        //        case Direction.Down:
        //            if (posY < 490)
        //            {
        //                posY += speed;
        //                posYRender += speed;
        //            }
        //            break;
        //        case Direction.Left:
        //            if(posX > 25)
        //            {
        //                posX -= speed;
        //                if(posX < 250)
        //                {
        //                    posXRender -= speed;
        //                }
        //            }
        //            break;
        //        case Direction.Right:
        //            if(posX < 1200)
        //            {
        //                if (posX < 500)
        //                {
        //                    posX += speed;
        //                }
        //                posXRender += speed + 10;
        //            }
        //            break;
                //case Direction.UpLeft:
                //    posX += speed;
                //    posY -= speed;
                //    break;
                //case Direction.UpRight:
                //    posX += speed;
                //    posY += speed;
                //    break;
                //case Direction.DownLeft:
                //    posX -= speed;
                //    posY -= speed;
                //    break;
                //case Direction.DownRight:
                //    posX -= speed;
                //    posY += speed;
                //    break;
        //    }
        //}

        //public void MovePlayer(string way){ 
        //    if (way == "left")
        //    {
        //        posX -= speed;
        //    }

        //    if (way == "right")
        //    {
        //        posX += speed;
        //    }

        //    if (way == "up")
        //    {
        //        posY -= speed;
        //    }

        //    if (way == "up+left")
        //    {
        //        posX -= speed;
        //        posY -= speed;
        //    }
        //    if (way == "up+right")
        //    {
        //        posX += speed;
        //        posY -= speed;
        //    }

        //    if (way == "down")
        //    {
        //        posY += speed;
        //    }

        //    if (way == "down+left")
        //    {
        //        posX -= speed;
        //        posY += speed;
        //    }
        //    if (way == "down+right")
        //    {
        //        posX += speed;
        //        posY += speed;
        //    }
        //}

        public void DrawPlayer(Graphics e)
        {
            //Graphics demos = e.Graphics;
            //Голова игрока 
            Rectangle headPlayer = new Rectangle(posX, posY, 40, 40);
            e.DrawEllipse(Pens.Pink, headPlayer);
            e.FillEllipse(Brushes.Pink, headPlayer);
            //Лицо игрока
            ////////////
            //Левый глаз игрока
            Rectangle eyeLeftPlayer = new Rectangle(posX + 10, posY + 10, 5, 10);
            e.DrawEllipse(Pens.Violet, eyeLeftPlayer);
            e.FillEllipse(Brushes.White, eyeLeftPlayer);
            //Левый зрачок игрока
            Rectangle eyeBallLeftPlayer = new Rectangle(posX + 12, posY + 12, 4, 6);
            e.DrawEllipse(Pens.Violet, eyeBallLeftPlayer);
            e.FillEllipse(Brushes.OliveDrab, eyeBallLeftPlayer);
            ///////////
            //Правый глаз игрока
            Rectangle eyeRightPlayer = new Rectangle(posX + 25, posY + 10, 5, 10);
            e.DrawEllipse(Pens.Violet, eyeRightPlayer);
            e.FillEllipse(Brushes.White, eyeRightPlayer);
            //Правый зрачок игрока
            Rectangle eyeBallRightPlayer = new Rectangle(posX + 27, posY + 12, 4, 6);
            e.DrawEllipse(Pens.Violet, eyeBallRightPlayer);
            e.FillEllipse(Brushes.OliveDrab, eyeBallRightPlayer);
            //////////
            //Рот игрока
            Rectangle mouthPlayer = new Rectangle(posX + 15, posY + 30, 10, 3);
            e.DrawEllipse(Pens.DarkRed, mouthPlayer);
            e.FillEllipse(Brushes.Red, mouthPlayer);
            /////////////

            //Шляпа
            //Основание шляпы
            Rectangle hatBasisPlayer = new Rectangle(posX - 10, posY - 3, 60, 10);
            e.DrawEllipse(Pens.Brown, hatBasisPlayer);
            e.FillEllipse(Brushes.SandyBrown, hatBasisPlayer);
            //Вверхушка
            Rectangle hatRoofPlayer = new Rectangle(posX + 5, posY - 8, 30, 10);
            e.DrawEllipse(Pens.Brown, hatRoofPlayer);
            e.FillEllipse(Brushes.SandyBrown, hatRoofPlayer);
            ///////////

            //Шея игрока
            Rectangle neckPlayer = new Rectangle(posX + 15, posY + 40, 10, 5);
            e.FillRectangle(Brushes.Pink, neckPlayer);
            //////////


            //Руки игрока
            /////////////
            //Левая рука
            Rectangle armLeftPlayer = new Rectangle(posX - 22, posY + 70, 10, 45);
            e.FillRectangle(Brushes.Pink, armLeftPlayer);
            //Левая Кисть игрока
            Rectangle handLeftPlayer = new Rectangle(posX - 23, posY + 115, 15, 10);
            e.FillRectangle(Brushes.Pink, handLeftPlayer);
            /////////////
            //Рука до локтя игрока
            Rectangle armRightDownPlayer = new Rectangle(posX + 52, posY + 65, 10, 30);
            e.FillRectangle(Brushes.Pink, armRightDownPlayer);
            //Поворот руки игрока
            Rectangle armRightPlayer = new Rectangle(posX + 52, posY + 95, 20, 10);
            e.FillRectangle(Brushes.Pink, armRightPlayer);
            //Правая Кисть игрока
            Rectangle handRightPlayer = new Rectangle(posX + 72, posY + 94, 10, 15);
            e.FillRectangle(Brushes.Pink, handRightPlayer);
            ////////////

            //Пистолет игрока
            //Рукоятка пистолета
            Rectangle gunHandlePlayer = new Rectangle(posX + 75, posY + 85, 5, 20);
            e.FillRectangle(Brushes.Black, gunHandlePlayer);
            //Основа пистолета
            Rectangle gunBasisPlayer = new Rectangle(posX + 75, posY + 87, 30, 7);
            e.FillRectangle(Brushes.Black, gunBasisPlayer);
            //Палец на пистолете
            Rectangle fingerOnGunPlayer = new Rectangle(posX + 75, posY + 94, 10, 5);
            e.FillRectangle(Brushes.Pink, fingerOnGunPlayer);

            //Тело игрока
            Rectangle bodyPlayer = new Rectangle(posX - 10, posY + 45, 60, 80);
            e.DrawRectangle(Pens.Black, bodyPlayer);
            e.FillRectangle(Brushes.Blue, bodyPlayer);
            //Плечи игрока
            Rectangle shouldersPlayer = new Rectangle(posX - 22, posY + 50, 84, 20);
            e.FillRectangle(Brushes.Blue, shouldersPlayer);
            ////////////

            //Ноги Игрока
            Rectangle legPlayer = new Rectangle(posX - 10, posY + 105, 60, 80);
            e.FillRectangle(Brushes.Black, legPlayer);
            //Ремень игрока
            Rectangle beltPlayer = new Rectangle(posX - 10, posY + 110, 60, 10);
            e.FillRectangle(Brushes.Brown, beltPlayer);
            //Пряжка игрока
            Rectangle bucklePlayer = new Rectangle(posX + 15, posY + 110, 10, 10);
            e.FillRectangle(Brushes.Yellow, bucklePlayer);
            /////////////
        }
    }
}
