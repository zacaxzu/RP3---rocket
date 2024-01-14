using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Raketa1
{
    public partial class Form1 : Form
    {
        float sirina, visina;
        bool lijeviRub;
        bool desniRub;
        public Form1()
        {
            InitializeComponent();
            sirina = ClientSize.Width;
            visina = ClientSize.Height;
            PocetnePostavke();
            timer1.Start();
            DoubleBuffered = true;

            labelaBodovi.Parent = prepreka1;
            labelaBodovi1.Parent = prepreka2;
            labelaBodovi.Location = labelaBodovi1.Location = new Point(4, 4);
        }
        private void povecajBodove(int dobiveniBodovi)
        {
            bodovi += dobiveniBodovi;
            labelaBodovi.Text = labelaBodovi1.Text = "Bodovi: " + bodovi;
        }

        bool krajIgre;
        private void PocetnePostavke()
        {
            progressBar1.Value = 1000;

            labelaPauza.Visible = false;
            krajIgre = false;
            labelaRestartPoruka.Visible = false;
            prepreka1.Location = new Point(10, 205);
            prepreka2.Location = new Point(205, 10);

            bodovi = 0;
            povecajBodove(0);
            lijevo = desno = false;
            kretanje = false;
            brzinaPozadine = 0.5f;
            brzinaZida = 4;
            brzinaBroda = 5;
            //public static PictureBox brod;

            koordPozadina = new float[] { -visina, 0 };
            koordZid = new float[] { -visina, 0 };
            /*
            brod.Location = new Point(
                (int)sirina / 2 - brod.Size.Width / 2,
                (int)visina - brod.Size.Height - 10);
            */

            lijeviRub = true;
            desniRub = false;
        }

        Image pozadina = Properties.Resources.pozadina;
        Image zid = Properties.Resources.zid;
        Image ufo1 = Properties.Resources.ufo1_11,
              ufo2 = Properties.Resources.ufo2_22,
              ufo3 = Properties.Resources.ufo3_3;
        float brzinaPozadine, brzinaZida, brzinaBroda;
        int brzinaPrepreke;
        float[] koordPozadina, koordZid;
        bool kretanje, lijevo, desno;
        int bodovi, selectedBrodDesign;
        
        public void TezinaPrepreke(int brzinaPrepreke)
        {
            // Do something with the brzinaPrepreke value
            // For example, update a label or any other UI element
            labelaTezina.Text = "Tezina: " + brzinaPrepreke;
        }

        public void DesignBroda(int selectedBrodDesign)
        {
            Debug.WriteLine($"Ispis: {selectedBrodDesign}");
            if(selectedBrodDesign == 1)
            {
                brod.Image = ufo1;
                Debug.WriteLine("Prvi ufo izabran!");
            }
            else if(selectedBrodDesign == 2)
            {
                brod.Image = ufo2;
                Debug.WriteLine("Drugi ufo izabran!");
            }
            else if(selectedBrodDesign == 3)
            {
                brod.Image = ufo3;
                Debug.WriteLine("Treći ufo izabran!");
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up && kretanje)
                kretanje = false;
            if (e.KeyCode == Keys.Left)
                lijevo = false;
            if (e.KeyCode == Keys.Right)
                desno = false;
            if (e.KeyCode == Keys.R && krajIgre)
            {
                PocetnePostavke();
                timer1.Start();
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Up && !kretanje)
                kretanje = true;
            if (e.KeyCode == Keys.Left)
                lijevo = true;
            if (e.KeyCode == Keys.Right)
                desno = true;
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            if (!krajIgre)
            {
                labelaPauza.Visible = false;
                timer1.Start();
            }
        }

        private void Form1_Deactivate(object sender, EventArgs e)
        {
            if (!krajIgre)
            {
                timer1.Stop();
                if (kretanje)
                    kretanje = false;
                labelaPauza.Visible = true;
            }
        }

        private void p(object sender, KeyPressEventArgs e)
        {
            if (!krajIgre)
            {
                if(labelaPauza.Visible == false)
                {
                    timer1.Stop();
                    if (kretanje)
                        kretanje = false;
                    labelaPauza.Visible = true;
                }
                else
                {
                    timer1.Start();
                    labelaPauza.Visible = false;
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            labelaTezina.Text = "Tezina: " + Postavke.BrzinaPrepreka;
            brzinaPrepreke = Postavke.BrzinaPrepreka;
            selectedBrodDesign = Postavke.SelectedBrodDesign;

            if (selectedBrodDesign == 1)
            {
                brod.Image = ufo1;
                Debug.WriteLine("Prvi ufo izabran!");
            }
            else if (selectedBrodDesign == 2)
            {
                brod.Image = ufo2;
                Debug.WriteLine("Drugi ufo izabran!");
            }
            else if (selectedBrodDesign == 3)
            {
                brod.Image = ufo3;
                Debug.WriteLine("Treći ufo izabran!");
            }
        }

        private void PomakniPozadinu()
        {
            for (int i = 0; i < 2; i++)
            {
                if (koordPozadina[i] > visina)
                    koordPozadina[i] -= 2 * visina;
                if (koordZid[i] > visina)
                    koordZid[i] -= 2 * visina;
                if (kretanje == true)
                {
                    koordPozadina[i] += brzinaPozadine;
                    koordZid[i] += brzinaZida;
                }
            }
            Invalidate();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Debug.WriteLine($"Brod: {brod.Name}");

            PomakniPozadinu();
            if (lijevo && !desno &&
                brod.Left - brzinaBroda >= 0.1 * sirina)
                brod.Left -= (int)brzinaBroda;
            if (desno && !lijevo &&
                brod.Right + brzinaBroda <= 0.9 * sirina)
                brod.Left += (int)brzinaBroda;
            if (kretanje)
            {
                prepreka1.Top += (int)brzinaZida;
                prepreka2.Top += (int)brzinaZida;
                if (prepreka1.Top > visina)
                {
                    povecajBodove(1);
                    prepreka1.Top = -prepreka1.Height;
                }
                if (prepreka2.Top > visina)
                {
                    povecajBodove(1);
                    prepreka2.Top = -prepreka2.Height;
                }
            }
            progressBar1.Value -= 1;
            if (random.Next() % 100 == 0)
                StvoriKomet();

            // Micanje prepreka
            if(lijeviRub)
            {
                prepreka1.Left -= (int)brzinaPrepreke;
                prepreka2.Left += (int)brzinaPrepreke;
                if(prepreka1.Left < 0 - prepreka1.Width * 0.5)
                {
                    lijeviRub = false;
                    desniRub = true;
                }
            }
            if(desniRub)
            {
                prepreka1.Left += (int)brzinaPrepreke;
                prepreka2.Left -= (int)brzinaPrepreke;
                if (prepreka1.Left > sirina - prepreka1.Width * 0.5)
                {
                    lijeviRub = true;
                    desniRub = false;
                }
            }

            foreach (Control kontrola in Controls)
            {
                if(kontrola is PictureBox x && (string)x.Tag == "komet")
                {
                    x.Top += (int)(kretanje ? (brzinaZida + brzinaBroda) : brzinaZida);
                    if(x.Top > visina)
                    {
                        Controls.Remove(kontrola);
                        x.Dispose();
                    }
                }
            }

            Invalidate();
            if (brod.Bounds.IntersectsWith(prepreka1.Bounds)
                || brod.Bounds.IntersectsWith(prepreka2.Bounds)
                || progressBar1.Value == 0)
                GameOver();
            
            if(prepreka1.Top > visina)
            {   
                progressBar1.Value = Math.Min(progressBar1.Value + 60, 1000);
            }
            if (prepreka2.Top > visina)
            {
                progressBar1.Value = Math.Min(progressBar1.Value + 60, 1000);
            }
            foreach(Control kontrola in Controls)
            {
                if(kontrola is PictureBox x && (string)x.Tag == "komet")
                {
                    if (brod.Bounds.IntersectsWith(x.Bounds))
                        GameOver();
                }
            }
        }

        private void GameOver()
        {
            timer1.Stop();
            krajIgre = true;
            labelaRestartPoruka.Visible = true;
            MessageBox.Show("Osvojeni bodovi: "
                + bodovi, "Igra je završila!");

            for(int i = Controls.Count - 1; i >= 0; i--)
            {
                if (Controls[i] is PictureBox x && (string)x.Tag == "komet")
                {
                    x.Visible = false;
                    Controls.Remove(Controls[i]);
                    x.Dispose();
                }
            }
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            for (int i = 0; i < 2; ++i)
            {
                // pozadina
                e.Graphics.DrawImage(pozadina, 0, koordPozadina[i], sirina, visina);
            }
            for (int i = 0; i < 2; ++i)
            {
                // zidovi
                e.Graphics.DrawImage(zid, 0, koordZid[i], 0.1f * sirina, visina);
                e.Graphics.DrawImage(zid, 0.9f * sirina, koordZid[i],
                    0.1f * sirina, visina);
            }
        }

        Random random = new Random();
        private void StvoriKomet()
        {
            PictureBox komet = new PictureBox();
            komet.Size = new Size(20, 20);
            komet.ImageLocation = @"Resources\comet.png";
            komet.Top = -komet.Height;
            komet.Left = (int)(0.1 * sirina + 1) + random.Next(0, (int)(0.8 * sirina - komet.Width));
            komet.Tag = "komet";
            Controls.Add(komet);
            komet.BringToFront();
        }
    }
}
