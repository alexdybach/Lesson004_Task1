using System;

namespace Lesson004_Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 2, y = 4, z = 3;
            x += y >> x - 1;
            Console.WriteLine($"x += y >> x - 1 \nx = {x}");

            x = 2;
            y = 4;
            z = 3;
            z = --x & y * 3;
            Console.WriteLine($"z = --x & y * 3 \nz = {z}");

            x = 2;
            y = 4;
            z = 3;
            y *= x + 4 | z + 2;
            Console.WriteLine($"y *= x + 4 | z + 2 \ny = {y}");

            x = 2;
            y = 4;
            z = 3;
            z = x++ & y * 2;
            Console.WriteLine($"z = x++ & y * 2 \nz = {z}");

            x = 2;
            y = 4;
            z = 3;
            x = y << x++ ^ z;
            Console.WriteLine($"x = y << x++ ^ z \nx = {x}");

            x = 2;
            y = 4;
            z = 3;
            z = x-- & y * 2 | z;
            Console.WriteLine($"z = x-- & y * 2 | z \nz = {z}");

            x = 2;
            y = 4;
            z = 3;
            x = y << ++x ^ z;
            Console.WriteLine($"x = y << ++x ^ z \nx = {x}");
        }
    }
}
