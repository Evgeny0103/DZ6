using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ
{
    class Program
    {
        static void Main(string[] args)
        {

            // Получение списка запущенных процессов на ПК
            foreach (Process process in Process.GetProcesses())
            {

                Console.WriteLine($"ИД процесса {process.Id} Имя процесса {process.ProcessName}");
            }
            Console.WriteLine("Введите пожалуйста номер ID процесса который хотите завершить");


            // Вводим нужный номер и процесс завершается 
            int proccName = int.Parse(Console.ReadLine());
            foreach (Process process in Process.GetProcesses())
            {

                if (process.Id == proccName)
                {
                    process.Kill();
                }

            }

        }
    }
}
