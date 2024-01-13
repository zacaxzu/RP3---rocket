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
            this.brod = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.labelaBodovi = new System.Windows.Forms.Label();
            this.prepreka1 = new System.Windows.Forms.PictureBox();
            this.prepreka2 = new System.Windows.Forms.PictureBox();
            this.labelaBodovi1 = new System.Windows.Forms.Label();
            this.labelaRestartPoruka = new System.Windows.Forms.Label();
            this.labelaPauza = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.labelaTezina = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.brod)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prepreka1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prepreka2)).BeginInit();
            this.SuspendLayout();
            // 
            // brod
            // 
            this.brod.BackColor = System.Drawing.Color.Transparent;
            this.brod.Image = global::Raketa1.Properties.Resources.brod;
            this.brod.Location = new System.Drawing.Point(160, 331);
            this.brod.Margin = new System.Windows.Forms.Padding(2);
            this.brod.Name = "brod";
            this.brod.Size = new System.Drawing.Size(56, 109);
            this.brod.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.brod.TabIndex = 0;
            this.brod.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // labelaBodovi
            // 
            this.labelaBodovi.AutoSize = true;
            this.labelaBodovi.BackColor = System.Drawing.Color.Transparent;
            this.labelaBodovi.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelaBodovi.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelaBodovi.Location = new System.Drawing.Point(221, 20);
            this.labelaBodovi.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelaBodovi.Name = "labelaBodovi";
            this.labelaBodovi.Size = new System.Drawing.Size(127, 31);
            this.labelaBodovi.TabIndex = 1;
            this.labelaBodovi.Text = "Bodovi: 0";
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
            // labelaBodovi1
            // 
            this.labelaBodovi1.AutoSize = true;
            this.labelaBodovi1.BackColor = System.Drawing.Color.Transparent;
            this.labelaBodovi1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelaBodovi1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelaBodovi1.Location = new System.Drawing.Point(11, 222);
            this.labelaBodovi1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelaBodovi1.Name = "labelaBodovi1";
            this.labelaBodovi1.Size = new System.Drawing.Size(127, 31);
            this.labelaBodovi1.TabIndex = 4;
            this.labelaBodovi1.Text = "Bodovi: 0";
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
            this.labelaTezina.Size = new System.Drawing.Size(111, 31);
            this.labelaTezina.TabIndex = 8;
            this.labelaTezina.Text = "Tezina: \r\n";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Navy;
            this.ClientSize = new System.Drawing.Size(399, 449);
            this.Controls.Add(this.labelaTezina);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.labelaPauza);
            this.Controls.Add(this.labelaRestartPoruka);
            this.Controls.Add(this.labelaBodovi1);
            this.Controls.Add(this.labelaBodovi);
            this.Controls.Add(this.prepreka2);
            this.Controls.Add(this.prepreka1);
            this.Controls.Add(this.brod);
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
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.p);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.brod)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prepreka1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prepreka2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox brod;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label labelaBodovi;
        private System.Windows.Forms.PictureBox prepreka1;
        private System.Windows.Forms.PictureBox prepreka2;
        private System.Windows.Forms.Label labelaBodovi1;
        private System.Windows.Forms.Label labelaRestartPoruka;
        private System.Windows.Forms.Label labelaPauza;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label labelaTezina;
        //private System.Windows.Forms.ProgressBar progressBar1;
    }
}

