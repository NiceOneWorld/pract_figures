using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cw_011
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Square: ");
            Square sq = null;
            // проверка на отрицательное число или 0
            try
            {
                sq = new Square(-2);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            // создание Square
            try
            {
                sq = new Square(2);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            Console.WriteLine($"Square Perimeter = {sq.Perimeter():0.00}");
            Console.WriteLine($"Square Area = {sq.Area():0.00}");
            Console.WriteLine("---------------------------\n");

            Console.WriteLine($"Rectangle: ");
            Rectangle rec = null;
            // проверка на отрицательное число или 0
            try
            {
                rec = new Rectangle(2.0, 0);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            // создание Rectangle
            try
            {
                rec = new Rectangle(2.0, 4.0);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            Console.WriteLine($"Rectangle Perimeter: {rec.Perimeter():0.00}");
            Console.WriteLine($"Rectangle Area: {rec.Area():0.00}");
            Console.WriteLine("---------------------------\n");

            Console.WriteLine($"Triangle: ");
            Triangle triangle = null;
            // проверка на отрицательное число или 0
            try
            {
                triangle = new Triangle(10, 12, -97);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            // проверка на угол больше 180
            try
            {
                triangle = new Triangle(10, 12, 197);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            // создание Triangle
            try
            {
                triangle = new Triangle(10, 12, 97);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            Console.WriteLine($"Third side: {triangle.ThirdSide():0.00}");
            Console.WriteLine($"Height: {triangle.Height:0.00}");
            Console.WriteLine($"Triangle Perimeter: {triangle.Perimeter():0.00}");
            Console.WriteLine($"Triangle Area: {triangle.Area():0.00}");
            Console.WriteLine("---------------------------\n");

            Console.WriteLine($"Parallelogram: ");
            Parallelogram pg = null;
            // проверка на отрицательное число или 0
            try
            { 
                pg = new Parallelogram(0, 12, 97);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            // проверка на угол больше 180
            try
            {
                pg = new Parallelogram(10, 12, 197);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            // создание Parallelogram
            try
            {
                pg = new Parallelogram(10, 12, 97);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            Console.WriteLine($"Parallelogram Perimeter: {pg.Perimeter():0.00}");
            Console.WriteLine($"Parallelogram Height: {pg.Height:0.00}");
            Console.WriteLine($"Parallelogram Area: {pg.Area():0.00}");
            Console.WriteLine("---------------------------\n");

            Console.WriteLine($"Circle: ");
            Circle circle = null;
            // проверка на отрицательное число или 0
            try
            {
                circle = new Circle(-9);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            // создание Circle
            try
            {
                circle = new Circle(9);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            Console.WriteLine($"Circle radius: {circle.SideBase:0.00}");
            Console.WriteLine($"Circle diameter: {circle.Height:0.00}");
            Console.WriteLine($"Circle Perimeter: {circle.Perimeter():0.00}");
            Console.WriteLine($"Circle Area: {circle.Area():0.00}");
            Console.WriteLine("---------------------------\n");

            Console.WriteLine($"Rhombus: ");
            Rhombus rhombus = null;
            // проверка на отрицательное число или 0
            try
            {
                rhombus = new Rhombus(10, -45);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            // проверка на угол больше 180
            try
            {
                rhombus = new Rhombus(10, 245);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            // создание Rhombus
            try
            {
                rhombus = new Rhombus(10, 45);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            Console.WriteLine($"Rhombus Perimeter: {rhombus.Perimeter():0.00}");
            Console.WriteLine($"Rhombus Height: {rhombus.Height:0.00}");
            Console.WriteLine($"Rhombus Area: {rhombus.Area():0.00}");
            Console.WriteLine("---------------------------\n");

            Console.WriteLine($"Compound Figure:");
            CompoundFigure cf = new CompoundFigure(5);
            cf.AddFigure(sq);
            cf.AddFigure(rec);
            cf.AddFigure(triangle);
            cf.AddFigure(pg);
            cf.AddFigure(rhombus);
            Console.WriteLine($"Square Area = {sq.Area():0.00}");
            Console.WriteLine($"Rectangle Area: {rec.Area():0.00}");
            Console.WriteLine($"Triangle Area: {triangle.Area():0.00}");
            Console.WriteLine($"Parallelogram Area: {pg.Area():0.00}");
            Console.WriteLine($"Rhombus Area: {rhombus.Area():0.00}");
            Console.WriteLine($"The area of this figure = {cf.FindArea():0.00}");
        }
    }
}
