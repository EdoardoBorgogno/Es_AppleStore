namespace AppleStore.Components.Home.Home_Components
{
    partial class ChartOrders
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
            this.revenueChart = new LiveCharts.WinForms.CartesianChart();
            this.lblTitleChart = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // revenueChart
            // 
            this.revenueChart.Location = new System.Drawing.Point(16, 63);
            this.revenueChart.Name = "revenueChart";
            this.revenueChart.Size = new System.Drawing.Size(450, 226);
            this.revenueChart.TabIndex = 0;
            this.revenueChart.Text = "cartesianChart1";
            // 
            // lblTitleChart
            // 
            this.lblTitleChart.AutoSize = true;
            this.lblTitleChart.Font = new System.Drawing.Font("Dubai", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleChart.Location = new System.Drawing.Point(17, 17);
            this.lblTitleChart.Name = "lblTitleChart";
            this.lblTitleChart.Size = new System.Drawing.Size(97, 34);
            this.lblTitleChart.TabIndex = 1;
            this.lblTitleChart.Text = "Chart title";
            // 
            // ChartOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lblTitleChart);
            this.Controls.Add(this.revenueChart);
            this.Name = "ChartOrders";
            this.Size = new System.Drawing.Size(504, 325);
            this.Load += new System.EventHandler(this.ChartOrders_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private LiveCharts.WinForms.CartesianChart revenueChart;
        private System.Windows.Forms.Label lblTitleChart;
    }
}
