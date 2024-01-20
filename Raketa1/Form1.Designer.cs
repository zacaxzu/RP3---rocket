namespace Raketa1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.prepreka1 = new System.Windows.Forms.PictureBox();
            this.prepreka2 = new System.Windows.Forms.PictureBox();
            this.labelaRestartPoruka = new System.Windows.Forms.Label();
            this.labelaPauza = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.labelaTezina = new System.Windows.Forms.Label();
            this.labelaBodovi2 = new System.Windows.Forms.Label();
            this.labelZivoti = new System.Windows.Forms.Label();
            this.brod = new System.Windows.Forms.PictureBox();
            this.trakaZaStanje = new System.Windows.Forms.PictureBox();
            this.srce1 = new System.Windows.Forms.PictureBox();
            this.srce2 = new System.Windows.Forms.PictureBox();
            this.srce3 = new System.Windows.Forms.PictureBox();
            this.preprekaJacina1 = new System.Windows.Forms.ProgressBar();
            this.preprekaJacina2 = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.prepreka1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prepreka2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.brod)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trakaZaStanje)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.srce1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.srce2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.srce3)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // prepreka1
            // 
            this.prepreka1.Image = global::Raketa1.Properties.Resources.prepreka;
            this.prepreka1.Location = new System.Drawing.Point(9, 212);
            this.prepreka1.Margin = new System.Windows.Forms.Padding(2);
            this.prepreka1.Name = "prepreka1";
            this.prepreka1.Size = new System.Drawing.Size(187, 41);
            this.prepreka1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.prepreka1.TabIndex = 2;
            this.prepreka1.TabStop = false;
            // 
            // prepreka2
            // 
            this.prepreka2.Image = global::Raketa1.Properties.Resources.prepreka;
            this.prepreka2.Location = new System.Drawing.Point(203, 10);
            this.prepreka2.Margin = new System.Windows.Forms.Padding(2);
            this.prepreka2.Name = "prepreka2";
            this.prepreka2.Size = new System.Drawing.Size(187, 41);
            this.prepreka2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.prepreka2.TabIndex = 3;
            this.prepreka2.TabStop = false;
            // 
            // labelaRestartPoruka
            // 
            this.labelaRestartPoruka.AutoSize = true;
            this.labelaRestartPoruka.BackColor = System.Drawing.Color.Yellow;
            this.labelaRestartPoruka.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelaRestartPoruka.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelaRestartPoruka.Location = new System.Drawing.Point(104, 191);
            this.labelaRestartPoruka.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelaRestartPoruka.Name = "labelaRestartPoruka";
            this.labelaRestartPoruka.Size = new System.Drawing.Size(189, 62);
            this.labelaRestartPoruka.TabIndex = 5;
            this.labelaRestartPoruka.Text = "Pritisnite R za \r\nponovnu igru.";
            // 
            // labelaPauza
            // 
            this.labelaPauza.AutoSize = true;
            this.labelaPauza.BackColor = System.Drawing.Color.Red;
            this.labelaPauza.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelaPauza.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelaPauza.Location = new System.Drawing.Point(89, 147);
            this.labelaPauza.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelaPauza.Name = "labelaPauza";
            this.labelaPauza.Size = new System.Drawing.Size(223, 31);
            this.labelaPauza.TabIndex = 6;
            this.labelaPauza.Text = "Igra je pauzirana!";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(15, 7);
            this.progressBar1.Maximum = 1000;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(100, 23);
            this.progressBar1.TabIndex = 7;
            // 
            // labelaTezina
            // 
            this.labelaTezina.AutoSize = true;
            this.labelaTezina.BackColor = System.Drawing.Color.Transparent;
            this.labelaTezina.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelaTezina.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelaTezina.Location = new System.Drawing.Point(261, 409);
            this.labelaTezina.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelaTezina.Name = "labelaTezina";
            this.labelaTezina.Size = new System.Drawing.Size(0, 31);
            this.labelaTezina.TabIndex = 8;
            // 
            // labelaBodovi2
            // 
            this.labelaBodovi2.AutoSize = true;
            this.labelaBodovi2.BackColor = System.Drawing.Color.Black;
            this.labelaBodovi2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelaBodovi2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelaBodovi2.Location = new System.Drawing.Point(235, 409);
            this.labelaBodovi2.Name = "labelaBodovi2";
            this.labelaBodovi2.Size = new System.Drawing.Size(127, 31);
            this.labelaBodovi2.TabIndex = 9;
            this.labelaBodovi2.Text = "Bodovi: 0";
            // 
            // labelZivoti
            // 
            this.labelZivoti.AutoSize = true;
            this.labelZivoti.BackColor = System.Drawing.Color.Black;
            this.labelZivoti.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelZivoti.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelZivoti.Location = new System.Drawing.Point(12, 409);
            this.labelZivoti.Name = "labelZivoti";
            this.labelZivoti.Size = new System.Drawing.Size(110, 31);
            this.labelZivoti.TabIndex = 10;
            this.labelZivoti.Text = "Životi: 3";
            // 
            // brod
            // 
            this.brod.BackColor = System.Drawing.Color.Transparent;
            this.brod.Location = new System.Drawing.Point(145, 342);
            this.brod.Margin = new System.Windows.Forms.Padding(2);
            this.brod.Name = "brod";
            this.brod.Size = new System.Drawing.Size(107, 51);
            this.brod.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.brod.TabIndex = 0;
            this.brod.TabStop = false;
            // 
            // trakaZaStanje
            // 
            this.trakaZaStanje.BackColor = System.Drawing.Color.Black;
            this.trakaZaStanje.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.trakaZaStanje.Location = new System.Drawing.Point(0, 398);
            this.trakaZaStanje.Name = "trakaZaStanje";
            this.trakaZaStanje.Size = new System.Drawing.Size(399, 51);
            this.trakaZaStanje.TabIndex = 11;
            this.trakaZaStanje.TabStop = false;
            // 
            // srce1
            // 
            this.srce1.BackColor = System.Drawing.Color.Black;
            this.srce1.Image = global::Raketa1.Properties.Resources.srce_1;
            this.srce1.Location = new System.Drawing.Point(9, 401);
            this.srce1.Name = "srce1";
            this.srce1.Size = new System.Drawing.Size(43, 39);
            this.srce1.TabIndex = 12;
            this.srce1.TabStop = false;
            // 
            // srce2
            // 
            this.srce2.BackColor = System.Drawing.Color.Black;
            this.srce2.Image = global::Raketa1.Properties.Resources.srce_1;
            this.srce2.Location = new System.Drawing.Point(58, 401);
            this.srce2.Name = "srce2";
            this.srce2.Size = new System.Drawing.Size(43, 39);
            this.srce2.TabIndex = 13;
            this.srce2.TabStop = false;
            // 
            // srce3
            // 
            this.srce3.BackColor = System.Drawing.Color.Black;
            this.srce3.Image = global::Raketa1.Properties.Resources.srce_1;
            this.srce3.Location = new System.Drawing.Point(110, 401);
            this.srce3.Name = "srce3";
            this.srce3.Size = new System.Drawing.Size(43, 39);
            this.srce3.TabIndex = 14;
            this.srce3.TabStop = false;
            // 
            // preprekaJacina1
            // 
            this.preprekaJacina1.Location = new System.Drawing.Point(18, 221);
            this.preprekaJacina1.Name = "preprekaJacina1";
            this.preprekaJacina1.Size = new System.Drawing.Size(168, 23);
            this.preprekaJacina1.TabIndex = 15;
            // 
            // preprekaJacina2
            // 
            this.preprekaJacina2.Location = new System.Drawing.Point(214, 12);
            this.preprekaJacina2.Name = "preprekaJacina2";
            this.preprekaJacina2.Size = new System.Drawing.Size(164, 25);
            this.preprekaJacina2.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Navy;
            this.ClientSize = new System.Drawing.Size(399, 449);
            this.Controls.Add(this.preprekaJacina2);
            this.Controls.Add(this.preprekaJacina1);
            this.Controls.Add(this.srce3);
            this.Controls.Add(this.srce2);
            this.Controls.Add(this.srce1);
            this.Controls.Add(this.labelaBodovi2);
            this.Controls.Add(this.labelaTezina);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.labelaPauza);
            this.Controls.Add(this.labelaRestartPoruka);
            this.Controls.Add(this.brod);
            this.Controls.Add(this.trakaZaStanje);
            this.Controls.Add(this.labelZivoti);
            this.Controls.Add(this.prepreka1);
            this.Controls.Add(this.prepreka2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Raketa";
            this.Activated += new System.EventHandler(this.Form1_Activated);
            this.Deactivate += new System.EventHandler(this.Form1_Deactivate);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.prepreka1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prepreka2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.brod)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trakaZaStanje)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.srce1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.srce2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.srce3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox prepreka1;
        private System.Windows.Forms.PictureBox prepreka2;
        private System.Windows.Forms.Label labelaRestartPoruka;
        private System.Windows.Forms.Label labelaPauza;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label labelaTezina;
        private System.Windows.Forms.Label labelaBodovi2;
        private System.Windows.Forms.Label labelZivoti;
        private System.Windows.Forms.PictureBox brod;
        private System.Windows.Forms.PictureBox trakaZaStanje;
        private System.Windows.Forms.PictureBox srce1;
        private System.Windows.Forms.PictureBox srce2;
        private System.Windows.Forms.PictureBox srce3;
        private System.Windows.Forms.ProgressBar preprekaJacina1;
        private System.Windows.Forms.ProgressBar preprekaJacina2;
        //private System.Windows.Forms.ProgressBar progressBar1;
    }
}

