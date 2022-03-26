using System; //Содержит фундаментальные и базовые классы, определяющие часто используемые типы значений и ссылочных данных, события и обработчики событий, интерфейсы, атрибуты и исключения обработки.
using System.IO; //Содержит типы, позволяющие осуществлять чтение и запись в файлы

namespace FileSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите путь к папке для создания файлов: "); //Вывод
            string? folder = Console.ReadLine(); //Считывание ввода пользователя
            Console.Write("Введите кол-во случайных файлов, которые хотите создать: "); //Вывод
            int count = int.Parse(Console.ReadLine()); //Считывание ввода пользователя

            try
            {
                for (int i = 1; i <= count; i++) //Цикл
                {
                    string folderName = @""; // Пуcтой путь к папке
                    folderName = System.IO.Path.Combine(folderName, folder); //Комбинирование пустого пути с путём пользователя
                    string fileName = System.IO.Path.GetRandomFileName(); // Создние случайного имени для файла
                    folderName = System.IO.Path.Combine(folderName, fileName); // Комбинирование имени файла в путь
                    Console.WriteLine("Путь к файлу: {0}\n", folderName); // Проверка объединения пути
                    System.IO.File.Create(folderName); //Создание файла
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message); // try-catch - конструкция для ошибок которые трудно предусмотреть
            }
        }
    }
}
