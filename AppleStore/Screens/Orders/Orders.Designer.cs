namespace AppleStore.Screens.Orders
{
    partial class Orders
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.separator1 = new System.Windows.Forms.Panel();
            this.topPanel_TotalOrders = new System.Windows.Forms.Panel();
            this.topPanel_TotalOrders_title = new System.Windows.Forms.Label();
            this.topPanel_TotalOrders_number = new System.Windows.Forms.Label();
            this.topPanela_TotalProductSales = new System.Windows.Forms.Panel();
            this.topPanel_TotalProductSales_title = new System.Windows.Forms.Label();
            this.topPanel_TotalProductSales_number = new System.Windows.Forms.Label();
            this.topPanela_avgOrderCost = new System.Windows.Forms.Panel();
            this.topPanela_avgOrderCost_title = new System.Windows.Forms.Label();
            this.topPanela_avgOrderCost_numer = new System.Windows.Forms.Label();
            this.invoicesPanel = new System.Windows.Forms.Panel();
            this.invoicesPanel_button = new System.Windows.Forms.Button();
            this.invocesPanel_title = new System.Windows.Forms.Label();
            this.invoicesPanel_picture = new System.Windows.Forms.PictureBox();
            this.panelNewOrder = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelNewOrder_title = new System.Windows.Forms.Label();
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.separator2 = new System.Windows.Forms.Panel();
            this.lblDataGridTitle = new System.Windows.Forms.Label();
            this.lblTitle_TopPanel = new System.Windows.Forms.Label();
            this.bestProduct1 = new AppleStore.Screens.Orders.Orders_Components.bestProduct();
            this.chartOrdersForMonth1 = new AppleStore.Screens.Orders.Orders_Components.ChartOrdersForMonth();
            this.topPanel_TotalOrders.SuspendLayout();
            this.topPanela_TotalProductSales.SuspendLayout();
            this.topPanela_avgOrderCost.SuspendLayout();
            this.invoicesPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.invoicesPanel_picture)).BeginInit();
            this.panelNewOrder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // separator1
            // 
            this.separator1.BackColor = System.Drawing.Color.Gainsboro;
            this.separator1.Location = new System.Drawing.Point(3, 166);
            this.separator1.Name = "separator1";
            this.separator1.Size = new System.Drawing.Size(754, 1);
            this.separator1.TabIndex = 0;
            // 
            // topPanel_TotalOrders
            // 
            this.topPanel_TotalOrders.BackColor = System.Drawing.Color.White;
            this.topPanel_TotalOrders.Controls.Add(this.topPanel_TotalOrders_title);
            this.topPanel_TotalOrders.Controls.Add(this.topPanel_TotalOrders_number);
            this.topPanel_TotalOrders.Location = new System.Drawing.Point(63, 65);
            this.topPanel_TotalOrders.Name = "topPanel_TotalOrders";
            this.topPanel_TotalOrders.Size = new System.Drawing.Size(184, 85);
            this.topPanel_TotalOrders.TabIndex = 2;
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
            // topPanela_TotalProductSales
            // 
            this.topPanela_TotalProductSales.BackColor = System.Drawing.Color.White;
            this.topPanela_TotalProductSales.Controls.Add(this.topPanel_TotalProductSales_title);
            this.topPanela_TotalProductSales.Controls.Add(this.topPanel_TotalProductSales_number);
            this.topPanela_TotalProductSales.Location = new System.Drawing.Point(286, 65);
            this.topPanela_TotalProductSales.Name = "topPanela_TotalProductSales";
            this.topPanela_TotalProductSales.Size = new System.Drawing.Size(184, 85);
            this.topPanela_TotalProductSales.TabIndex = 3;
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
            // topPanela_avgOrderCost
            // 
            this.topPanela_avgOrderCost.BackColor = System.Drawing.Color.White;
            this.topPanela_avgOrderCost.Controls.Add(this.topPanela_avgOrderCost_title);
            this.topPanela_avgOrderCost.Controls.Add(this.topPanela_avgOrderCost_numer);
            this.topPanela_avgOrderCost.Location = new System.Drawing.Point(513, 65);
            this.topPanela_avgOrderCost.Name = "topPanela_avgOrderCost";
            this.topPanela_avgOrderCost.Size = new System.Drawing.Size(184, 85);
            this.topPanela_avgOrderCost.TabIndex = 5;
            // 
            // topPanela_avgOrderCost_title
            // 
            this.topPanela_avgOrderCost_title.AutoSize = true;
            this.topPanela_avgOrderCost_title.Font = new System.Drawing.Font("Dubai", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.topPanela_avgOrderCost_title.ForeColor = System.Drawing.Color.DarkGray;
            this.topPanela_avgOrderCost_title.Location = new System.Drawing.Point(14, 48);
            this.topPanela_avgOrderCost_title.Name = "topPanela_avgOrderCost_title";
            this.topPanela_avgOrderCost_title.Size = new System.Drawing.Size(153, 29);
            this.topPanela_avgOrderCost_title.TabIndex = 20;
            this.topPanela_avgOrderCost_title.Text = "Media Costo Ordine";
            // 
            // topPanela_avgOrderCost_numer
            // 
            this.topPanela_avgOrderCost_numer.Font = new System.Drawing.Font("Dubai", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.topPanela_avgOrderCost_numer.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.topPanela_avgOrderCost_numer.Location = new System.Drawing.Point(0, 1);
            this.topPanela_avgOrderCost_numer.Name = "topPanela_avgOrderCost_numer";
            this.topPanela_avgOrderCost_numer.Size = new System.Drawing.Size(184, 48);
            this.topPanela_avgOrderCost_numer.TabIndex = 19;
            this.topPanela_avgOrderCost_numer.Text = "NN";
            this.topPanela_avgOrderCost_numer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // invoicesPanel
            // 
            this.invoicesPanel.BackColor = System.Drawing.Color.White;
            this.invoicesPanel.Controls.Add(this.invoicesPanel_button);
            this.invoicesPanel.Controls.Add(this.invocesPanel_title);
            this.invoicesPanel.Controls.Add(this.invoicesPanel_picture);
            this.invoicesPanel.Location = new System.Drawing.Point(10, 449);
            this.invoicesPanel.Name = "invoicesPanel";
            this.invoicesPanel.Size = new System.Drawing.Size(359, 93);
            this.invoicesPanel.TabIndex = 8;
            // 
            // invoicesPanel_button
            // 
            this.invoicesPanel_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.invoicesPanel_button.ForeColor = System.Drawing.Color.Gray;
            this.invoicesPanel_button.Location = new System.Drawing.Point(8, 51);
            this.invoicesPanel_button.Name = "invoicesPanel_button";
            this.invoicesPanel_button.Size = new System.Drawing.Size(167, 31);
            this.invoicesPanel_button.TabIndex = 20;
            this.invoicesPanel_button.Text = "Vedi le tue fatture";
            this.invoicesPanel_button.UseVisualStyleBackColor = true;
            this.invoicesPanel_button.Click += new System.EventHandler(this.invoicesPanel_button_Click);
            // 
            // invocesPanel_title
            // 
            this.invocesPanel_title.Font = new System.Drawing.Font("Dubai", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.invocesPanel_title.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.invocesPanel_title.Location = new System.Drawing.Point(0, 0);
            this.invocesPanel_title.Name = "invocesPanel_title";
            this.invocesPanel_title.Size = new System.Drawing.Size(205, 48);
            this.invocesPanel_title.TabIndex = 21;
            this.invocesPanel_title.Text = "Le tue fatture";
            this.invocesPanel_title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // invoicesPanel_picture
            // 
            this.invoicesPanel_picture.Image = global::AppleStore.Properties.Resources.online_money_donation;
            this.invoicesPanel_picture.Location = new System.Drawing.Point(204, 3);
            this.invoicesPanel_picture.Name = "invoicesPanel_picture";
            this.invoicesPanel_picture.Size = new System.Drawing.Size(154, 89);
            this.invoicesPanel_picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.invoicesPanel_picture.TabIndex = 0;
            this.invoicesPanel_picture.TabStop = false;
            // 
            // panelNewOrder
            // 
            this.panelNewOrder.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.panelNewOrder.Controls.Add(this.button1);
            this.panelNewOrder.Controls.Add(this.pictureBox1);
            this.panelNewOrder.Controls.Add(this.panelNewOrder_title);
            this.panelNewOrder.Location = new System.Drawing.Point(422, 211);
            this.panelNewOrder.Name = "panelNewOrder";
            this.panelNewOrder.Size = new System.Drawing.Size(299, 93);
            this.panelNewOrder.TabIndex = 9;
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
            this.pictureBox1.Location = new System.Drawing.Point(219, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(80, 67);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
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
            // dataGrid
            // 
            this.dataGrid.AllowUserToAddRows = false;
            this.dataGrid.AllowUserToDeleteRows = false;
            this.dataGrid.AllowUserToResizeColumns = false;
            this.dataGrid.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Dubai", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(10);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Gray;
            this.dataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGrid.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.MediumSlateBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Dubai", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(10);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.MediumSlateBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Dubai", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(10);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGrid.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGrid.EnableHeadersVisualStyles = false;
            this.dataGrid.GridColor = System.Drawing.Color.White;
            this.dataGrid.Location = new System.Drawing.Point(10, 697);
            this.dataGrid.MultiSelect = false;
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.ReadOnly = true;
            this.dataGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGrid.RowHeadersVisible = false;
            this.dataGrid.RowHeadersWidth = 50;
            this.dataGrid.RowTemplate.Height = 24;
            this.dataGrid.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGrid.Size = new System.Drawing.Size(711, 316);
            this.dataGrid.TabIndex = 11;
            this.dataGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid_cellClick);
            // 
            // separator2
            // 
            this.separator2.BackColor = System.Drawing.Color.Gainsboro;
            this.separator2.Location = new System.Drawing.Point(4, 592);
            this.separator2.Name = "separator2";
            this.separator2.Size = new System.Drawing.Size(781, 1);
            this.separator2.TabIndex = 12;
            // 
            // lblDataGridTitle
            // 
            this.lblDataGridTitle.AutoSize = true;
            this.lblDataGridTitle.Font = new System.Drawing.Font("Dubai", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataGridTitle.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.lblDataGridTitle.Location = new System.Drawing.Point(5, 637);
            this.lblDataGridTitle.Name = "lblDataGridTitle";
            this.lblDataGridTitle.Size = new System.Drawing.Size(115, 29);
            this.lblDataGridTitle.TabIndex = 13;
            this.lblDataGridTitle.Text = "Tutti gli ordini";
            // 
            // lblTitle_TopPanel
            // 
            this.lblTitle_TopPanel.AutoSize = true;
            this.lblTitle_TopPanel.Font = new System.Drawing.Font("Dubai", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle_TopPanel.Location = new System.Drawing.Point(13, 11);
            this.lblTitle_TopPanel.Name = "lblTitle_TopPanel";
            this.lblTitle_TopPanel.Size = new System.Drawing.Size(125, 29);
            this.lblTitle_TopPanel.TabIndex = 1;
            this.lblTitle_TopPanel.Text = "Attività Vendite";
            // 
            // bestProduct1
            // 
            this.bestProduct1.BackColor = System.Drawing.Color.White;
            this.bestProduct1.Location = new System.Drawing.Point(422, 341);
            this.bestProduct1.Name = "bestProduct1";
            this.bestProduct1.Size = new System.Drawing.Size(298, 200);
            this.bestProduct1.TabIndex = 15;
            // 
            // chartOrdersForMonth1
            // 
            this.chartOrdersForMonth1.BackColor = System.Drawing.Color.White;
            this.chartOrdersForMonth1.Location = new System.Drawing.Point(10, 211);
            this.chartOrdersForMonth1.Name = "chartOrdersForMonth1";
            this.chartOrdersForMonth1.Size = new System.Drawing.Size(359, 198);
            this.chartOrdersForMonth1.TabIndex = 14;
            // 
            // Orders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.bestProduct1);
            this.Controls.Add(this.chartOrdersForMonth1);
            this.Controls.Add(this.lblDataGridTitle);
            this.Controls.Add(this.separator2);
            this.Controls.Add(this.dataGrid);
            this.Controls.Add(this.panelNewOrder);
            this.Controls.Add(this.invoicesPanel);
            this.Controls.Add(this.topPanela_avgOrderCost);
            this.Controls.Add(this.topPanela_TotalProductSales);
            this.Controls.Add(this.topPanel_TotalOrders);
            this.Controls.Add(this.lblTitle_TopPanel);
            this.Controls.Add(this.separator1);
            this.Name = "Orders";
            this.Size = new System.Drawing.Size(718, 508);
            this.Load += new System.EventHandler(this.Orders_Load);
            this.topPanel_TotalOrders.ResumeLayout(false);
            this.topPanel_TotalOrders.PerformLayout();
            this.topPanela_TotalProductSales.ResumeLayout(false);
            this.topPanela_TotalProductSales.PerformLayout();
            this.topPanela_avgOrderCost.ResumeLayout(false);
            this.topPanela_avgOrderCost.PerformLayout();
            this.invoicesPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.invoicesPanel_picture)).EndInit();
            this.panelNewOrder.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel separator1;
        private System.Windows.Forms.Panel topPanel_TotalOrders;
        private System.Windows.Forms.Panel topPanela_TotalProductSales;
        private System.Windows.Forms.Panel topPanela_avgOrderCost;
        private System.Windows.Forms.Panel invoicesPanel;
        private System.Windows.Forms.Panel panelNewOrder;
        private System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.Panel separator2;
        private System.Windows.Forms.Label lblDataGridTitle;
        private System.Windows.Forms.Label topPanel_TotalOrders_title;
        private System.Windows.Forms.Label topPanel_TotalOrders_number;
        private System.Windows.Forms.Label topPanel_TotalProductSales_title;
        private System.Windows.Forms.Label topPanel_TotalProductSales_number;
        private System.Windows.Forms.Label topPanela_avgOrderCost_title;
        private System.Windows.Forms.Label topPanela_avgOrderCost_numer;
        private Orders_Components.ChartOrdersForMonth chartOrdersForMonth1;
        private System.Windows.Forms.Label panelNewOrder_title;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblTitle_TopPanel;
        private Orders_Components.bestProduct bestProduct1;
        private System.Windows.Forms.PictureBox invoicesPanel_picture;
        private System.Windows.Forms.Button invoicesPanel_button;
        private System.Windows.Forms.Label invocesPanel_title;
    }
}
