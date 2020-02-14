namespace TEBMiner
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.KopButton = new System.Windows.Forms.Button();
            this.KasaLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // KopButton
            // 
            this.KopButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.KopButton.Location = new System.Drawing.Point(299, 154);
            this.KopButton.Name = "KopButton";
            this.KopButton.Size = new System.Drawing.Size(223, 119);
            this.KopButton.TabIndex = 0;
            this.KopButton.Text = "Kop";
            this.KopButton.UseVisualStyleBackColor = true;
            this.KopButton.Click += new System.EventHandler(this.Kop);
            // 
            // KasaLabel
            // 
            this.KasaLabel.AutoSize = true;
            this.KasaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.KasaLabel.Location = new System.Drawing.Point(630, 13);
            this.KasaLabel.Name = "KasaLabel";
            this.KasaLabel.Size = new System.Drawing.Size(106, 31);
            this.KasaLabel.TabIndex = 1;
            this.KasaLabel.Text = "Kasa: 0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.KasaLabel);
            this.Controls.Add(this.KopButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button KopButton;
        private System.Windows.Forms.Label KasaLabel;
    }
}

