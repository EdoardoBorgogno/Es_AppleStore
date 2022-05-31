namespace AppleStore.Screens.Dashboard
{
    partial class Dashboard
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
            this.topPanela_avgOrderCost = new System.Windows.Forms.Panel();
            this.topPanela_avgOrderCost_title = new System.Windows.Forms.Label();
            this.topPanela_avgOrderCost_numer = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.topItem1 = new AppleStore.Screens.Dashboard.TopItem();
            this.chartYear1 = new AppleStore.Screens.Dashboard.Dashboard_Components.ChartYear();
            this.topPanel_TotalOrders_title = new System.Windows.Forms.Label();
            this.topPanel_TotalOrders_number = new System.Windows.Forms.Label();
            this.topPanel_TotalOrders = new System.Windows.Forms.Panel();
            this.topPanel_TotalProductSales_number = new System.Windows.Forms.Label();
            this.topPanela_TotalProductSales = new System.Windows.Forms.Panel();
            this.topPanel_TotalProductSales_title = new System.Windows.Forms.Label();
            this.panelNewOrder_title = new System.Windows.Forms.Label();
            this.panelNewOrder = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.topPanela_avgOrderCost.SuspendLayout();
            this.panel4.SuspendLayout();
            this.topPanel_TotalOrders.SuspendLayout();
            this.topPanela_TotalProductSales.SuspendLayout();
            this.panelNewOrder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // topPanela_avgOrderCost
            // 
            this.topPanela_avgOrderCost.BackColor = System.Drawing.Color.White;
            this.topPanela_avgOrderCost.Controls.Add(this.topPanela_avgOrderCost_title);
            this.topPanela_avgOrderCost.Controls.Add(this.topPanela_avgOrderCost_numer);
            this.topPanela_avgOrderCost.Location = new System.Drawing.Point(3, 0);
            this.topPanela_avgOrderCost.Name = "topPanela_avgOrderCost";
            this.topPanela_avgOrderCost.Size = new System.Drawing.Size(291, 125);
            this.topPanela_avgOrderCost.TabIndex = 6;
            // 
            // topPanela_avgOrderCost_title
            // 
            this.topPanela_avgOrderCost_title.AutoSize = true;
            this.topPanela_avgOrderCost_title.Font = new System.Drawing.Font("Dubai", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.topPanela_avgOrderCost_title.ForeColor = System.Drawing.Color.DarkGray;
            this.topPanela_avgOrderCost_title.Location = new System.Drawing.Point(71, 71);
            this.topPanela_avgOrderCost_title.Name = "topPanela_avgOrderCost_title";
            this.topPanela_avgOrderCost_title.Size = new System.Drawing.Size(153, 29);
            this.topPanela_avgOrderCost_title.TabIndex = 20;
            this.topPanela_avgOrderCost_title.Text = "Media Costo Ordine";
            // 
            // topPanela_avgOrderCost_numer
            // 
            this.topPanela_avgOrderCost_numer.Font = new System.Drawing.Font("Dubai", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.topPanela_avgOrderCost_numer.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.topPanela_avgOrderCost_numer.Location = new System.Drawing.Point(0, 10);
            this.topPanela_avgOrderCost_numer.Name = "topPanela_avgOrderCost_numer";
            this.topPanela_avgOrderCost_numer.Size = new System.Drawing.Size(291, 48);
            this.topPanela_avgOrderCost_numer.TabIndex = 19;
            this.topPanela_avgOrderCost_numer.Text = "NN";
            this.topPanela_avgOrderCost_numer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.topPanela_avgOrderCost);
            this.panel4.Location = new System.Drawing.Point(472, 25);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(295, 125);
            this.panel4.TabIndex = 2;
            // 
            // topItem1
            // 
            this.topItem1.BackColor = System.Drawing.Color.White;
            this.topItem1.Location = new System.Drawing.Point(472, 172);
            this.topItem1.Name = "topItem1";
            this.topItem1.Size = new System.Drawing.Size(294, 406);
            this.topItem1.TabIndex = 3;
            // 
            // chartYear1
            // 
            this.chartYear1.Location = new System.Drawing.Point(20, 275);
            this.chartYear1.Name = "chartYear1";
            this.chartYear1.Size = new System.Drawing.Size(432, 302);
            this.chartYear1.TabIndex = 4;
            // 
            // topPanel_TotalOrders_title
            // 
            this.topPanel_TotalOrders_title.AutoSize = true;
            this.topPanel_TotalOrders_title.Font = new System.Drawing.Font("Dubai", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.topPanel_TotalOrders_title.ForeColor = System.Drawing.Color.DarkGray;
            this.topPanel_TotalOrders_title.Location = new System.Drawing.Point(34, 48);
            this.topPanel_TotalOrders_title.Name = "topPanel_TotalOrders_title";
            this.topPanel_TotalOrders_title.Size = new System.Drawing.Size(118, 29);
            this.topPanel_TotalOrders_title.TabIndex = 16;
            this.topPanel_TotalOrders_title.Text = "Numero Ordini";
            // 
            // topPanel_TotalOrders_number
            // 
            this.topPanel_TotalOrders_number.Font = new System.Drawing.Font("Dubai", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.topPanel_TotalOrders_number.ForeColor = System.Drawing.Color.Tomato;
            this.topPanel_TotalOrders_number.Location = new System.Drawing.Point(0, 3);
            this.topPanel_TotalOrders_number.Name = "topPanel_TotalOrders_number";
            this.topPanel_TotalOrders_number.Size = new System.Drawing.Size(184, 48);
            this.topPanel_TotalOrders_number.TabIndex = 15;
            this.topPanel_TotalOrders_number.Text = "NN";
            this.topPanel_TotalOrders_number.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // topPanel_TotalOrders
            // 
            this.topPanel_TotalOrders.BackColor = System.Drawing.Color.White;
            this.topPanel_TotalOrders.Controls.Add(this.topPanel_TotalOrders_title);
            this.topPanel_TotalOrders.Controls.Add(this.topPanel_TotalOrders_number);
            this.topPanel_TotalOrders.Location = new System.Drawing.Point(20, 25);
            this.topPanel_TotalOrders.Name = "topPanel_TotalOrders";
            this.topPanel_TotalOrders.Size = new System.Drawing.Size(184, 85);
            this.topPanel_TotalOrders.TabIndex = 5;
            // 
            // topPanel_TotalProductSales_number
            // 
            this.topPanel_TotalProductSales_number.Font = new System.Drawing.Font("Dubai", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.topPanel_TotalProductSales_number.ForeColor = System.Drawing.Color.LimeGreen;
            this.topPanel_TotalProductSales_number.Location = new System.Drawing.Point(0, 3);
            this.topPanel_TotalProductSales_number.Name = "topPanel_TotalProductSales_number";
            this.topPanel_TotalProductSales_number.Size = new System.Drawing.Size(184, 48);
            this.topPanel_TotalProductSales_number.TabIndex = 17;
            this.topPanel_TotalProductSales_number.Text = "NN";
            this.topPanel_TotalProductSales_number.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // topPanela_TotalProductSales
            // 
            this.topPanela_TotalProductSales.BackColor = System.Drawing.Color.White;
            this.topPanela_TotalProductSales.Controls.Add(this.topPanel_TotalProductSales_title);
            this.topPanela_TotalProductSales.Controls.Add(this.topPanel_TotalProductSales_number);
            this.topPanela_TotalProductSales.Location = new System.Drawing.Point(243, 25);
            this.topPanela_TotalProductSales.Name = "topPanela_TotalProductSales";
            this.topPanela_TotalProductSales.Size = new System.Drawing.Size(184, 85);
            this.topPanela_TotalProductSales.TabIndex = 6;
            // 
            // topPanel_TotalProductSales_title
            // 
            this.topPanel_TotalProductSales_title.AutoSize = true;
            this.topPanel_TotalProductSales_title.Font = new System.Drawing.Font("Dubai", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.topPanel_TotalProductSales_title.ForeColor = System.Drawing.Color.DarkGray;
            this.topPanel_TotalProductSales_title.Location = new System.Drawing.Point(24, 48);
            this.topPanel_TotalProductSales_title.Name = "topPanel_TotalProductSales_title";
            this.topPanel_TotalProductSales_title.Size = new System.Drawing.Size(132, 29);
            this.topPanel_TotalProductSales_title.TabIndex = 18;
            this.topPanel_TotalProductSales_title.Text = "Prodotti Venduti";
            // 
            // panelNewOrder_title
            // 
            this.panelNewOrder_title.Font = new System.Drawing.Font("Dubai", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelNewOrder_title.ForeColor = System.Drawing.Color.White;
            this.panelNewOrder_title.Location = new System.Drawing.Point(-6, 0);
            this.panelNewOrder_title.Name = "panelNewOrder_title";
            this.panelNewOrder_title.Size = new System.Drawing.Size(225, 48);
            this.panelNewOrder_title.TabIndex = 17;
            this.panelNewOrder_title.Text = "Inserisici nuovo ordine";
            this.panelNewOrder_title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelNewOrder
            // 
            this.panelNewOrder.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.panelNewOrder.Controls.Add(this.button1);
            this.panelNewOrder.Controls.Add(this.pictureBox1);
            this.panelNewOrder.Controls.Add(this.panelNewOrder_title);
            this.panelNewOrder.Location = new System.Drawing.Point(20, 140);
            this.panelNewOrder.Name = "panelNewOrder";
            this.panelNewOrder.Size = new System.Drawing.Size(383, 93);
            this.panelNewOrder.TabIndex = 17;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(15, 51);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(167, 31);
            this.button1.TabIndex = 19;
            this.button1.Text = "Aggiungi";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::AppleStore.Properties.Resources.empty_states_5__1_;
            this.pictureBox1.Location = new System.Drawing.Point(231, -24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(165, 147);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.panelNewOrder);
            this.Controls.Add(this.topPanel_TotalOrders);
            this.Controls.Add(this.topPanela_TotalProductSales);
            this.Controls.Add(this.chartYear1);
            this.Controls.Add(this.topItem1);
            this.Controls.Add(this.panel4);
            this.Name = "Dashboard";
            this.Size = new System.Drawing.Size(784, 597);
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.topPanela_avgOrderCost.ResumeLayout(false);
            this.topPanela_avgOrderCost.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.topPanel_TotalOrders.ResumeLayout(false);
            this.topPanel_TotalOrders.PerformLayout();
            this.topPanela_TotalProductSales.ResumeLayout(false);
            this.topPanela_TotalProductSales.PerformLayout();
            this.panelNewOrder.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private TopItem topItem1;
        private System.Windows.Forms.Panel topPanela_avgOrderCost;
        private System.Windows.Forms.Label topPanela_avgOrderCost_title;
        private System.Windows.Forms.Label topPanela_avgOrderCost_numer;
        private System.Windows.Forms.Panel panel4;
        private Dashboard_Components.ChartYear chartYear1;
        private System.Windows.Forms.Label topPanel_TotalOrders_title;
        private System.Windows.Forms.Label topPanel_TotalOrders_number;
        private System.Windows.Forms.Panel topPanel_TotalOrders;
        private System.Windows.Forms.Label topPanel_TotalProductSales_number;
        private System.Windows.Forms.Panel topPanela_TotalProductSales;
        private System.Windows.Forms.Label topPanel_TotalProductSales_title;
        private System.Windows.Forms.Label panelNewOrder_title;
        private System.Windows.Forms.Panel panelNewOrder;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
