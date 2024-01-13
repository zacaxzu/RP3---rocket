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
    public partial class StartForm : Form
    {
        public StartForm()
        {
            //Location = new Point(Screen.PrimaryScreen.WorkingArea.Size.Width - Width, 0);
            InitializeComponent();
        }

        private void gumbPokreni_Click(object sender, EventArgs e)
        {
            Form1 formaZaIgru = new Form1();
            Visible = false;
            formaZaIgru.ShowDialog();
            Visible = true;
            Close();
        }

        private void gumbPostavke_Click(object sender, EventArgs e)
        {
            Postavke formaZaPostavke = new Postavke();
            Visible = false;
            formaZaPostavke.ShowDialog();
            Visible = true;
            Close();
        }

        private void gumbZatvori_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void StartForm_Load(object sender, EventArgs e)
        {

        }
        /*
Image pozadina = Properties.Resources.pozadina;
private void StartForm_Paint(object sender, EventArgs e)
{
//e.Graphics.DrawImage(pozadina, 0, 0); 
}
*/
    }
}
