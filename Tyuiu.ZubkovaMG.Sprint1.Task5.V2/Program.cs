using Tyuiu.ZubkovaMG.Sprint1.Task5.V2.Lib;

namespace Tyuiu.ZubkovaMG.Sprint1.Task5.V2
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнила: Зубкова М. Г. | ИСПб-26-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Преобразование типов и класс Convert                              *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #2                                                              *");
            Console.WriteLine("* Выполнила: Зубкова Мария Геннадьевна | ИСПб-26-1                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дано значение температуры в градусах Фаренгейта.                        *");
            Console.WriteLine("* Определить значение этой же температуры в градусах Цельсия.             *");
            Console.WriteLine("* Ответ привести к целому с помощью класса Convert.                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.Write("Введите температуру в градусах Фаренгейта: ");
            double fahrenheit = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            int celsius = ds.FahrenheitToСelsius(fahrenheit);
            Console.WriteLine("Температура в градусах Цельсия = " + celsius);

            Console.WriteLine("***************************************************************************");
            Console.ReadKey();
        }
    }
}