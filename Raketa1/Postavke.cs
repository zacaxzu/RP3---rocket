using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Raketa1
{
    public partial class Postavke : Form
    {
        public Postavke()
        {
            InitializeComponent();
        }

        public static int SelectedBrodDesign = 1;

        public static int BrzinaPrepreka = 1;

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            StartForm formaZaStart = new StartForm();
            Visible = false;
            formaZaStart.ShowDialog();
            Visible = true;
            Close();
        }

        private void brzinaPrepreka_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown numericUpDown = (NumericUpDown)sender;
            BrzinaPrepreka = (int)numericUpDown.Value;
        }


        public void Brod1_MouseClick(object sender, MouseEventArgs e)
        {
            SelectedBrodDesign = 1;
            Debug.WriteLine("Brod 1 kliknut!");
        }

        public void Brod2_MouseClick(object sender, MouseEventArgs e)
        {
            SelectedBrodDesign = 2;
            Debug.WriteLine("Brod 2 kliknut!");
        }

        public void Brod3_MouseClick(object sender, MouseEventArgs e)
        {
            SelectedBrodDesign = 3;
            Debug.WriteLine("Brod 3 kliknut!");
        }

        private void gumbNazad_MouseClick(object sender, MouseEventArgs e)
        {
            BrzinaPrepreka = (int)brzinaPreprekeTezina.Value;
            SelectedBrodDesign = SelectedBrodDesign;

            StartForm formaZaStart = new StartForm();
            Visible = false;
            formaZaStart.ShowDialog();
            Visible = true;
            Close();
        }
    }
}
