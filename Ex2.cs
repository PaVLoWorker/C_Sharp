//Написати програму. Дано три сторони трикутника. Обчислити периметр та площу трикутника. Визначити вид трикутника за сторонами.
//(потрібно робити перевірку на дійсність трикутника та на коректність введених даних).
namespace pz1
{
    internal class Ex2 
    {
        public void Exercise ()
        {
            int a = 5; //katet
            int b = 10; //katet
            int c = 15; //gipotenuza
            int Outline = a + b + c;

            Console.WriteLine("Outline of a rectangle : " + Outline);

            int Area = a * b * c;

            Console.WriteLine("Area of a rectangele : " + Area);
            TypeRectangle(a, b, c);
        }

        private void TypeRectangle(int a, int b, int c)
        {
            if (a == b && a == c)
                Console.WriteLine("--------------------------------Equilateral triangle--------------------------------");
            else if (a == b || a == c || b == c)
                Console.WriteLine("--------------------------------Isosceles triangle--------------------------------");
            else
                Console.WriteLine("--------------------------------Scalene triangle--------------------------------");
        }

    }
}