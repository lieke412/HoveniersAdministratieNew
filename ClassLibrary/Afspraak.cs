using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HoveniersAdministratieNew_DomeinClasses
{
    public class Afspraak : Klant
    {
        private string AfspraakNaam;
        private DateTime AfspraakMoment;

        private Afspraak(string AfspraakNaam, DateTime AfspraakMoment, string KlantNaam, string Adres) : base(KlantNaam, Adres)
        {
            this.AfspraakNaam = AfspraakNaam;
            this.AfspraakMoment = AfspraakMoment;
        }
    }
}
