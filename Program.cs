internal class Program
{
    private static void Main(string[] args)
    {
        // Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
        // 645 -> 5
        // 78 -> третьей цифры нет
        // 32679 -> 6
        Console.WriteLine("Введите число");
        int i = Convert.ToInt32(Console.ReadLine());
        if (i > 99)
        {
            for (i = i; i > 999; i = i / 10) ;
            {
                Console.WriteLine(i % 10);
            }
        }
        else
        {
            Console.WriteLine("Третьей цифры нет");
        }
    }
}