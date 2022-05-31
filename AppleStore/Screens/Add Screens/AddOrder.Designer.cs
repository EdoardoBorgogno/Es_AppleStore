namespace AppleStore.Screens.Add_Screens
{
    partial class AddOrder
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
            this.lblIdOrdine = new System.Windows.Forms.Label();
            this.lblTitleScreen = new System.Windows.Forms.Label();
            this.lblCustomers = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.cmbCustomers = new System.Windows.Forms.ComboBox();
            this.dateBirth = new System.Windows.Forms.DateTimePicker();
            this.btnAdd = new System.Windows.Forms.Button();
            this.panelSummary = new System.Windows.Forms.Panel();
            this.summary_totalPanel = new System.Windows.Forms.Panel();
            this.summary_totalPanel_price = new System.Windows.Forms.Label();
            this.summary_totalPanel_title = new System.Windows.Forms.Label();
            this.SummaryDetailPanel = new System.Windows.Forms.Panel();
            this.lblSummaryTitle = new System.Windows.Forms.Label();
            this.addItemButton = new System.Windows.Forms.Button();
            this.panelSummary.SuspendLayout();
            this.summary_totalPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblIdOrdine
            // 
            this.lblIdOrdine.AutoSize = true;
            this.lblIdOrdine.Font = new System.Drawing.Font("Dubai", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdOrdine.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.lblIdOrdine.Location = new System.Drawing.Point(41, 54);
            this.lblIdOrdine.Name = "lblIdOrdine";
            this.lblIdOrdine.Size = new System.Drawing.Size(83, 29);
            this.lblIdOrdine.TabIndex = 4;
            this.lblIdOrdine.Text = "#IdOrdine";
            // 
            // lblTitleScreen
            // 
            this.lblTitleScreen.AutoSize = true;
            this.lblTitleScreen.Font = new System.Drawing.Font("Dubai", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleScreen.ForeColor = System.Drawing.Color.Gray;
            this.lblTitleScreen.Location = new System.Drawing.Point(39, 78);
            this.lblTitleScreen.Name = "lblTitleScreen";
            this.lblTitleScreen.Size = new System.Drawing.Size(152, 39);
            this.lblTitleScreen.TabIndex = 3;
            this.lblTitleScreen.Text = "Nuovo Ordine";
            // 
            // lblCustomers
            // 
            this.lblCustomers.AutoSize = true;
            this.lblCustomers.Font = new System.Drawing.Font("Dubai", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomers.ForeColor = System.Drawing.Color.Gray;
            this.lblCustomers.Location = new System.Drawing.Point(41, 155);
            this.lblCustomers.Name = "lblCustomers";
            this.lblCustomers.Size = new System.Drawing.Size(54, 25);
            this.lblCustomers.TabIndex = 58;
            this.lblCustomers.Text = "Cliente";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Dubai", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.Color.Gray;
            this.lblDate.Location = new System.Drawing.Point(41, 236);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(87, 25);
            this.lblDate.TabIndex = 56;
            this.lblDate.Text = "Data Ordine";
            // 
            // cmbCustomers
            // 
            this.cmbCustomers.BackColor = System.Drawing.Color.White;
            this.cmbCustomers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCustomers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbCustomers.Font = new System.Drawing.Font("Dubai", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCustomers.FormattingEnabled = true;
            this.cmbCustomers.Location = new System.Drawing.Point(46, 183);
            this.cmbCustomers.Name = "cmbCustomers";
            this.cmbCustomers.Size = new System.Drawing.Size(252, 33);
            this.cmbCustomers.TabIndex = 59;
            // 
            // dateBirth
            // 
            this.dateBirth.CalendarFont = new System.Drawing.Font("Dubai", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateBirth.CalendarTitleBackColor = System.Drawing.Color.MediumSlateBlue;
            this.dateBirth.Font = new System.Drawing.Font("Dubai", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateBirth.Location = new System.Drawing.Point(46, 273);
            this.dateBirth.Name = "dateBirth";
            this.dateBirth.Size = new System.Drawing.Size(252, 36);
            this.dateBirth.TabIndex = 60;
            // 
            // btnAdd
            // 
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Dubai", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.btnAdd.Location = new System.Drawing.Point(46, 451);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(252, 48);
            this.btnAdd.TabIndex = 61;
            this.btnAdd.Text = "Aggiunge Ordine";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // panelSummary
            // 
            this.panelSummary.BackColor = System.Drawing.Color.White;
            this.panelSummary.Controls.Add(this.addItemButton);
            this.panelSummary.Controls.Add(this.summary_totalPanel);
            this.panelSummary.Controls.Add(this.SummaryDetailPanel);
            this.panelSummary.Controls.Add(this.lblSummaryTitle);
            this.panelSummary.Location = new System.Drawing.Point(431, 65);
            this.panelSummary.Name = "panelSummary";
            this.panelSummary.Size = new System.Drawing.Size(283, 434);
            this.panelSummary.TabIndex = 62;
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
            this.summary_totalPanel_price.Text = "0.00€";
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
            this.SummaryDetailPanel.Location = new System.Drawing.Point(23, 118);
            this.SummaryDetailPanel.Name = "SummaryDetailPanel";
            this.SummaryDetailPanel.Size = new System.Drawing.Size(240, 225);
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
            // addItemButton
            // 
            this.addItemButton.FlatAppearance.BorderSize = 0;
            this.addItemButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.addItemButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.addItemButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addItemButton.Font = new System.Drawing.Font("Dubai", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addItemButton.ForeColor = System.Drawing.Color.LimeGreen;
            this.addItemButton.Location = new System.Drawing.Point(161, 78);
            this.addItemButton.Name = "addItemButton";
            this.addItemButton.Size = new System.Drawing.Size(102, 34);
            this.addItemButton.TabIndex = 60;
            this.addItemButton.Text = "Aggiungi";
            this.addItemButton.UseVisualStyleBackColor = true;
            this.addItemButton.Click += new System.EventHandler(this.addItemButton_Click);
            // 
            // AddOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.panelSummary);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dateBirth);
            this.Controls.Add(this.cmbCustomers);
            this.Controls.Add(this.lblCustomers);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblIdOrdine);
            this.Controls.Add(this.lblTitleScreen);
            this.ForeColor = System.Drawing.Color.Gray;
            this.Name = "AddOrder";
            this.Size = new System.Drawing.Size(784, 597);
            this.Load += new System.EventHandler(this.AddOrder_Load);
            this.panelSummary.ResumeLayout(false);
            this.panelSummary.PerformLayout();
            this.summary_totalPanel.ResumeLayout(false);
            this.summary_totalPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIdOrdine;
        private System.Windows.Forms.Label lblTitleScreen;
        private System.Windows.Forms.Label lblCustomers;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.ComboBox cmbCustomers;
        private System.Windows.Forms.DateTimePicker dateBirth;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Panel panelSummary;
        private System.Windows.Forms.Panel summary_totalPanel;
        private System.Windows.Forms.Label summary_totalPanel_price;
        private System.Windows.Forms.Label summary_totalPanel_title;
        private System.Windows.Forms.Panel SummaryDetailPanel;
        private System.Windows.Forms.Label lblSummaryTitle;
        private System.Windows.Forms.Button addItemButton;
    }
}
