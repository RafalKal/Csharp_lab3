using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    public class Osoba : IOsoba
    {
        private string imie;
        private string nazwisko;

        public string ZwrocPelnaNazwe()
        {
            return imie + " " + nazwisko;
        }

        public Osoba(string imie, string nazwisko)
        {
            this.imie = imie;
            this.nazwisko = nazwisko;
        }

        public Osoba()
        {

        }

        public void Imie(string imie)
        {
            this.imie = imie;
        }
        
        public void Nazwisko(string nazwisko)
        {
            this.nazwisko = nazwisko;
        }

        public string getNazwisko()
        {
            return this.nazwisko;
        }

    }
}
