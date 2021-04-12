using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SmallBasic.Library;


namespace Треугольник_Серпинского
{
    class Program
    {
        static void Main(string[] args)
        {
            GraphicsWindow.Show();



            GraphicsWindow.SetPixel(10, 10, "red");

            int x1 = 312, y1 = 10,
                x2 = 10, y2 = 430,
                x3 = 610, y3 = 430
                ;
            GraphicsWindow.SetPixel(x1, y1, "red");
            GraphicsWindow.SetPixel(x2, y2, "red");
            GraphicsWindow.SetPixel(x3, y3, "red");

            int size = 1;

            GraphicsWindow.DrawEllipse(x1 - size / 2, y1 - size / 2, size, size);
            GraphicsWindow.DrawEllipse(x2 - size / 2, y2 - size / 2, size, size);
            GraphicsWindow.DrawEllipse(x3 - size / 2, y3 - size / 2, size, size);
            Random random = new Random();
            GraphicsWindow.MouseDown += () =>
             {
                 int x = x1, y = y1;
                 for(int i = 0; i <10000; i++)
                 {
                     switch (random.Next(3))
                     {
                         case 0: x = (x + x1) / 2; y = (y + y1) / 2; break;
                         case 1: x = (x + x2) / 2; y = (y + y2) / 2; break;
                         case 2: x = (x + x3) / 2; y = (y + y3) / 2; break;

                     }
                     //GraphicsWindow.DrawEllipse(x - size / 2, y - size / 2, size, size);
                     GraphicsWindow.SetPixel(x, y, "red");

                 }



                 //GraphicsWindow.DrawEllipse(
                 //    x: GraphicsWindow.MouseX - size / 2 ,
                 //    y: GraphicsWindow.MouseY - size / 2,
                 //    width: size,
                 //    height: size);

             };



        }
    }
}
