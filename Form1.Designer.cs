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
            this.components = new System.ComponentModel.Container();
            this.KopButton = new System.Windows.Forms.Button();
            this.KasaLabel = new System.Windows.Forms.Label();
            this.GowniakiLabel = new System.Windows.Forms.Label();
            this.DokupGowniakiButton = new System.Windows.Forms.Button();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // KopButton
            // 
            this.KopButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.KopButton.Location = new System.Drawing.Point(565, 319);
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
            // GowniakiLabel
            // 
            this.GowniakiLabel.AutoSize = true;
            this.GowniakiLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.GowniakiLabel.Location = new System.Drawing.Point(12, 9);
            this.GowniakiLabel.Name = "GowniakiLabel";
            this.GowniakiLabel.Size = new System.Drawing.Size(156, 31);
            this.GowniakiLabel.TabIndex = 2;
            this.GowniakiLabel.Text = "Gówniaki: 0";
            // 
            // DokupGowniakiButton
            // 
            this.DokupGowniakiButton.Location = new System.Drawing.Point(18, 44);
            this.DokupGowniakiButton.Name = "DokupGowniakiButton";
            this.DokupGowniakiButton.Size = new System.Drawing.Size(150, 27);
            this.DokupGowniakiButton.TabIndex = 3;
            this.DokupGowniakiButton.Text = "Dokup";
            this.DokupGowniakiButton.UseVisualStyleBackColor = true;
            this.DokupGowniakiButton.Click += new System.EventHandler(this.DokupGowniakiButton_Click);
            // 
            // Timer
            // 
            this.Timer.Enabled = true;
            this.Timer.Interval = 1000;
            this.Timer.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DokupGowniakiButton);
            this.Controls.Add(this.GowniakiLabel);
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
        private System.Windows.Forms.Label GowniakiLabel;
        private System.Windows.Forms.Button DokupGowniakiButton;
        private System.Windows.Forms.Timer Timer;
    }
}

