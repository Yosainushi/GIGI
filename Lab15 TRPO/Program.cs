using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab15_TRPO
{
    class Person
    {
        public string Name;
        private int age;
        public Person(string name)
        {
            Name = name;
        }
        public int Age
        {
            get { return age; }
            set
            {
                if (value < 18)
                { new AgeOverSizeException("Лицам до 18 регистрация запрещена", value).Show(); }
                else
                    age = value;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите кол-во персон");
            int kolvo = Convert.ToInt32(Console.ReadLine());
            Person[] people = new Person[kolvo];
            for (int i = 0; i < kolvo; i++)
            {
                Console.WriteLine("Введите Имя");
                string n = Console.ReadLine();
                Console.WriteLine("Введите возраст");
                int a = int.Parse(Console.ReadLine());
                people[i] = new Person(n);
                people[i].Age = a;
                
                
            }
            Console.ReadKey();
        }
    }
}
