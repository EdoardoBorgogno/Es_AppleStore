namespace AppleStore.Screens.View_Order.View_Order_Component
{
    partial class OrderDetail
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
            this.detailProductName = new System.Windows.Forms.Label();
            this.detailProductPrice = new System.Windows.Forms.Label();
            this.detailProductPicture = new System.Windows.Forms.PictureBox();
            this.detailProductQuantity = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.detailProductPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // detailProductName
            // 
            this.detailProductName.Font = new System.Drawing.Font("Dubai", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.detailProductName.ForeColor = System.Drawing.Color.Gray;
            this.detailProductName.Location = new System.Drawing.Point(103, 10);
            this.detailProductName.Name = "detailProductName";
            this.detailProductName.Size = new System.Drawing.Size(103, 26);
            this.detailProductName.TabIndex = 1;
            this.detailProductName.Text = "NomeDettaglio";
            this.detailProductName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // detailProductPrice
            // 
            this.detailProductPrice.Font = new System.Drawing.Font("Dubai", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.detailProductPrice.ForeColor = System.Drawing.Color.Gray;
            this.detailProductPrice.Location = new System.Drawing.Point(107, 36);
            this.detailProductPrice.Name = "detailProductPrice";
            this.detailProductPrice.Size = new System.Drawing.Size(99, 22);
            this.detailProductPrice.TabIndex = 2;
            this.detailProductPrice.Text = "NNNNN";
            this.detailProductPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // detailProductPicture
            // 
            this.detailProductPicture.Location = new System.Drawing.Point(8, 10);
            this.detailProductPicture.Name = "detailProductPicture";
            this.detailProductPicture.Size = new System.Drawing.Size(53, 48);
            this.detailProductPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.detailProductPicture.TabIndex = 0;
            this.detailProductPicture.TabStop = false;
            // 
            // detailProductQuantity
            // 
            this.detailProductQuantity.Font = new System.Drawing.Font("Dubai", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.detailProductQuantity.ForeColor = System.Drawing.Color.Gray;
            this.detailProductQuantity.Location = new System.Drawing.Point(204, 36);
            this.detailProductQuantity.Name = "detailProductQuantity";
            this.detailProductQuantity.Size = new System.Drawing.Size(36, 22);
            this.detailProductQuantity.TabIndex = 3;
            this.detailProductQuantity.Text = "XN";
            this.detailProductQuantity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // OrderDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.detailProductQuantity);
            this.Controls.Add(this.detailProductPrice);
            this.Controls.Add(this.detailProductName);
            this.Controls.Add(this.detailProductPicture);
            this.Name = "OrderDetail";
            this.Size = new System.Drawing.Size(240, 68);
            ((System.ComponentModel.ISupportInitialize)(this.detailProductPicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox detailProductPicture;
        private System.Windows.Forms.Label detailProductName;
        private System.Windows.Forms.Label detailProductPrice;
        private System.Windows.Forms.Label detailProductQuantity;
    }
}
