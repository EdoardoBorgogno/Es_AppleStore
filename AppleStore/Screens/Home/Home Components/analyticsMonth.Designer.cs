namespace AppleStore.Components.Home.Home_Components
{
    partial class analyticsMonth
    {
        /// <summary> 
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione componenti

        /// <summary> 
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare 
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.chartImage = new System.Windows.Forms.PictureBox();
            this.lblPercentage = new System.Windows.Forms.Label();
            this.lblPanelDescription = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chartImage)).BeginInit();
            this.SuspendLayout();
            // 
            // chartImage
            // 
            this.chartImage.Location = new System.Drawing.Point(15, 8);
            this.chartImage.Name = "chartImage";
            this.chartImage.Size = new System.Drawing.Size(84, 78);
            this.chartImage.TabIndex = 0;
            this.chartImage.TabStop = false;
            // 
            // lblPercentage
            // 
            this.lblPercentage.AutoSize = true;
            this.lblPercentage.Font = new System.Drawing.Font("Dubai", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPercentage.Location = new System.Drawing.Point(10, 89);
            this.lblPercentage.Name = "lblPercentage";
            this.lblPercentage.Size = new System.Drawing.Size(63, 29);
            this.lblPercentage.TabIndex = 1;
            this.lblPercentage.Text = "lblPerc";
            this.lblPercentage.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblPanelDescription
            // 
            this.lblPanelDescription.AutoSize = true;
            this.lblPanelDescription.Font = new System.Drawing.Font("Dubai", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPanelDescription.ForeColor = System.Drawing.Color.Gray;
            this.lblPanelDescription.Location = new System.Drawing.Point(115, 33);
            this.lblPanelDescription.Name = "lblPanelDescription";
            this.lblPanelDescription.Size = new System.Drawing.Size(140, 29);
            this.lblPanelDescription.TabIndex = 2;
            this.lblPanelDescription.Text = "Andamento MESE";
            // 
            // analyticsMonth
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lblPanelDescription);
            this.Controls.Add(this.lblPercentage);
            this.Controls.Add(this.chartImage);
            this.Name = "analyticsMonth";
            this.Size = new System.Drawing.Size(290, 132);
            this.Load += new System.EventHandler(this.analyticsMonth_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox chartImage;
        private System.Windows.Forms.Label lblPercentage;
        private System.Windows.Forms.Label lblPanelDescription;
    }
}
