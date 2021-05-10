using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;


namespace ClassStructure
{
    class Car
    {
        private int speed = 0;
        public void PrintSpeed()
        {
            if (speed == 0)
            {
                Console.WriteLine("Стоим на месте...");
            }
            if (speed > 0)
            {
                Console.WriteLine($"Едим вперёд со скоростью {speed} км\\ч");
            }

            if (speed < 0)
            {
                Console.WriteLine($"Едим назад со скоростью {speed} км\\ч");
            }
        }

        public void DriveForward()
        {
            speed = 60;
        }

        public void Stop()
        {
            speed = 0;
        }

        public void DriveBackward()
        {
            speed = -5;
        }
    }



    enum Color
    {
        Red,
        Green,
        Orange,
        Yellow,
        Blue
    }


    class Point //чертёж  class- ссылочный тип данных
    {
        public int x;
        public int y;

        public Color color;

        private int y2 = 44;

        public void PrintY()
        {
            Console.WriteLine($"Y :{y2}");
        }


    }


    class Program
    {
        static void Main(string[] args)
        {
            Point p = new Point();  //
            p.x = 4;
            p.y = 2;
            p.color = Color.Orange;
            

            Console.WriteLine(p.x);
            Console.WriteLine(p.y);

            Console.WriteLine($"X:{p.x} | Y:{p.y} | Color: {p.color}");

            Point p2 = new Point(); //p2 -объект класса
            p2.x = 2;
            p2.y = 6;

            Console.WriteLine("******************************************************************************");

            Console.WriteLine("\t==Car 1==");
            var car = new Car();
            car.PrintSpeed();
            car.DriveForward();
            car.PrintSpeed();
            car.Stop();
            car.PrintSpeed();

            Console.WriteLine("\t==Car 2==");
            var car2 = new Car();

            car2.PrintSpeed();
            car2.DriveBackward();
            car2.PrintSpeed();

            Console.WriteLine("******************************************************************************");

            Point point2 = new Point();

            point2.PrintY();


            Console.WriteLine("******************************************************************************");

            var typeInfo = typeof(Point).GetFields(BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public);


        }
    }
}
