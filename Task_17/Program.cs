using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_17
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите ФИО:"); 
            string name = Console.ReadLine(); //ввод имени с консоли
            Console.WriteLine("Введите числовой номер счета:");
            int accountNumber = Convert.ToInt32(Console.ReadLine());  //ввод номера с консоли
            Console.WriteLine("Введите баланс:");
            int balance = Convert.ToInt32(Console.ReadLine()); //ввод баланса с консоли

            Account<int> account1 = new Account<int>(name, accountNumber, balance); //создаем экземпляр класса Account с числовым номером

            account1.Print(); //вызов метода Print для экземпляра account1


            Console.WriteLine("Введите ФИО:");
            name = Console.ReadLine();
            Console.WriteLine("Введите строковый номер счета:");
            string accountNumberString = Console.ReadLine();
            Console.WriteLine("Введите баланс:");
            balance = Convert.ToInt32(Console.ReadLine());
            
            Account<string> account2 = new Account<string>(name, accountNumberString, balance);  //создаем экземпляр класса Account со строковым номером

            account2.Print(); //вызов метода Print для экземпляра account2

            Console.ReadKey();



        }
    }
    
}

