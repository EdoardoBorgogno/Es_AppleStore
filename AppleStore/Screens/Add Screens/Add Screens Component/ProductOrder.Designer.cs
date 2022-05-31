namespace AppleStore.Screens.Add_Screens.Add_Screens_Component
{
    partial class ProductOrder
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
            this.detailProductPrice = new System.Windows.Forms.Label();
            this.detailProductName = new System.Windows.Forms.Label();
            this.detailProductPicture = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.detailProductPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // detailProductPrice
            // 
            this.detailProductPrice.Font = new System.Drawing.Font("Dubai", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.detailProductPrice.ForeColor = System.Drawing.Color.Gray;
            this.detailProductPrice.Location = new System.Drawing.Point(66, 36);
            this.detailProductPrice.Name = "detailProductPrice";
            this.detailProductPrice.Size = new System.Drawing.Size(99, 22);
            this.detailProductPrice.TabIndex = 6;
            this.detailProductPrice.Text = "NNNNN";
            this.detailProductPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // detailProductName
            // 
            this.detailProductName.Font = new System.Drawing.Font("Dubai", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.detailProductName.ForeColor = System.Drawing.Color.Gray;
            this.detailProductName.Location = new System.Drawing.Point(62, 10);
            this.detailProductName.Name = "detailProductName";
            this.detailProductName.Size = new System.Drawing.Size(103, 26);
            this.detailProductName.TabIndex = 5;
            this.detailProductName.Text = "NomeProdotto";
            this.detailProductName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // detailProductPicture
            // 
            this.detailProductPicture.Location = new System.Drawing.Point(3, 10);
            this.detailProductPicture.Name = "detailProductPicture";
            this.detailProductPicture.Size = new System.Drawing.Size(53, 48);
            this.detailProductPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.detailProductPicture.TabIndex = 4;
            this.detailProductPicture.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AppleStore.Properties.Resources.delete;
            this.pictureBox1.Location = new System.Drawing.Point(171, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(39, 27);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.delete_Click);
            // 
            // ProductOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.detailProductPrice);
            this.Controls.Add(this.detailProductName);
            this.Controls.Add(this.detailProductPicture);
            this.Name = "ProductOrder";
            this.Size = new System.Drawing.Size(210, 68);
            this.Load += new System.EventHandler(this.ProductOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.detailProductPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label detailProductPrice;
        private System.Windows.Forms.Label detailProductName;
        private System.Windows.Forms.PictureBox detailProductPicture;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
