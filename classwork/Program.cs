namespace classwork
{
    internal class Program
    {
        /*Задание 1
Создайте generic версию метода вычисления максимума из трёх чисел.

*/
        static void Main(string[] args)
        {
            int a = 4, b = 81, c = 12;
            int max = GenericCompare.Max(a, b, c);
            Console.WriteLine("Максимальное значение з трёх чисел: " + max);
        }
    }
}
