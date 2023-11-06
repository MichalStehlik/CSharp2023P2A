using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp04Properties
{
    internal class Human // rodič, matka
    {
        protected string _firstname; 
        // modifikátor přístupu
        // private - nepřístupné, nedědí se
        // protected - nepřístupné, dědí se
        // public - přístupné, dědí se


        public Human(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public string GetFirstName() { return _firstname; }
        public void SetFirstName(string fn) 
        { 
            if (fn != "Adolf")
            {
                _firstname = fn;
            }    
        }

        public string FirstName // vlastnost - property
        {
            get { return _firstname; } // getter
            set // setter
            {
                if (value != "Adolf")
                    _firstname = value;
            }
        }

        public string LastName { get; set; } // autoimplementovaná vlastnost
        // prop + tab + tab
        public string FullName { get { return FirstName + " " + LastName; } }
    }
}
