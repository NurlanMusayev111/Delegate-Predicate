using Delegate_prdicate_HOMEWORK.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate_prdicate_HOMEWORK
{
    public class DatasControllers
    {

        public void CheckPerson(List<Person> persons , Predicate<Person> func)
        {
            foreach (Person person in persons)
            {
                if (func(person))
                {
                    Console.WriteLine($"{person.Name} - {person.Surname} - {person.Address}");
                }
            }
        }

        
        public void CheckBook(List<Book> books , Predicate<Book> func)
        {
            int sum = 0;
            foreach (Book book in books)
            {
                if (func(book))
                {
                    sum++;
                }
            }
            Console.WriteLine(sum);
        }


        public void ShowResult()
        {
            List<Person> person = new List<Person>() 
            {
                new Person {Name = "Nurlan" , Surname = "Musayev" , Address = "Nerimanov" , Salary = 5000},
                new Person {Name = "Rufat" , Surname = "Nasibov" , Address = "Nerimanov" , Salary = 900},
                new Person {Name = "Samil" , Surname = "Ferruxov" , Address = "Azadliq" , Salary = 1400},
            };

            List<Book> book = new List<Book>()
            {
                new Book { Author = "Nizami" , Name = "Xemse"},
                new Book { Author = "Nizami" , Name = "Yeddi Gozel"},
                new Book { Author = "Nizami" , Name = "Leyli Mecnun"},
                new Book { Author = "Semed Vurgun" , Name = "Azerbaycan"}
            };

            CheckPerson(person, person => person.Salary > 1000);
            CheckBook(book, book => book.Author == "Nizami");
        }
    }
}
