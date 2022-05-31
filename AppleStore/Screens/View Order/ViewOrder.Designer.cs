namespace AppleStore.Screens.View_Order
{
    partial class ViewOrder
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
            this.lblTitleScreen = new System.Windows.Forms.Label();
            this.lblIdOrdine = new System.Windows.Forms.Label();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.txtCustomer = new System.Windows.Forms.TextBox();
            this.lblCustomers = new System.Windows.Forms.Label();
            this.panelSummary = new System.Windows.Forms.Panel();
            this.summary_totalPanel = new System.Windows.Forms.Panel();
            this.summary_totalPanel_price = new System.Windows.Forms.Label();
            this.summary_totalPanel_title = new System.Windows.Forms.Label();
            this.SummaryDetailPanel = new System.Windows.Forms.Panel();
            this.lblSummaryTitle = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.panelSummary.SuspendLayout();
            this.summary_totalPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitleScreen
            // 
            this.lblTitleScreen.AutoSize = true;
            this.lblTitleScreen.Font = new System.Drawing.Font("Dubai", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleScreen.ForeColor = System.Drawing.Color.Gray;
            this.lblTitleScreen.Location = new System.Drawing.Point(40, 80);
            this.lblTitleScreen.Name = "lblTitleScreen";
            this.lblTitleScreen.Size = new System.Drawing.Size(181, 39);
            this.lblTitleScreen.TabIndex = 1;
            this.lblTitleScreen.Text = "Riepilogo Ordine";
            // 
            // lblIdOrdine
            // 
            this.lblIdOrdine.AutoSize = true;
            this.lblIdOrdine.Font = new System.Drawing.Font("Dubai", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdOrdine.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.lblIdOrdine.Location = new System.Drawing.Point(42, 56);
            this.lblIdOrdine.Name = "lblIdOrdine";
            this.lblIdOrdine.Size = new System.Drawing.Size(83, 29);
            this.lblIdOrdine.TabIndex = 2;
            this.lblIdOrdine.Text = "#IdOrdine";
            // 
            // txtDate
            // 
            this.txtDate.BackColor = System.Drawing.Color.White;
            this.txtDate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDate.Font = new System.Drawing.Font("Dubai", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDate.ForeColor = System.Drawing.Color.Gray;
            this.txtDate.Location = new System.Drawing.Point(47, 274);
            this.txtDate.Name = "txtDate";
            this.txtDate.ReadOnly = true;
            this.txtDate.Size = new System.Drawing.Size(252, 29);
            this.txtDate.TabIndex = 53;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Dubai", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.Color.Gray;
            this.lblDate.Location = new System.Drawing.Point(42, 237);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(87, 25);
            this.lblDate.TabIndex = 52;
            this.lblDate.Text = "Data Ordine";
            // 
            // txtCustomer
            // 
            this.txtCustomer.BackColor = System.Drawing.Color.White;
            this.txtCustomer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCustomer.Font = new System.Drawing.Font("Dubai", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomer.ForeColor = System.Drawing.Color.Gray;
            this.txtCustomer.Location = new System.Drawing.Point(47, 193);
            this.txtCustomer.Name = "txtCustomer";
            this.txtCustomer.ReadOnly = true;
            this.txtCustomer.Size = new System.Drawing.Size(252, 29);
            this.txtCustomer.TabIndex = 55;
            // 
            // lblCustomers
            // 
            this.lblCustomers.AutoSize = true;
            this.lblCustomers.Font = new System.Drawing.Font("Dubai", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomers.ForeColor = System.Drawing.Color.Gray;
            this.lblCustomers.Location = new System.Drawing.Point(42, 156);
            this.lblCustomers.Name = "lblCustomers";
            this.lblCustomers.Size = new System.Drawing.Size(54, 25);
            this.lblCustomers.TabIndex = 54;
            this.lblCustomers.Text = "Cliente";
            // 
            // panelSummary
            // 
            this.panelSummary.BackColor = System.Drawing.Color.White;
            this.panelSummary.Controls.Add(this.summary_totalPanel);
            this.panelSummary.Controls.Add(this.SummaryDetailPanel);
            this.panelSummary.Controls.Add(this.lblSummaryTitle);
            this.panelSummary.Location = new System.Drawing.Point(449, 56);
            this.panelSummary.Name = "panelSummary";
            this.panelSummary.Size = new System.Drawing.Size(283, 434);
            this.panelSummary.TabIndex = 56;
            // 
            // summary_totalPanel
            // 
            this.summary_totalPanel.Controls.Add(this.summary_totalPanel_price);
            this.summary_totalPanel.Controls.Add(this.summary_totalPanel_title);
            this.summary_totalPanel.ForeColor = System.Drawing.Color.Gray;
            this.summary_totalPanel.Location = new System.Drawing.Point(23, 364);
            this.summary_totalPanel.Name = "summary_totalPanel";
            this.summary_totalPanel.Size = new System.Drawing.Size(240, 52);
            this.summary_totalPanel.TabIndex = 59;
            // 
            // summary_totalPanel_price
            // 
            this.summary_totalPanel_price.Font = new System.Drawing.Font("Dubai", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.summary_totalPanel_price.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.summary_totalPanel_price.Location = new System.Drawing.Point(91, 11);
            this.summary_totalPanel_price.Name = "summary_totalPanel_price";
            this.summary_totalPanel_price.Size = new System.Drawing.Size(146, 25);
            this.summary_totalPanel_price.TabIndex = 58;
            this.summary_totalPanel_price.Text = "NNNN.NN€";
            this.summary_totalPanel_price.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // summary_totalPanel_title
            // 
            this.summary_totalPanel_title.AutoSize = true;
            this.summary_totalPanel_title.Font = new System.Drawing.Font("Dubai", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.summary_totalPanel_title.ForeColor = System.Drawing.Color.Gray;
            this.summary_totalPanel_title.Location = new System.Drawing.Point(12, 11);
            this.summary_totalPanel_title.Name = "summary_totalPanel_title";
            this.summary_totalPanel_title.Size = new System.Drawing.Size(59, 30);
            this.summary_totalPanel_title.TabIndex = 57;
            this.summary_totalPanel_title.Text = "Totale";
            // 
            // SummaryDetailPanel
            // 
            this.SummaryDetailPanel.AutoScroll = true;
            this.SummaryDetailPanel.Location = new System.Drawing.Point(23, 69);
            this.SummaryDetailPanel.Name = "SummaryDetailPanel";
            this.SummaryDetailPanel.Size = new System.Drawing.Size(240, 274);
            this.SummaryDetailPanel.TabIndex = 58;
            // 
            // lblSummaryTitle
            // 
            this.lblSummaryTitle.AutoSize = true;
            this.lblSummaryTitle.Font = new System.Drawing.Font("Dubai", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSummaryTitle.ForeColor = System.Drawing.Color.Gray;
            this.lblSummaryTitle.Location = new System.Drawing.Point(12, 11);
            this.lblSummaryTitle.Name = "lblSummaryTitle";
            this.lblSummaryTitle.Size = new System.Drawing.Size(169, 39);
            this.lblSummaryTitle.TabIndex = 57;
            this.lblSummaryTitle.Text = "Dettagli Ordine";
            // 
            // btnBack
            // 
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Dubai", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.btnBack.Location = new System.Drawing.Point(47, 442);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(252, 48);
            this.btnBack.TabIndex = 57;
            this.btnBack.Text = "Vai alle vendite";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // ViewOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.panelSummary);
            this.Controls.Add(this.txtCustomer);
            this.Controls.Add(this.lblCustomers);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblIdOrdine);
            this.Controls.Add(this.lblTitleScreen);
            this.Name = "ViewOrder";
            this.Size = new System.Drawing.Size(784, 597);
            this.panelSummary.ResumeLayout(false);
            this.panelSummary.PerformLayout();
            this.summary_totalPanel.ResumeLayout(false);
            this.summary_totalPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitleScreen;
        private System.Windows.Forms.Label lblIdOrdine;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.TextBox txtCustomer;
        private System.Windows.Forms.Label lblCustomers;
        private System.Windows.Forms.Panel panelSummary;
        private System.Windows.Forms.Label lblSummaryTitle;
        private System.Windows.Forms.Panel SummaryDetailPanel;
        private System.Windows.Forms.Panel summary_totalPanel;
        private System.Windows.Forms.Label summary_totalPanel_title;
        private System.Windows.Forms.Label summary_totalPanel_price;
        private System.Windows.Forms.Button btnBack;
    }
}
