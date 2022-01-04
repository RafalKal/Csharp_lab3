using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    public class Student : IStudent
    {
        private string imie;
        private string nazwisko;
        private string uczelnia;
        private string kierunek;
        private int rok;
        private string semestr;

        public Student(string imie, string nazwisko, string uczelnia, string kierunek, int rok, string semestr)
        {
            this.uczelnia = uczelnia;  
            this.kierunek = kierunek;
            this.rok = rok;
            this.semestr = semestr;
        }

        public Student()
        {

        }

        public String WypiszPelnaNazweIUczelnie()
        {
            return ZwrocPelnaNazwe() + " - " + kierunek + " " + rok + " " + semestr + " " + uczelnia; 
        }
        public void setImie(string imie)
        {
            this.imie = imie;
        }
        public void setNazwisko(string nazwisko)
        {
            this.nazwisko = nazwisko;
        }

        public void setUczelnia(string uczelnia)
        {
            this.uczelnia = uczelnia;
        }

        public void setKierunek(string kierunek)
        {
            this.kierunek = kierunek;
        }

        public void setRok(int Rok)
        {
            this.rok = rok;
        }

        public void setSemestr(string semestr)
        {
            this.semestr = semestr;
        }

        public string ZwrocPelnaNazwe()
        {
            return imie + " " + nazwisko;
        }
    }
}
