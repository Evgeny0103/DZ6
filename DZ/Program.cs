using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.Json;


namespace DZ
{

    class Program
    {
        public static void Main(string[] args)
        {
            #region Пример № 1
            /*
             * Ввести с клавиатуры произвольный набор данных и сохранить его в текстовый файл. 
             */

            /*string text = Console.ReadLine();
            string filename = "Test.txt";
            File.WriteAllText(filename, text);
            */
            #endregion

            #region Пример № 2

            /*
             * Написать программу, которая при старте дописывает текущее время в файл «startup.txt».
             * 
             */

            /* string fileName = "startup.txt";
             string date =  Convert.ToString(DateTime.Now);
             File.AppendAllText(fileName, date);
            */

            #endregion

            #region Пример № 3

            /*
             * Ввести с клавиатуры произвольный набор чисел (0...255) и записать их в бинарный файл.
             * 
             */

            /* string fileName = "bytes.bin";
             Console.WriteLine("Введите число от 0 до 255");
             int number = int.Parse(Console.ReadLine());
             byte[] b = BitConverter.GetBytes(number);
             File.WriteAllBytes(fileName,b);
            */
            #endregion


            #region Пример № 4
            /*Сохранить дерево каталогов и файлов по заданному пути в текстовый файл — с рекурсией и без.*/
            /*  string workDir = @"D:\TestFolder";
              Console.WriteLine(Directory.Exists(workDir));
              string GBFolder = Path.Combine(workDir, "GeekBrains"); // "D:\TestFolder\GeekBrains"
              Directory.CreateDirectory(GBFolder); // Создаем вложенную директорию
              string Lesson5 = Path.Combine(GBFolder, "Lesson5");
              Directory.CreateDirectory(Lesson5);
              string PathText = $"{workDir}\n{GBFolder}\n{Lesson5}";
              string notePath = Path.Combine(Lesson5, "PathRoad.txt"); // "D:\TestFolder\GeekBrains\Lesson5\Note 1.txt"
              File.WriteAllText(notePath, PathText);
              string copyOfNotePath = Path.Combine(workDir, "Copy of PathRoad.txt");
              File.Copy(notePath, copyOfNotePath);
              Console.WriteLine(File.Exists(copyOfNotePath));
              File.Move(copyOfNotePath, Path.Combine(Lesson5, "PathRoad 2.txt"));
            */
            #endregion

            #region Пример № 5
            /* (*) Список задач(ToDo-list):
             написать приложение для ввода списка задач;
             задачу описать классом ToDo с полями Title и IsDone;
             на старте, если есть файл tasks.json / xml / bin(выбрать формат), загрузить из него массив имеющихся задач и вывести их на экран;
             если задача выполнена, вывести перед её названием строку «[x]»;
             вывести порядковый номер для каждой задачи;
             при вводе пользователем порядкового номера задачи отметить задачу с этим порядковым номером как выполненную;
             записать актуальный массив задач в файл tasks.json / xml / bin.
            */


            /*   string fName = "Tasks.json";
               byte y = 2;

               do
               {
                   createList();
                   Console.WriteLine("Ввести еще задачу  [1- Да / 2 - Нет]?");
                   y = Convert.ToByte(Console.ReadLine());

               } while (y != 2);
               Console.WriteLine();
               Console.ReadLine();



           }

           static void createList() 
           {
               string fName = "Tasks.json";
               Console.WriteLine("Введите новую задачу:");
               ToDo Task = new ToDo();
               string json = Console.ReadLine();
               bool done = pass(json);
               if (done) json = "[X]" + json;
               Task.duty(json, done);
               json = JsonSerializer.Serialize(Task);
               File.AppendAllText(fName, Environment.NewLine);
               File.AppendAllText(fName, json);
           }

           static bool pass(string str)
           {
               bool answer;
               byte y;
               do
               {
                   Console.WriteLine("Эта задача [" + str + "] уже выполнена? [1- Да / 2 - Нет]");
                   y = Convert.ToByte(Console.ReadLine());
               } while (y > 2 || y < 1);
               //
               if (y == 1) answer = true;
               else answer = false;
               return answer;
            */
        }

        #endregion

    }
}
    

