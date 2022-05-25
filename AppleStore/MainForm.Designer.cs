namespace AppleStore
{
    partial class MainForm
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

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.leftPanel = new System.Windows.Forms.Panel();
            this.panelLeft_appleImage = new System.Windows.Forms.PictureBox();
            this.leftPanel_bottomContainer = new System.Windows.Forms.Panel();
            this.leftPanel_bottomContainer_button = new System.Windows.Forms.Button();
            this.leftPanel_bottomContainer_title = new System.Windows.Forms.Label();
            this.leftPanel_bottomContainer_image = new System.Windows.Forms.PictureBox();
            this.panelLeft_dashboardButton = new System.Windows.Forms.Button();
            this.panelLeft_salesButton = new System.Windows.Forms.Button();
            this.panelLeft_registryButton = new System.Windows.Forms.Button();
            this.panelLeft_homeButton = new System.Windows.Forms.Button();
            this.topPanel = new System.Windows.Forms.Panel();
            this.exitBtn = new System.Windows.Forms.Label();
            this.panelTop_btnReport = new AppleStore.RoundButton();
            this.panelTop_btnConnection = new AppleStore.RoundButton();
            this.panelTop_btnProduct = new AppleStore.RoundButton();
            this.home1 = new AppleStore.Home();
            this.leftPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelLeft_appleImage)).BeginInit();
            this.leftPanel_bottomContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.leftPanel_bottomContainer_image)).BeginInit();
            this.topPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // leftPanel
            // 
            this.leftPanel.BackColor = System.Drawing.Color.White;
            this.leftPanel.Controls.Add(this.panelLeft_appleImage);
            this.leftPanel.Controls.Add(this.leftPanel_bottomContainer);
            this.leftPanel.Controls.Add(this.panelLeft_dashboardButton);
            this.leftPanel.Controls.Add(this.panelLeft_salesButton);
            this.leftPanel.Controls.Add(this.panelLeft_registryButton);
            this.leftPanel.Controls.Add(this.panelLeft_homeButton);
            this.leftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftPanel.Location = new System.Drawing.Point(0, 0);
            this.leftPanel.Name = "leftPanel";
            this.leftPanel.Size = new System.Drawing.Size(225, 650);
            this.leftPanel.TabIndex = 0;
            // 
            // panelLeft_appleImage
            // 
            this.panelLeft_appleImage.Image = global::AppleStore.Properties.Resources.apple;
            this.panelLeft_appleImage.Location = new System.Drawing.Point(15, 12);
            this.panelLeft_appleImage.Name = "panelLeft_appleImage";
            this.panelLeft_appleImage.Size = new System.Drawing.Size(80, 82);
            this.panelLeft_appleImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.panelLeft_appleImage.TabIndex = 6;
            this.panelLeft_appleImage.TabStop = false;
            // 
            // leftPanel_bottomContainer
            // 
            this.leftPanel_bottomContainer.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.leftPanel_bottomContainer.Controls.Add(this.leftPanel_bottomContainer_button);
            this.leftPanel_bottomContainer.Controls.Add(this.leftPanel_bottomContainer_title);
            this.leftPanel_bottomContainer.Controls.Add(this.leftPanel_bottomContainer_image);
            this.leftPanel_bottomContainer.Location = new System.Drawing.Point(12, 532);
            this.leftPanel_bottomContainer.Name = "leftPanel_bottomContainer";
            this.leftPanel_bottomContainer.Size = new System.Drawing.Size(193, 99);
            this.leftPanel_bottomContainer.TabIndex = 5;
            // 
            // leftPanel_bottomContainer_button
            // 
            this.leftPanel_bottomContainer_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.leftPanel_bottomContainer_button.Font = new System.Drawing.Font("Dubai", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.leftPanel_bottomContainer_button.ForeColor = System.Drawing.Color.White;
            this.leftPanel_bottomContainer_button.Location = new System.Drawing.Point(70, 59);
            this.leftPanel_bottomContainer_button.Name = "leftPanel_bottomContainer_button";
            this.leftPanel_bottomContainer_button.Size = new System.Drawing.Size(106, 28);
            this.leftPanel_bottomContainer_button.TabIndex = 2;
            this.leftPanel_bottomContainer_button.Text = "Vai ai Report";
            this.leftPanel_bottomContainer_button.UseVisualStyleBackColor = true;
            // 
            // leftPanel_bottomContainer_title
            // 
            this.leftPanel_bottomContainer_title.AutoSize = true;
            this.leftPanel_bottomContainer_title.Font = new System.Drawing.Font("Dubai", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.leftPanel_bottomContainer_title.ForeColor = System.Drawing.Color.White;
            this.leftPanel_bottomContainer_title.Location = new System.Drawing.Point(60, 12);
            this.leftPanel_bottomContainer_title.Name = "leftPanel_bottomContainer_title";
            this.leftPanel_bottomContainer_title.Size = new System.Drawing.Size(116, 30);
            this.leftPanel_bottomContainer_title.TabIndex = 1;
            this.leftPanel_bottomContainer_title.Text = "Scopri i report";
            // 
            // leftPanel_bottomContainer_image
            // 
            this.leftPanel_bottomContainer_image.Image = global::AppleStore.Properties.Resources.report;
            this.leftPanel_bottomContainer_image.Location = new System.Drawing.Point(3, 3);
            this.leftPanel_bottomContainer_image.Name = "leftPanel_bottomContainer_image";
            this.leftPanel_bottomContainer_image.Size = new System.Drawing.Size(51, 48);
            this.leftPanel_bottomContainer_image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.leftPanel_bottomContainer_image.TabIndex = 0;
            this.leftPanel_bottomContainer_image.TabStop = false;
            // 
            // panelLeft_dashboardButton
            // 
            this.panelLeft_dashboardButton.FlatAppearance.BorderSize = 0;
            this.panelLeft_dashboardButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.panelLeft_dashboardButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.panelLeft_dashboardButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.panelLeft_dashboardButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.panelLeft_dashboardButton.Font = new System.Drawing.Font("Dubai", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelLeft_dashboardButton.ForeColor = System.Drawing.Color.DarkGray;
            this.panelLeft_dashboardButton.Image = global::AppleStore.Properties.Resources.dashboard;
            this.panelLeft_dashboardButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.panelLeft_dashboardButton.Location = new System.Drawing.Point(22, 373);
            this.panelLeft_dashboardButton.Name = "panelLeft_dashboardButton";
            this.panelLeft_dashboardButton.Size = new System.Drawing.Size(208, 35);
            this.panelLeft_dashboardButton.TabIndex = 4;
            this.panelLeft_dashboardButton.Text = "            Dashboard";
            this.panelLeft_dashboardButton.UseVisualStyleBackColor = true;
            // 
            // panelLeft_salesButton
            // 
            this.panelLeft_salesButton.FlatAppearance.BorderSize = 0;
            this.panelLeft_salesButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.panelLeft_salesButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.panelLeft_salesButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.panelLeft_salesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.panelLeft_salesButton.Font = new System.Drawing.Font("Dubai", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelLeft_salesButton.ForeColor = System.Drawing.Color.DarkGray;
            this.panelLeft_salesButton.Image = global::AppleStore.Properties.Resources.sales;
            this.panelLeft_salesButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.panelLeft_salesButton.Location = new System.Drawing.Point(22, 301);
            this.panelLeft_salesButton.Name = "panelLeft_salesButton";
            this.panelLeft_salesButton.Size = new System.Drawing.Size(208, 41);
            this.panelLeft_salesButton.TabIndex = 3;
            this.panelLeft_salesButton.Text = "             Vendite      ";
            this.panelLeft_salesButton.UseVisualStyleBackColor = true;
            // 
            // panelLeft_registryButton
            // 
            this.panelLeft_registryButton.FlatAppearance.BorderSize = 0;
            this.panelLeft_registryButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.panelLeft_registryButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.panelLeft_registryButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.panelLeft_registryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.panelLeft_registryButton.Font = new System.Drawing.Font("Dubai", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelLeft_registryButton.ForeColor = System.Drawing.Color.DarkGray;
            this.panelLeft_registryButton.Image = global::AppleStore.Properties.Resources.registry;
            this.panelLeft_registryButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.panelLeft_registryButton.Location = new System.Drawing.Point(22, 234);
            this.panelLeft_registryButton.Name = "panelLeft_registryButton";
            this.panelLeft_registryButton.Size = new System.Drawing.Size(193, 39);
            this.panelLeft_registryButton.TabIndex = 1;
            this.panelLeft_registryButton.Text = "             Anagrafica";
            this.panelLeft_registryButton.UseVisualStyleBackColor = true;
            // 
            // panelLeft_homeButton
            // 
            this.panelLeft_homeButton.FlatAppearance.BorderSize = 0;
            this.panelLeft_homeButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.panelLeft_homeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.panelLeft_homeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.panelLeft_homeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.panelLeft_homeButton.Font = new System.Drawing.Font("Dubai", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelLeft_homeButton.ForeColor = System.Drawing.Color.DarkGray;
            this.panelLeft_homeButton.Image = ((System.Drawing.Image)(resources.GetObject("panelLeft_homeButton.Image")));
            this.panelLeft_homeButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.panelLeft_homeButton.Location = new System.Drawing.Point(22, 175);
            this.panelLeft_homeButton.Name = "panelLeft_homeButton";
            this.panelLeft_homeButton.Size = new System.Drawing.Size(164, 41);
            this.panelLeft_homeButton.TabIndex = 0;
            this.panelLeft_homeButton.Text = "             Home";
            this.panelLeft_homeButton.UseVisualStyleBackColor = true;
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.White;
            this.topPanel.Controls.Add(this.exitBtn);
            this.topPanel.Controls.Add(this.panelTop_btnReport);
            this.topPanel.Controls.Add(this.panelTop_btnConnection);
            this.topPanel.Controls.Add(this.panelTop_btnProduct);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(225, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(785, 53);
            this.topPanel.TabIndex = 1;
            this.topPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.topPanel_MouseDown);
            this.topPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.topPanel_MouseMove);
            this.topPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.topPanel_MouseUp);
            // 
            // exitBtn
            // 
            this.exitBtn.AutoSize = true;
            this.exitBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exitBtn.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitBtn.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.exitBtn.Location = new System.Drawing.Point(742, 5);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(40, 41);
            this.exitBtn.TabIndex = 5;
            this.exitBtn.Text = "X";
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // panelTop_btnReport
            // 
            this.panelTop_btnReport.BackColor = System.Drawing.Color.MediumPurple;
            this.panelTop_btnReport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelTop_btnReport.FlatAppearance.BorderSize = 0;
            this.panelTop_btnReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.panelTop_btnReport.ForeColor = System.Drawing.Color.White;
            this.panelTop_btnReport.Image = global::AppleStore.Properties.Resources.report;
            this.panelTop_btnReport.Location = new System.Drawing.Point(84, 7);
            this.panelTop_btnReport.Name = "panelTop_btnReport";
            this.panelTop_btnReport.Size = new System.Drawing.Size(44, 39);
            this.panelTop_btnReport.TabIndex = 4;
            this.panelTop_btnReport.UseVisualStyleBackColor = false;
            // 
            // panelTop_btnConnection
            // 
            this.panelTop_btnConnection.BackColor = System.Drawing.Color.MediumPurple;
            this.panelTop_btnConnection.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelTop_btnConnection.FlatAppearance.BorderSize = 0;
            this.panelTop_btnConnection.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.panelTop_btnConnection.ForeColor = System.Drawing.Color.White;
            this.panelTop_btnConnection.Image = global::AppleStore.Properties.Resources.web_connection;
            this.panelTop_btnConnection.Location = new System.Drawing.Point(18, 7);
            this.panelTop_btnConnection.Name = "panelTop_btnConnection";
            this.panelTop_btnConnection.Size = new System.Drawing.Size(44, 39);
            this.panelTop_btnConnection.TabIndex = 3;
            this.panelTop_btnConnection.UseVisualStyleBackColor = false;
            // 
            // panelTop_btnProduct
            // 
            this.panelTop_btnProduct.BackColor = System.Drawing.Color.MediumPurple;
            this.panelTop_btnProduct.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelTop_btnProduct.FlatAppearance.BorderSize = 0;
            this.panelTop_btnProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.panelTop_btnProduct.ForeColor = System.Drawing.Color.White;
            this.panelTop_btnProduct.Image = global::AppleStore.Properties.Resources.ui;
            this.panelTop_btnProduct.Location = new System.Drawing.Point(145, 7);
            this.panelTop_btnProduct.Name = "panelTop_btnProduct";
            this.panelTop_btnProduct.Size = new System.Drawing.Size(44, 39);
            this.panelTop_btnProduct.TabIndex = 2;
            this.panelTop_btnProduct.UseVisualStyleBackColor = false;
            // 
            // home1
            // 
            this.home1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.home1.Location = new System.Drawing.Point(225, 52);
            this.home1.Name = "home1";
            this.home1.Size = new System.Drawing.Size(784, 597);
            this.home1.TabIndex = 2;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1010, 650);
            this.Controls.Add(this.home1);
            this.Controls.Add(this.topPanel);
            this.Controls.Add(this.leftPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.leftPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelLeft_appleImage)).EndInit();
            this.leftPanel_bottomContainer.ResumeLayout(false);
            this.leftPanel_bottomContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.leftPanel_bottomContainer_image)).EndInit();
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel leftPanel;
        private System.Windows.Forms.Button panelLeft_registryButton;
        private System.Windows.Forms.Button panelLeft_homeButton;
        private System.Windows.Forms.Button panelLeft_salesButton;
        private System.Windows.Forms.Button panelLeft_dashboardButton;
        private System.Windows.Forms.Panel leftPanel_bottomContainer;
        private System.Windows.Forms.Button leftPanel_bottomContainer_button;
        private System.Windows.Forms.Label leftPanel_bottomContainer_title;
        private System.Windows.Forms.PictureBox leftPanel_bottomContainer_image;
        private System.Windows.Forms.PictureBox panelLeft_appleImage;
        private System.Windows.Forms.Panel topPanel;
        private RoundButton panelTop_btnReport;
        private RoundButton panelTop_btnConnection;
        private RoundButton panelTop_btnProduct;
        private System.Windows.Forms.Label exitBtn;
        private Home home1;
    }
}

