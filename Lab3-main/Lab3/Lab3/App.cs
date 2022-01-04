using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    internal class App
    {
        static void Main(string[] args)
        {
            List<Osoba> list = new List<Osoba>();
            Osoba osoba1 = new Osoba("Andrzej", "Mistrz");
            Osoba osoba2 = new Osoba("Kacper", "Mondry");
            Osoba osoba3 = new Osoba("Janusz", "Januszowski");

            list.Add(osoba1);
            list.Add(osoba2);
            list.Add(osoba3);
            Console.WriteLine("Wszystkie osoby: ");
            list.WypiszOsoby();
            Console.WriteLine("\nWszystkie osoby posortowane: ");
            list.PosortujOsobyPoNazwisku();
            list.WypiszOsoby();

            /*
            List<StudentUR> students = new List<StudentUR>();
            StudentUR student = new StudentUR("Andrzej", "Majster", "UR", "Informatyka", 2020, "1");
            StudentUR student1 = new StudentUR("Karolina", "Maćko", "PK", "Human", 2021, "2");
            StudentUR student2 = new StudentUR("Maciek", "Bogdaniec", "AGH", "Górnictwo", 2022, "4");

            students.Add(student);
            students.Add(student1);
            students.Add(student2);

            Console.WriteLine("Wszyscy studenci: "); */
        }
    }
}
