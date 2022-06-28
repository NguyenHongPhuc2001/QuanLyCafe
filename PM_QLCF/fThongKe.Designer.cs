
namespace PM_QLCF
{
    partial class fThongKe
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.cThongKe = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lblThongKe = new System.Windows.Forms.Label();
            this.btnTroVe = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.cThongKe)).BeginInit();
            this.SuspendLayout();
            // 
            // cThongKe
            // 
            chartArea1.Name = "ChartArea1";
            this.cThongKe.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.cThongKe.Legends.Add(legend1);
            this.cThongKe.Location = new System.Drawing.Point(65, 180);
            this.cThongKe.Name = "cThongKe";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.cThongKe.Series.Add(series1);
            this.cThongKe.Size = new System.Drawing.Size(878, 319);
            this.cThongKe.TabIndex = 0;
            this.cThongKe.Text = "chart1";
            // 
            // lblThongKe
            // 
            this.lblThongKe.AutoSize = true;
            this.lblThongKe.Font = new System.Drawing.Font("Lucida Bright", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThongKe.Location = new System.Drawing.Point(398, 28);
            this.lblThongKe.Name = "lblThongKe";
            this.lblThongKe.Size = new System.Drawing.Size(202, 37);
            this.lblThongKe.TabIndex = 2;
            this.lblThongKe.Text = "THỐNG KÊ";
            // 
            // btnTroVe
            // 
            this.btnTroVe.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTroVe.Location = new System.Drawing.Point(12, 12);
            this.btnTroVe.Name = "btnTroVe";
            this.btnTroVe.Size = new System.Drawing.Size(112, 55);
            this.btnTroVe.TabIndex = 3;
            this.btnTroVe.Text = "Trở Về";
            this.btnTroVe.UseVisualStyleBackColor = true;
            // 
            // fThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 555);
            this.Controls.Add(this.btnTroVe);
            this.Controls.Add(this.lblThongKe);
            this.Controls.Add(this.cThongKe);
            this.Name = "fThongKe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fThongKe";
            ((System.ComponentModel.ISupportInitialize)(this.cThongKe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart cThongKe;
        private System.Windows.Forms.Label lblThongKe;
        private System.Windows.Forms.Button btnTroVe;
    }
}