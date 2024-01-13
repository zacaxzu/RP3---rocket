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
            this.brzinaPrepreka = new System.Windows.Forms.NumericUpDown();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.izgledKometa = new System.Windows.Forms.TextBox();
            this.izgledBroda = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.brzinaPrepreka)).BeginInit();
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
            this.gumbNazad.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button1_MouseClick);
            // 
            // brzinaPrepreka
            // 
            this.brzinaPrepreka.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.brzinaPrepreka.Location = new System.Drawing.Point(189, 131);
            this.brzinaPrepreka.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.brzinaPrepreka.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.brzinaPrepreka.Name = "brzinaPrepreka";
            this.brzinaPrepreka.Size = new System.Drawing.Size(38, 31);
            this.brzinaPrepreka.TabIndex = 1;
            this.brzinaPrepreka.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.brzinaPrepreka.ValueChanged += new System.EventHandler(this.brzinaPrepreka_ValueChanged);
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.richTextBox1.Location = new System.Drawing.Point(128, 79);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(159, 33);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "Brzina prepreka";
            // 
            // izgledKometa
            // 
            this.izgledKometa.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.izgledKometa.Location = new System.Drawing.Point(146, 188);
            this.izgledKometa.Name = "izgledKometa";
            this.izgledKometa.Size = new System.Drawing.Size(128, 29);
            this.izgledKometa.TabIndex = 3;
            this.izgledKometa.Text = "Izgled Kometa";
            // 
            // izgledBroda
            // 
            this.izgledBroda.Location = new System.Drawing.Point(162, 284);
            this.izgledBroda.Name = "izgledBroda";
            this.izgledBroda.Size = new System.Drawing.Size(100, 20);
            this.izgledBroda.TabIndex = 4;
            // 
            // Postavke
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Raketa1.Properties.Resources.pozadina;
            this.ClientSize = new System.Drawing.Size(399, 449);
            this.Controls.Add(this.izgledBroda);
            this.Controls.Add(this.izgledKometa);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.brzinaPrepreka);
            this.Controls.Add(this.gumbNazad);
            this.Name = "Postavke";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Postavke";
            ((System.ComponentModel.ISupportInitialize)(this.brzinaPrepreka)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button gumbNazad;
        private System.Windows.Forms.NumericUpDown brzinaPrepreka;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TextBox izgledKometa;
        private System.Windows.Forms.TextBox izgledBroda;
    }
}