using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26_11_2022
{
    class Student
    {
        public string FIO { get; protected set; }
        public int Group_number { get; protected set; }
        public Student()
        {
            FIO = "Медведев Андрей Юрьевич";
            Group_number = 221;
        }
        public override string ToString()
        {
            return $"ФИО: {FIO}\nНомер группы: {Group_number}";
        }
    }
    class Aspirant : Student
    {
        public string VKR_theme { get; private set; }
        public Aspirant()
        {
            FIO = "Медведев Андрей Юрьевич";
            Group_number = 221;
            VKR_theme = "Компьютерная игра";
        }
        public override string ToString()
        {
            return $"ФИО: {FIO}\nНомер группы: {Group_number}\nТема ВКР: {VKR_theme}";
        }
    }
    class Transport
    {
        public double Speed { get; protected set; }
    }
    class Airplane : Transport
    {
        public Airplane() { Speed = 800; }
        public override string ToString()
        {
            return $"Самолёт летит со скоростью {Speed} км/ч";
        }
    }
    class Cart : Transport
    {
        public Cart() { Speed = 5; }
        public override string ToString()
        {
            return $"Телега тащится со скоростью {Speed} км/ч";
        }
    }
    class Car : Transport
    {
        public Car() { Speed = 60; }
        public override string ToString()
        {
            return $"Машина едет со скоростью {Speed} км/ч";
        }
    }
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Задание 1");
            Console.WriteLine();
            Console.WriteLine($"Студент:\n{new Student()}");
            Console.WriteLine();
            Console.WriteLine($"Аспирант:\n{new Aspirant()}");
            Console.WriteLine();
            Console.WriteLine("Задание 2");
            Console.WriteLine();
            Console.WriteLine(new Airplane());
            Console.WriteLine(new Cart());
            Console.WriteLine(new Car());
        }
    }
}
