using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HoveniersAdministratieNew_DomeinClasses;

namespace Hoveniersadministratie
{
    public partial class FloraToevoegenDesign : Form
    {
        public FloraToevoegenDesign()
        {
            InitializeComponent();

            string FloraNaam = TBoxNaam.Text;
            string FloraWaterMoment = NumUDWater.Text;
            string FloraJaargetijdeWater = TBoxJaargetijdeWater.Text;
            string FloraWaterAantal = CBoxWaterAantal.Text;
            string FloraSnoeiMoment = NumUDSnoeien.Text;
            string FloraJaargetijdeSnoeien = TBoxJaargetijdeSnoeien.Text;
            string FloraSnoeienAantal = CBoxSnoeienAantal.Text;
            string FloraOpmerkingen = TBoxOpmerkingen.Text;
            string FloraSoort = CBoxSoortFlora.Text;

            //Flora f = new Flora(FloraNaam, Convert.ToDateTime(FloraWaterMoment), FloraJaargetijdeWater, Convert.ToInt32(FloraWaterAantal),
            //    Convert.ToDateTime(FloraSnoeiMoment), FloraJaargetijdeSnoeien, Convert.ToInt32(FloraSnoeienAantal), FloraOpmerkingen, FloraSoort, "Lisa", "afewiae");
            //Flora Sub1 = f.CreateNewFlora(FloraNaam, FloraWaterMoment, FloraJaargetijdeWater, FloraWaterAantal,
            //    FloraSnoeiMoment, FloraJaargetijdeSnoeien, FloraSnoeienAantal, FloraOpmerkingen, FloraSoort);
        }

        // Maakt alle textboxen leeg. Geeft deze de waarde ""
        public static string SetValueForTBoxNaam1 = "";
        public static string SetValueForTBoxWater1 = "";
        public static string SetValueForTBoxSnoeien1 = "";
        public static string SetValueForTBoxJaargetijde1 = "";
        public static string SetValueForTBoxOpmerkingen1 = "";
        public static string SetValueForCBoxSoortFlora1 = "";
        public static string SetValueForCBoxWaterAantal1 = "";
        public static string SetValueForCBoxSnoeienAantal1 = "";

        private void BtnFloraToevoegen_Click(object sender, EventArgs e)
        {

            // Zorgt ervoor dat je alleen de plant kan opslaan als alles is ingevuld behalve het opmerkingen vakje (deze mag leeg blijven)
            if (TBoxNaam.Text != "" && NumUDWater.Text != "0" && NumUDSnoeien.Text != "0" && TBoxJaargetijdeSnoeien.Text != ""
                && CBoxSoortFlora.Text != "" && CBoxWaterAantal.Text != "" && CBoxSnoeienAantal.Text != "" && TBoxJaargetijdeWater.Text != "")
            {
                string SetValueForTBoxNaam1 = TBoxNaam.Text;
                string SetValueForTBoxWater1 = NumUDWater.Text;
                string SetValueForTBoxSnoeien1 = NumUDSnoeien.Text;
                string SetValueForTBoxJaargetijde1 = TBoxJaargetijdeSnoeien.Text;
                string SetValueForTBoxOpmerkingen1 = TBoxOpmerkingen.Text;
                string SetValueForCBoxSoortFlora1 = CBoxSoortFlora.Text;
                string SetValueForCBoxWaterAantal1 = CBoxWaterAantal.Text;
                string SetValueForCBoxSnoeienAantal1 = CBoxSnoeienAantal.Text;

                FloraDesign flora = new FloraDesign();
                flora.Show();
                this.Close();
            }
            else
            {
                // Geeft een melding als een of meerdere van bovenstaande statements niet klopt/kloppen.
                MessageBox.Show("Alle velden invullen!");
            }
        }
    }
}
