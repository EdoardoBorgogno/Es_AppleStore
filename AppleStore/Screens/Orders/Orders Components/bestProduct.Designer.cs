namespace AppleStore.Screens.Orders.Orders_Components
{
    partial class bestProduct
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
            this.ProductImage = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblNameProduct = new System.Windows.Forms.Label();
            this.lblOrdersNumber = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ProductImage)).BeginInit();
            this.SuspendLayout();
            // 
            // ProductImage
            // 
            this.ProductImage.Location = new System.Drawing.Point(97, 39);
            this.ProductImage.Name = "ProductImage";
            this.ProductImage.Size = new System.Drawing.Size(107, 92);
            this.ProductImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ProductImage.TabIndex = 0;
            this.ProductImage.TabStop = false;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Dubai", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(3, 7);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(166, 29);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "Prodotto più venduto";
            // 
            // lblNameProduct
            // 
            this.lblNameProduct.Font = new System.Drawing.Font("Dubai", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameProduct.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.lblNameProduct.Location = new System.Drawing.Point(0, 134);
            this.lblNameProduct.Name = "lblNameProduct";
            this.lblNameProduct.Size = new System.Drawing.Size(299, 29);
            this.lblNameProduct.TabIndex = 3;
            this.lblNameProduct.Text = "Prodotto più venduto";
            this.lblNameProduct.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblOrdersNumber
            // 
            this.lblOrdersNumber.Font = new System.Drawing.Font("Dubai", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrdersNumber.Location = new System.Drawing.Point(-3, 163);
            this.lblOrdersNumber.Name = "lblOrdersNumber";
            this.lblOrdersNumber.Size = new System.Drawing.Size(299, 29);
            this.lblOrdersNumber.TabIndex = 4;
            this.lblOrdersNumber.Text = "NN";
            this.lblOrdersNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bestProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lblOrdersNumber);
            this.Controls.Add(this.lblNameProduct);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.ProductImage);
            this.Name = "bestProduct";
            this.Size = new System.Drawing.Size(299, 196);
            this.Load += new System.EventHandler(this.bestProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ProductImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ProductImage;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblNameProduct;
        private System.Windows.Forms.Label lblOrdersNumber;
    }
}
