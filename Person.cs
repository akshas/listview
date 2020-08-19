using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginForm
{
    class Person
    {
        public string Vorname { get; set; }
        public string Nachname { get; set; }
        public string PLZ { get; set; }
        public string Strasse { get; set; }
        public string Hausnummer { get; set; }


        public Person(string w1, string w2, string w3, string w4, string w5)
        {
            Vorname    = w1;
            Nachname   = w2;
            PLZ        = w3;
            Strasse    = w4;
            Hausnummer = w5;
        }
    }
}
