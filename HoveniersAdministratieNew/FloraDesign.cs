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
    public partial class FloraDesign : Form
    {
        public FloraDesign()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            FloraToevoegenDesign floraToevoegen = new FloraToevoegenDesign();
            floraToevoegen.Show();
            this.Close();
        }

        private void Flora_Load(object sender, EventArgs e)
        {
            // Geeft alle labels de waarde die bij FloraToevoegen is ingevuld in de textboxen. 
            LblNaam1.Text = "";
            LblWater1.Text = "";
            LblSnoeien1.Text = "";
            LblJaargetijde1.Text = "";
            LblOpmerkingen1.Text = "";
            LblSoortFlora1.Text = "";
            LblWaterAantal1.Text = "";
            LblSnoeienAantal1.Text = "";

            // Maakt van alle labels de rand onzichtbaar op het moment dat er geen waarde is ingevuld.
            if (LblNaam1.Text == "")
            {
               LblNaam1.BorderStyle = BorderStyle.None;
            }
            if (LblWater1.Text == "")
            {
                LblWater1.BorderStyle = BorderStyle.None;
            }
            if (LblSnoeien1.Text == "")
            {
                LblSnoeien1.BorderStyle = BorderStyle.None;
            }
            if (LblJaargetijde1.Text == "")
            {
                LblJaargetijde1.BorderStyle = BorderStyle.None;
            }
            if (LblOpmerkingen1.Text == "")
            {
                LblOpmerkingen1.BorderStyle = BorderStyle.None;
            }
            if (LblSoortFlora1.Text == "")
            {
                LblSoortFlora1.BorderStyle = BorderStyle.None;
            }
            if (LblWaterAantal1.Text == "")
            {
                LblWaterAantal1.BorderStyle = BorderStyle.None;
            }
            if (LblSnoeienAantal1.Text == "")
            {
                LblSnoeienAantal1.BorderStyle = BorderStyle.None;
            }
        }

        private void BtnTerugNaarHoofdmenu_Click(object sender, EventArgs e)
        {
            KlantenDesign klanten = new KlantenDesign();
            klanten.Show();
            this.Hide();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}