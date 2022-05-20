using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonDataManagement
{
    public class PersonManagement
    {
        List<Person> list = new List<Person>();
        public void AddPerson()
        {
            list.Add(new Person { SSN = 101, Name = "Ajay", Address = "Lucknow", Age = 55 });
            list.Add(new Person { SSN = 102, Name = "Vijay", Address = "Delhi", Age = 70 });
            list.Add(new Person { SSN = 103, Name = "Aman", Address = "Basti", Age = 80 });
            list.Add(new Person { SSN = 104, Name = "Anish", Address = "GorakhPur", Age = 40 });
            list.Add(new Person { SSN = 105, Name = "Suraj", Address = "Noida", Age = 15 });
            list.Add(new Person { SSN = 106, Name = "Anurag", Address = "Gaziyabad", Age = 55 });
        }
        public void GetTopRecords()
        {
            var result = this.list.Where(x => x.Age < 60).Take(2);
            Display(result);
        }
        public void Display(IEnumerable<Person> list)
        {
            foreach (Person person in list)
            {
                Console.WriteLine(person.SSN + " " + person.Name + " " + person.Address + " " + person.Age);
            }
        }
    }
}
