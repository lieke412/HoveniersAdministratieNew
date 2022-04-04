using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HoveniersAdministratieNew_DomeinClasses
{
    public abstract class Gebruiker
    {
        public string Naam;
        public bool IsManager;

        public Gebruiker(string Naam, bool IsManager)
        {
            this.Naam = Naam;
            this.IsManager = IsManager;
        }

        /*public void PlantenToevoegen()
        {
            FloraList.Add(this);
        }*/
    }
}
