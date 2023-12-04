using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
class Program
{
    static void Main()
    {
        // Завдання 1
        Console.Write("Введіть довжину першої сторони прямокутника: ");
        double side1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введіть довжину другої сторони прямокутника: ");
        double side2 = Convert.ToDouble(Console.ReadLine());

        Rectangle myRectangle = new Rectangle(side1, side2);

        Console.WriteLine($"Площа прямокутника: {myRectangle.Area}");
        Console.WriteLine($"Периметр прямокутника: {myRectangle.Perimeter}");

        // Завдання 2
        Point point1 = new Point(0, 0, "A");
        Point point2 = new Point(0, 4, "B");
        Point point3 = new Point(3, 4, "C");

        Figure myFigure = new Figure(point1, point2, point3);
        myFigure.CalculatePerimeter();

        Console.ReadLine();
    }
}