using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HoveniersAdministratieNew_DomeinClasses
{
    public class Klant
    {
        private string KlantNaam;
        private string Adres;

        public Klant (string KlantNaam, string Adres)
        {
            this.KlantNaam = KlantNaam;
            this.Adres = Adres;
        }
    }
}
