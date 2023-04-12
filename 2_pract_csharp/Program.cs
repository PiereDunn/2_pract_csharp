using System;
namespace _2_pract_csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            string fullName = "Прокопчик Максим Алексеевич";
            string eMail = "prokopchikm@bk.ru";
            string personality = "Скрытный";
            string married = "Не женат";
            byte age = 22;
            double programPoints = 70.4;
            double mathPoints = 88.3;
            double physicsPoints = 95.5;
            double sumOfPoints;
            double middlePoints;

            Console.WriteLine($"Ф.И.О: {fullName}");
            Console.WriteLine($"Почта: {eMail}");
            Console.WriteLine($"Возраст: {age}");
            Console.WriteLine($"Баллы по программированию: {programPoints}");
            Console.WriteLine($"Баллы по математике: {mathPoints}");
            Console.WriteLine($"Баллы по физике {physicsPoints}");
            Console.WriteLine($"Характер: {personality}");
            Console.WriteLine($"{married}");

            Console.ReadKey();

            sumOfPoints = programPoints + mathPoints + physicsPoints;
            middlePoints = sumOfPoints / 3;

            Console.WriteLine($"Сумма баллов: {sumOfPoints}");
            Console.WriteLine($"Среднее арифметическое баллов: {middlePoints}");

            Console.ReadKey();
        }
    }
}
