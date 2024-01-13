using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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

        private void gumbNazad_MouseClick(object sender, MouseEventArgs e)
        {
            BrzinaPrepreka = (int)brzinaPreprekeTezina.Value;

            StartForm formaZaStart = new StartForm();
            Visible = false;
            formaZaStart.ShowDialog();
            Visible = true;
            Close();
        }
    }
}
