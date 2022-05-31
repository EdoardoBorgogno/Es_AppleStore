namespace AppleStore
{
    partial class Home
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
            this.Home_toPanel_products = new System.Windows.Forms.Panel();
            this.Home_toPanel_products_image = new System.Windows.Forms.PictureBox();
            this.Home_toPanel_products_numOfProducts = new System.Windows.Forms.Label();
            this.Home_toPanel_products_title = new System.Windows.Forms.Label();
            this.Home_toPanel_orders = new System.Windows.Forms.Panel();
            this.Home_toPanel_orders_image = new System.Windows.Forms.PictureBox();
            this.Home_toPanel_orders_numOfOrders = new System.Windows.Forms.Label();
            this.Home_toPanel_orders_title = new System.Windows.Forms.Label();
            this.Home_toPanel_customers = new System.Windows.Forms.Panel();
            this.Home_toPanel_customers_image = new System.Windows.Forms.PictureBox();
            this.Home_toPanel_customers_numOfCustomers = new System.Windows.Forms.Label();
            this.Home_toPanel_customers_title = new System.Windows.Forms.Label();
            this.chartOrders1 = new AppleStore.Components.Home.Home_Components.ChartOrders();
            this.analyticsMonth1 = new AppleStore.Components.Home.Home_Components.analyticsMonth();
            this.Home_ManageData = new System.Windows.Forms.Panel();
            this.Home_ManageData_button = new System.Windows.Forms.Button();
            this.Home_ManageData_title = new System.Windows.Forms.Label();
            this.panelOrders = new System.Windows.Forms.Panel();
            this.panelOrders_button = new System.Windows.Forms.Button();
            this.panelOrders_picture = new System.Windows.Forms.PictureBox();
            this.Home_toPanel_products.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Home_toPanel_products_image)).BeginInit();
            this.Home_toPanel_orders.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Home_toPanel_orders_image)).BeginInit();
            this.Home_toPanel_customers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Home_toPanel_customers_image)).BeginInit();
            this.Home_ManageData.SuspendLayout();
            this.panelOrders.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelOrders_picture)).BeginInit();
            this.SuspendLayout();
            // 
            // Home_toPanel_products
            // 
            this.Home_toPanel_products.BackColor = System.Drawing.Color.White;
            this.Home_toPanel_products.Controls.Add(this.Home_toPanel_products_image);
            this.Home_toPanel_products.Controls.Add(this.Home_toPanel_products_numOfProducts);
            this.Home_toPanel_products.Controls.Add(this.Home_toPanel_products_title);
            this.Home_toPanel_products.Location = new System.Drawing.Point(528, 166);
            this.Home_toPanel_products.Name = "Home_toPanel_products";
            this.Home_toPanel_products.Size = new System.Drawing.Size(241, 112);
            this.Home_toPanel_products.TabIndex = 6;
            // 
            // Home_toPanel_products_image
            // 
            this.Home_toPanel_products_image.Image = global::AppleStore.Properties.Resources.item;
            this.Home_toPanel_products_image.Location = new System.Drawing.Point(167, 39);
            this.Home_toPanel_products_image.Name = "Home_toPanel_products_image";
            this.Home_toPanel_products_image.Size = new System.Drawing.Size(59, 55);
            this.Home_toPanel_products_image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Home_toPanel_products_image.TabIndex = 3;
            this.Home_toPanel_products_image.TabStop = false;
            // 
            // Home_toPanel_products_numOfProducts
            // 
            this.Home_toPanel_products_numOfProducts.AutoSize = true;
            this.Home_toPanel_products_numOfProducts.Font = new System.Drawing.Font("Dubai", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Home_toPanel_products_numOfProducts.ForeColor = System.Drawing.Color.Gray;
            this.Home_toPanel_products_numOfProducts.Location = new System.Drawing.Point(4, 39);
            this.Home_toPanel_products_numOfProducts.Name = "Home_toPanel_products_numOfProducts";
            this.Home_toPanel_products_numOfProducts.Size = new System.Drawing.Size(58, 48);
            this.Home_toPanel_products_numOfProducts.TabIndex = 3;
            this.Home_toPanel_products_numOfProducts.Text = "NN";
            // 
            // Home_toPanel_products_title
            // 
            this.Home_toPanel_products_title.AutoSize = true;
            this.Home_toPanel_products_title.Font = new System.Drawing.Font("Dubai", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Home_toPanel_products_title.ForeColor = System.Drawing.Color.DarkGray;
            this.Home_toPanel_products_title.Location = new System.Drawing.Point(4, 10);
            this.Home_toPanel_products_title.Name = "Home_toPanel_products_title";
            this.Home_toPanel_products_title.Size = new System.Drawing.Size(177, 29);
            this.Home_toPanel_products_title.TabIndex = 3;
            this.Home_toPanel_products_title.Text = "Numero totale prodotti";
            // 
            // Home_toPanel_orders
            // 
            this.Home_toPanel_orders.BackColor = System.Drawing.Color.White;
            this.Home_toPanel_orders.Controls.Add(this.Home_toPanel_orders_image);
            this.Home_toPanel_orders.Controls.Add(this.Home_toPanel_orders_numOfOrders);
            this.Home_toPanel_orders.Controls.Add(this.Home_toPanel_orders_title);
            this.Home_toPanel_orders.Location = new System.Drawing.Point(528, 30);
            this.Home_toPanel_orders.Name = "Home_toPanel_orders";
            this.Home_toPanel_orders.Size = new System.Drawing.Size(241, 112);
            this.Home_toPanel_orders.TabIndex = 5;
            // 
            // Home_toPanel_orders_image
            // 
            this.Home_toPanel_orders_image.Image = global::AppleStore.Properties.Resources.orders;
            this.Home_toPanel_orders_image.Location = new System.Drawing.Point(164, 39);
            this.Home_toPanel_orders_image.Name = "Home_toPanel_orders_image";
            this.Home_toPanel_orders_image.Size = new System.Drawing.Size(59, 55);
            this.Home_toPanel_orders_image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Home_toPanel_orders_image.TabIndex = 4;
            this.Home_toPanel_orders_image.TabStop = false;
            // 
            // Home_toPanel_orders_numOfOrders
            // 
            this.Home_toPanel_orders_numOfOrders.AutoSize = true;
            this.Home_toPanel_orders_numOfOrders.Font = new System.Drawing.Font("Dubai", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Home_toPanel_orders_numOfOrders.ForeColor = System.Drawing.Color.Gray;
            this.Home_toPanel_orders_numOfOrders.Location = new System.Drawing.Point(3, 39);
            this.Home_toPanel_orders_numOfOrders.Name = "Home_toPanel_orders_numOfOrders";
            this.Home_toPanel_orders_numOfOrders.Size = new System.Drawing.Size(58, 48);
            this.Home_toPanel_orders_numOfOrders.TabIndex = 4;
            this.Home_toPanel_orders_numOfOrders.Text = "NN";
            // 
            // Home_toPanel_orders_title
            // 
            this.Home_toPanel_orders_title.AutoSize = true;
            this.Home_toPanel_orders_title.Font = new System.Drawing.Font("Dubai", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Home_toPanel_orders_title.ForeColor = System.Drawing.Color.DarkGray;
            this.Home_toPanel_orders_title.Location = new System.Drawing.Point(3, 10);
            this.Home_toPanel_orders_title.Name = "Home_toPanel_orders_title";
            this.Home_toPanel_orders_title.Size = new System.Drawing.Size(118, 29);
            this.Home_toPanel_orders_title.TabIndex = 4;
            this.Home_toPanel_orders_title.Text = "Numero Ordini";
            // 
            // Home_toPanel_customers
            // 
            this.Home_toPanel_customers.BackColor = System.Drawing.Color.White;
            this.Home_toPanel_customers.Controls.Add(this.Home_toPanel_customers_image);
            this.Home_toPanel_customers.Controls.Add(this.Home_toPanel_customers_numOfCustomers);
            this.Home_toPanel_customers.Controls.Add(this.Home_toPanel_customers_title);
            this.Home_toPanel_customers.Location = new System.Drawing.Point(528, 301);
            this.Home_toPanel_customers.Name = "Home_toPanel_customers";
            this.Home_toPanel_customers.Size = new System.Drawing.Size(241, 112);
            this.Home_toPanel_customers.TabIndex = 4;
            // 
            // Home_toPanel_customers_image
            // 
            this.Home_toPanel_customers_image.Image = global::AppleStore.Properties.Resources.customers;
            this.Home_toPanel_customers_image.Location = new System.Drawing.Point(165, 39);
            this.Home_toPanel_customers_image.Name = "Home_toPanel_customers_image";
            this.Home_toPanel_customers_image.Size = new System.Drawing.Size(59, 55);
            this.Home_toPanel_customers_image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Home_toPanel_customers_image.TabIndex = 2;
            this.Home_toPanel_customers_image.TabStop = false;
            // 
            // Home_toPanel_customers_numOfCustomers
            // 
            this.Home_toPanel_customers_numOfCustomers.AutoSize = true;
            this.Home_toPanel_customers_numOfCustomers.Font = new System.Drawing.Font("Dubai", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Home_toPanel_customers_numOfCustomers.ForeColor = System.Drawing.Color.Gray;
            this.Home_toPanel_customers_numOfCustomers.Location = new System.Drawing.Point(3, 39);
            this.Home_toPanel_customers_numOfCustomers.Name = "Home_toPanel_customers_numOfCustomers";
            this.Home_toPanel_customers_numOfCustomers.Size = new System.Drawing.Size(58, 48);
            this.Home_toPanel_customers_numOfCustomers.TabIndex = 1;
            this.Home_toPanel_customers_numOfCustomers.Text = "NN";
            // 
            // Home_toPanel_customers_title
            // 
            this.Home_toPanel_customers_title.AutoSize = true;
            this.Home_toPanel_customers_title.Font = new System.Drawing.Font("Dubai", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Home_toPanel_customers_title.ForeColor = System.Drawing.Color.DarkGray;
            this.Home_toPanel_customers_title.Location = new System.Drawing.Point(3, 10);
            this.Home_toPanel_customers_title.Name = "Home_toPanel_customers_title";
            this.Home_toPanel_customers_title.Size = new System.Drawing.Size(116, 29);
            this.Home_toPanel_customers_title.TabIndex = 0;
            this.Home_toPanel_customers_title.Text = "Numero clienti";
            // 
            // chartOrders1
            // 
            this.chartOrders1.BackColor = System.Drawing.Color.White;
            this.chartOrders1.Location = new System.Drawing.Point(13, 40);
            this.chartOrders1.Name = "chartOrders1";
            this.chartOrders1.Size = new System.Drawing.Size(499, 314);
            this.chartOrders1.TabIndex = 7;
            // 
            // analyticsMonth1
            // 
            this.analyticsMonth1.BackColor = System.Drawing.Color.White;
            this.analyticsMonth1.Location = new System.Drawing.Point(13, 381);
            this.analyticsMonth1.Name = "analyticsMonth1";
            this.analyticsMonth1.Size = new System.Drawing.Size(290, 132);
            this.analyticsMonth1.TabIndex = 8;
            // 
            // Home_ManageData
            // 
            this.Home_ManageData.BackColor = System.Drawing.Color.White;
            this.Home_ManageData.Controls.Add(this.Home_ManageData_button);
            this.Home_ManageData.Controls.Add(this.Home_ManageData_title);
            this.Home_ManageData.Location = new System.Drawing.Point(528, 440);
            this.Home_ManageData.Name = "Home_ManageData";
            this.Home_ManageData.Size = new System.Drawing.Size(241, 112);
            this.Home_ManageData.TabIndex = 5;
            // 
            // Home_ManageData_button
            // 
            this.Home_ManageData_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Home_ManageData_button.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.Home_ManageData_button.Location = new System.Drawing.Point(53, 64);
            this.Home_ManageData_button.Name = "Home_ManageData_button";
            this.Home_ManageData_button.Size = new System.Drawing.Size(138, 31);
            this.Home_ManageData_button.TabIndex = 4;
            this.Home_ManageData_button.Text = "Gestisci";
            this.Home_ManageData_button.UseVisualStyleBackColor = true;
            this.Home_ManageData_button.Click += new System.EventHandler(this.Home_ManageData_button_Click);
            // 
            // Home_ManageData_title
            // 
            this.Home_ManageData_title.AutoSize = true;
            this.Home_ManageData_title.Font = new System.Drawing.Font("Dubai", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Home_ManageData_title.ForeColor = System.Drawing.Color.DarkGray;
            this.Home_ManageData_title.Location = new System.Drawing.Point(57, 15);
            this.Home_ManageData_title.Name = "Home_ManageData_title";
            this.Home_ManageData_title.Size = new System.Drawing.Size(131, 29);
            this.Home_ManageData_title.TabIndex = 3;
            this.Home_ManageData_title.Text = "Gestici i tuoi dati";
            // 
            // panelOrders
            // 
            this.panelOrders.BackColor = System.Drawing.Color.White;
            this.panelOrders.Controls.Add(this.panelOrders_button);
            this.panelOrders.Controls.Add(this.panelOrders_picture);
            this.panelOrders.Location = new System.Drawing.Point(325, 381);
            this.panelOrders.Name = "panelOrders";
            this.panelOrders.Size = new System.Drawing.Size(186, 170);
            this.panelOrders.TabIndex = 9;
            // 
            // panelOrders_button
            // 
            this.panelOrders_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.panelOrders_button.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.panelOrders_button.Location = new System.Drawing.Point(24, 125);
            this.panelOrders_button.Name = "panelOrders_button";
            this.panelOrders_button.Size = new System.Drawing.Size(138, 31);
            this.panelOrders_button.TabIndex = 5;
            this.panelOrders_button.Text = "Vai alle vendite";
            this.panelOrders_button.UseVisualStyleBackColor = true;
            this.panelOrders_button.Click += new System.EventHandler(this.panelOrders_button_Click);
            // 
            // panelOrders_picture
            // 
            this.panelOrders_picture.BackColor = System.Drawing.Color.Transparent;
            this.panelOrders_picture.Image = global::AppleStore.Properties.Resources.orders_box;
            this.panelOrders_picture.Location = new System.Drawing.Point(27, 3);
            this.panelOrders_picture.Name = "panelOrders_picture";
            this.panelOrders_picture.Size = new System.Drawing.Size(130, 110);
            this.panelOrders_picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.panelOrders_picture.TabIndex = 0;
            this.panelOrders_picture.TabStop = false;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.panelOrders);
            this.Controls.Add(this.Home_ManageData);
            this.Controls.Add(this.analyticsMonth1);
            this.Controls.Add(this.chartOrders1);
            this.Controls.Add(this.Home_toPanel_products);
            this.Controls.Add(this.Home_toPanel_orders);
            this.Controls.Add(this.Home_toPanel_customers);
            this.Name = "Home";
            this.Size = new System.Drawing.Size(784, 597);
            this.Load += new System.EventHandler(this.Home_Load);
            this.Home_toPanel_products.ResumeLayout(false);
            this.Home_toPanel_products.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Home_toPanel_products_image)).EndInit();
            this.Home_toPanel_orders.ResumeLayout(false);
            this.Home_toPanel_orders.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Home_toPanel_orders_image)).EndInit();
            this.Home_toPanel_customers.ResumeLayout(false);
            this.Home_toPanel_customers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Home_toPanel_customers_image)).EndInit();
            this.Home_ManageData.ResumeLayout(false);
            this.Home_ManageData.PerformLayout();
            this.panelOrders.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelOrders_picture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Home_toPanel_products;
        private System.Windows.Forms.Panel Home_toPanel_orders;
        private System.Windows.Forms.Panel Home_toPanel_customers;
        private System.Windows.Forms.Label Home_toPanel_customers_title;
        private System.Windows.Forms.Label Home_toPanel_customers_numOfCustomers;
        private System.Windows.Forms.PictureBox Home_toPanel_customers_image;
        private System.Windows.Forms.Label Home_toPanel_products_numOfProducts;
        private System.Windows.Forms.Label Home_toPanel_products_title;
        private System.Windows.Forms.PictureBox Home_toPanel_products_image;
        private System.Windows.Forms.Label Home_toPanel_orders_numOfOrders;
        private System.Windows.Forms.Label Home_toPanel_orders_title;
        private System.Windows.Forms.PictureBox Home_toPanel_orders_image;
        private Components.Home.Home_Components.ChartOrders chartOrders1;
        private Components.Home.Home_Components.analyticsMonth analyticsMonth1;
        private System.Windows.Forms.Panel Home_ManageData;
        private System.Windows.Forms.Label Home_ManageData_title;
        private System.Windows.Forms.Button Home_ManageData_button;
        private System.Windows.Forms.Panel panelOrders;
        private System.Windows.Forms.Button panelOrders_button;
        private System.Windows.Forms.PictureBox panelOrders_picture;
    }
}
