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
        public string Rol;

        public Gebruiker(string Naam, string Rol)
        {
            this.Naam = Naam;
            this.Rol = Rol; 
        }

        /*public void PlantenToevoegen()
        {
            FloraList.Add(this);
        }*/
    }
}
