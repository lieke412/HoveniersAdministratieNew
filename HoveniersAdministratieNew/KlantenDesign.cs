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
    public partial class KlantenDesign : Form
    {
        public KlantenDesign()
        {
            InitializeComponent();
            //SqlConnect1();
            //listBox1.Items.Clear();
            //listBox1.Items.Add(Test1);
        }
        private void BtnFlora_Click(object sender, EventArgs e)
        {
            FloraDesign flora = new FloraDesign();
            flora.Show();
            this.Hide();
        }

        
    }
}
