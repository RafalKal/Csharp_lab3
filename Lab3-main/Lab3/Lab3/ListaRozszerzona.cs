using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    static class ListaRozszerzona
    {
        public static void WypiszOsoby(this List<Osoba> list)
        {
            foreach (Osoba osoba in list)
            {
                Console.WriteLine(osoba.ZwrocPelnaNazwe());
            }
        }

        public static void PosortujOsobyPoNazwisku(this List<Osoba> list)
        {
            list.Sort((a, b) => a.getNazwisko().CompareTo(b.getNazwisko()));
        }
    }
}
