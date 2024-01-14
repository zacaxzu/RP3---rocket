namespace Raketa1
{
    partial class Postavke
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
            this.gumbNazad = new System.Windows.Forms.Button();
            this.brzinaPreprekeTezina = new System.Windows.Forms.NumericUpDown();
            this.brzinaPreprekeText = new System.Windows.Forms.RichTextBox();
            this.izgledKometa = new System.Windows.Forms.TextBox();
            this.Brod1 = new System.Windows.Forms.PictureBox();
            this.Brod2 = new System.Windows.Forms.PictureBox();
            this.Brod3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.brzinaPreprekeTezina)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Brod1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Brod2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Brod3)).BeginInit();
            this.SuspendLayout();
            // 
            // gumbNazad
            // 
            this.gumbNazad.BackColor = System.Drawing.Color.OrangeRed;
            this.gumbNazad.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gumbNazad.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gumbNazad.Location = new System.Drawing.Point(280, 23);
            this.gumbNazad.Name = "gumbNazad";
            this.gumbNazad.Size = new System.Drawing.Size(107, 39);
            this.gumbNazad.TabIndex = 0;
            this.gumbNazad.Text = "Nazad";
            this.gumbNazad.UseVisualStyleBackColor = false;
            this.gumbNazad.MouseClick += new System.Windows.Forms.MouseEventHandler(this.gumbNazad_MouseClick);
            // 
            // brzinaPreprekeTezina
            // 
            this.brzinaPreprekeTezina.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.brzinaPreprekeTezina.Location = new System.Drawing.Point(189, 131);
            this.brzinaPreprekeTezina.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.brzinaPreprekeTezina.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.brzinaPreprekeTezina.Name = "brzinaPreprekeTezina";
            this.brzinaPreprekeTezina.Size = new System.Drawing.Size(38, 31);
            this.brzinaPreprekeTezina.TabIndex = 1;
            this.brzinaPreprekeTezina.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.brzinaPreprekeTezina.ValueChanged += new System.EventHandler(this.brzinaPrepreka_ValueChanged);
            // 
            // brzinaPreprekeText
            // 
            this.brzinaPreprekeText.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.brzinaPreprekeText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.brzinaPreprekeText.Location = new System.Drawing.Point(128, 79);
            this.brzinaPreprekeText.Name = "brzinaPreprekeText";
            this.brzinaPreprekeText.Size = new System.Drawing.Size(159, 33);
            this.brzinaPreprekeText.TabIndex = 2;
            this.brzinaPreprekeText.Text = "Brzina prepreka";
            // 
            // izgledKometa
            // 
            this.izgledKometa.BackColor = System.Drawing.Color.Turquoise;
            this.izgledKometa.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.izgledKometa.Location = new System.Drawing.Point(138, 203);
            this.izgledKometa.Name = "izgledKometa";
            this.izgledKometa.Size = new System.Drawing.Size(120, 29);
            this.izgledKometa.TabIndex = 3;
            this.izgledKometa.Text = "Izgled Broda";
            // 
            // Brod1
            // 
            this.Brod1.BackColor = System.Drawing.Color.Transparent;
            this.Brod1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Brod1.Image = global::Raketa1.Properties.Resources.ufo1_11;
            this.Brod1.Location = new System.Drawing.Point(26, 264);
            this.Brod1.Name = "Brod1";
            this.Brod1.Size = new System.Drawing.Size(151, 65);
            this.Brod1.TabIndex = 4;
            this.Brod1.TabStop = false;
            this.Brod1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Brod1_MouseClick);
            // 
            // Brod2
            // 
            this.Brod2.BackColor = System.Drawing.Color.Transparent;
            this.Brod2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Brod2.Image = global::Raketa1.Properties.Resources.ufo2_22;
            this.Brod2.Location = new System.Drawing.Point(215, 264);
            this.Brod2.Name = "Brod2";
            this.Brod2.Size = new System.Drawing.Size(143, 65);
            this.Brod2.TabIndex = 5;
            this.Brod2.TabStop = false;
            this.Brod2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Brod2_MouseClick);
            // 
            // Brod3
            // 
            this.Brod3.BackColor = System.Drawing.Color.Transparent;
            this.Brod3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Brod3.Image = global::Raketa1.Properties.Resources.ufo3_3;
            this.Brod3.Location = new System.Drawing.Point(128, 354);
            this.Brod3.Name = "Brod3";
            this.Brod3.Size = new System.Drawing.Size(152, 58);
            this.Brod3.TabIndex = 6;
            this.Brod3.TabStop = false;
            this.Brod3.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Brod3_MouseClick);
            // 
            // Postavke
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Raketa1.Properties.Resources.pozadina;
            this.ClientSize = new System.Drawing.Size(399, 449);
            this.Controls.Add(this.Brod3);
            this.Controls.Add(this.Brod2);
            this.Controls.Add(this.Brod1);
            this.Controls.Add(this.izgledKometa);
            this.Controls.Add(this.brzinaPreprekeText);
            this.Controls.Add(this.brzinaPreprekeTezina);
            this.Controls.Add(this.gumbNazad);
            this.Name = "Postavke";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Postavke";
            ((System.ComponentModel.ISupportInitialize)(this.brzinaPreprekeTezina)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Brod1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Brod2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Brod3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button gumbNazad;
        private System.Windows.Forms.NumericUpDown brzinaPreprekeTezina;
        private System.Windows.Forms.RichTextBox brzinaPreprekeText;
        private System.Windows.Forms.TextBox izgledKometa;
        private System.Windows.Forms.PictureBox Brod1;
        private System.Windows.Forms.PictureBox Brod2;
        private System.Windows.Forms.PictureBox Brod3;
    }
}