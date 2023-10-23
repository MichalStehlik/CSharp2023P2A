using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp03OOP
{
    internal class Book
    {
        private string _title = default; // datová položka, atribut
        private string _author;
        // implicitní konstruktor

        public void SetTitle(string title) // metoda
        {
            if (title != "XXXXXX")
            {
                _title = title;
            }
            // this.title = title;
        }
        public string GetAuthor() // metoda
        {
            return _author;
        }

        public void SetAuthor(string author) // metoda
        {
            if (author != "")
            {
                _author = author;
            }
            // this.title = title;
        }
        public string GetTitle() // metoda
        {
            return _title;
        }

        public string GetName()
        {
            return _author + ": " + _title;
        }

        public Book(string title) // konstruktor
        {
            _title = title;
            _author = "?";
        }

        /*
        public Book(string title, string author) // konstruktor, přetížení konstruktorů
        {
            _title = title;
            _author = author;
        }
        */
        public Book(string title, string author = "?") // konstruktor, implicitní parametr
        {
            _title = title;
            _author = author;
        }

        ~Book() // destruktor
        {
            // úklid objektu
        }

        // vlastnosti
        // inicializace objektu
        // zapouzdření a dědičnost
    }
}
