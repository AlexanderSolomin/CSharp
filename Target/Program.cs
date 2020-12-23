using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Target
{

    class TargetSum
    {
        struct Point
        {
            public int x;
            public int y;
            public int score;
        }

        static int score(int x, int y)
        {
            if (x <= 1 && x >= -1 && y <= 1 && y >= -1)
            {
                return 10;
            }
            else if (x <= 2 && x >= -2 && y <= 2 & y >= -2)
            {
                return 5;
            }
            else
            {
                return 0;
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество выстрелов: ");
            int shotNum = int.Parse(Console.ReadLine());

            Point p = new Point();
            Point[] shotArray = new Point[shotNum];
            int scoreSum = 0;

            for (int i = 0; i < shotArray.Length; i++)
            {
                Console.WriteLine("Введите x: ");
                p.x = int.Parse(Console.ReadLine());
                Console.WriteLine("Введите y: ");
                p.y = int.Parse(Console.ReadLine());
                p.score = score(p.x, p.y);
                Console.WriteLine($"x = {p.x}, y = {p.y}, баллов: {p.score}");
                scoreSum += p.score;
                shotArray[i] = p;
            }

            Console.WriteLine($"Набрано баллов: {scoreSum}\n");





        }
    }
}
