using Tyuiu.SosninRA.Sprint1.Task3.V2.Lib;

namespace Tyuiu.SosninRA.Sprint1.Task3.V2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #1 | Выполнил: Соснин Р. А. | ИИПб-26-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Базовые навыки работы в C#                                        *");
            Console.WriteLine("* Задание #0                                                              *");
            Console.WriteLine("* Вариант #14                                                             *");
            Console.WriteLine("* Выполнил Соснин Руслан Александрович | ИИПб-26-1                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Известна температура в градусах Кельвина. Перевести температуру          *");
            Console.WriteLine("* в градусы Цельсия.                                                      *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Введите цену тетради:");
            double priceNotebook = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите количество тетрадей:");
            int amountNotebook = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите цену карандаша:");
            double pricePencil = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите количество карандашей:");
            int amountPencil = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Стоимость покупки: " + ds.PurchaseAmount(priceNotebook, amountNotebook, pricePencil, amountPencil));

            Console.ReadLine();
        }
    }
}
