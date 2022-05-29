namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Задание
            Используя Visual Studio, создайте проект по шаблону Console Application.
            Требуется:
            Создать статический класс Calculator, с методами для выполнения основных арифметических
            операций.
            Написать программу, которая выводит на экран основные арифметические операции.*/
            Console.WriteLine("Calculator");
            Console.WriteLine(StaticClass.StaticCalculation.Umn(10, 5));
            Console.WriteLine(StaticClass.StaticCalculation.Del(10, 5));
            Console.WriteLine(StaticClass.StaticCalculation.Sum(10, 5));
            Console.WriteLine(StaticClass.StaticCalculation.Minus(10, 5));
        }
    }
}
