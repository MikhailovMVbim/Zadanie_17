using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 *  Создать класс для моделирования счета в банке. Предусмотреть закрытые поля для номера счета, баланса, ФИО владельца.
 *  Класс должен быть объявлен как обобщенный. Универсальный параметр T должен определять тип номера счета.
 *  Разработать  методы  для  доступа  к  данным  –  заполнения  и  чтения.
 *  Создать  несколько экземпляров класса, параметризированного различными типам.
 *  Заполнить его поля и вывести информацию об экземпляре класса на печать.
 */

namespace Zadanie_17
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 17. Обобщенные классы.");
            Console.WriteLine("------------------------------");
            BankAccaunt<int> acc1 = new BankAccaunt<int>();
            acc1.SetInfo(111111, 150000, "Мухин Иван Рудольфович");
            acc1.GetInfo();

            BankAccaunt<string> acc2 = new BankAccaunt<string>();
            acc2.SetInfo("Ы 8545-Ж", 499000, "Петров Христофор Колумбович");
            acc2.GetInfo();

            BankAccaunt<string> acc3 = new BankAccaunt<string>();
            acc2.SetInfo("USA-555777", 10000000000000000000, "Фейсбуков Марк Цукербергович");
            acc2.GetInfo();

            Console.ReadKey();
        }
    }

    class BankAccaunt<T>
    {
        private T accNumber;
        private double balance;
        private string fio;

        public T AccNumber
        {
            set
            {
                accNumber = value;
            }
            get
            {
                return accNumber;
            }
        }

        public double Balance
        {
            set
            {
                balance = value;
            }
            get
            {
                return balance;
            }
        }

        public string FIO
        {
            set
            {
                fio = value;
            }
            get
            {
                return fio;
            }
        }

        public void SetInfo (T value,double balance, string fio)
        {
            AccNumber = value;
            Balance = balance;
            FIO = fio;
        }
        public void GetInfo ()
        {
            Console.WriteLine("Информация о счете № {0}: ",AccNumber);
            Console.WriteLine("Владелец счета: {0}",FIO);
            Console.WriteLine("Доступные средства: {0} руб.",Balance);
            Console.WriteLine("------------------------------");
        }
    }
}
