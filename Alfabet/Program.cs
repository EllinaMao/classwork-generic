namespace Alfabet
{
    /*        Задание 2
Создайте класс Алфавит. Он должен содержать буквы
английского алфавита. Реализуйте поддержку итератора.
Протестируйте возможность использования foreach для
класса алфавита*/

    internal static class Program
    {
        static void Main(string[] args)
        {
            foreach (char letter in new EnglishAlphabet())
            {
                Console.Write(letter + " ");
            }
        }
    }
}
