namespace AppleStore.Screens.Dashboard.Dashboard_Components
{
    partial class ChartYear
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
            this.lblTitleChart = new System.Windows.Forms.Label();
            this.revenueChart = new LiveCharts.WinForms.CartesianChart();
            this.SuspendLayout();
            // 
            // lblTitleChart
            // 
            this.lblTitleChart.AutoSize = true;
            this.lblTitleChart.Font = new System.Drawing.Font("Dubai", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleChart.Location = new System.Drawing.Point(16, 20);
            this.lblTitleChart.Name = "lblTitleChart";
            this.lblTitleChart.Size = new System.Drawing.Size(97, 34);
            this.lblTitleChart.TabIndex = 3;
            this.lblTitleChart.Text = "Chart title";
            // 
            // revenueChart
            // 
            this.revenueChart.Location = new System.Drawing.Point(18, 57);
            this.revenueChart.Name = "revenueChart";
            this.revenueChart.Size = new System.Drawing.Size(400, 193);
            this.revenueChart.TabIndex = 2;
            this.revenueChart.Text = "cartesianChart1";
            this.revenueChart.Visible = false;
            // 
            // ChartYear
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lblTitleChart);
            this.Controls.Add(this.revenueChart);
            this.Name = "ChartYear";
            this.Size = new System.Drawing.Size(437, 269);
            this.Load += new System.EventHandler(this.ChartYear_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitleChart;
        private LiveCharts.WinForms.CartesianChart revenueChart;
    }
}
