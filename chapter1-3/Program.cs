using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chapter1_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Studend stu = new Studend {Name="takio", Grade = 3, ClassNumber = 4 };
            Console.WriteLine("名前{0}学年{1}クラス{2}",stu.Name,stu.Grade,stu.ClassNumber);
           // Console.ReadKey();
            Person person = stu;
            if (person is Studend)
                Console.WriteLine($"名前{person.Name}");
            // Console.ReadKey();
            object obj = stu;
            if (obj is Studend)
                Console.WriteLine("obj is Studend");

            obj = stu.Name;
                Console.WriteLine($"名前{obj}");

        }
    }

    public class Person
    {
        public string Name { get; set; }
        public DateTime Birthday { get; set; }
        public int GetAge()
        {
            DateTime today = DateTime.Today;
            int age = today.Year - Birthday.Year;
            if (today < Birthday.AddYears(age))
                age--;
            return age;
        }
    }
    public class Studend : Person
    {
        public int Grade { get; set; }
        public int ClassNumber { get; set; }
    }
}
