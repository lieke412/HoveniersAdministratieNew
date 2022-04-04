using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HoveniersAdministratieNew_DomeinClasses
{
    public class Flora : Klant
    {
        private readonly string FloraNaam;
        private readonly DateTime FloraWaterMoment;
        private readonly string FloraJaargetijdeWater;
        private readonly int FloraWaterAantal;
        private readonly DateTime FloraSnoeiMoment;
        private readonly string FloraJaargetijdeSnoeien;
        private readonly int FloraSnoeienAantal;
        private readonly string FloraOpmerkingen;
        private readonly string FloraSoort;
        public readonly List<Flora> FloraList = new List<Flora>();

        public Flora(string floraNaam, DateTime floraWaterMoment, string floraJaargetijdeWater, int floraWaterAantal, 
            DateTime floraSnoeiMoment, string floraJaargetijdeSnoeien, int floraSnoeienAantal, string floraOpmerkingen, string floraSoort,
            string KlantNaam, string Adres) 
            : base(KlantNaam, Adres)
        {
            FloraNaam = floraNaam;
            FloraWaterMoment = floraWaterMoment;
            FloraJaargetijdeWater = floraJaargetijdeWater;
            FloraWaterAantal = floraWaterAantal;
            FloraSnoeiMoment = floraSnoeiMoment;
            FloraJaargetijdeSnoeien = floraJaargetijdeSnoeien;
            FloraSnoeienAantal = floraSnoeienAantal;
            FloraOpmerkingen = floraOpmerkingen;
            FloraSoort = floraSoort;
        }

        public Flora CreateNewFlora(string FloraNaam, string FloraWaterMoment, string FloraJaargetijdeWater, string FloraWaterAantal,
                string FloraSnoeiMoment, string FloraJaargetijdeSnoeien, string FloraSnoeienAantal, string FloraOpmerkingen, string FloraSoort)
        {
            Flora f = new Flora(FloraNaam, Convert.ToDateTime(FloraWaterMoment), FloraJaargetijdeWater, Convert.ToInt32(FloraWaterAantal),
                Convert.ToDateTime(FloraSnoeiMoment), FloraJaargetijdeSnoeien, Convert.ToInt32(FloraSnoeienAantal), FloraOpmerkingen, FloraSoort, "Lisa", "afewiae");
            Flora F1 = f.CreateNewFlora(FloraNaam, FloraWaterMoment, FloraJaargetijdeWater, FloraWaterAantal,
                FloraSnoeiMoment, FloraJaargetijdeSnoeien, FloraSnoeienAantal, FloraOpmerkingen, FloraSoort);

            return f;
        }
    }
}
