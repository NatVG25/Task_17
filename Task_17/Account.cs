using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_17
{
    class Account<T> //создаем обобщенный класс Account
    {
        //автоствойства
        public string Name { get; set; }
        public T AccountNumber { get; set; }
        public int Balance { get; set; }

        //конструктор
        public Account(string name, T accountNumber, int balance)
        {
            Name = name;
            AccountNumber = accountNumber;
            Balance = balance;
        }

        
        public void Print() //метод выводящий информацию на консоль
        {
            Console.WriteLine("Товарищ {0} \n Номер счета: {1} \n Баланс {2}", Name, AccountNumber, Balance);
        }

    }
}
