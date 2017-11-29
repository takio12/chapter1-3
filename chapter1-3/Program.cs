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
