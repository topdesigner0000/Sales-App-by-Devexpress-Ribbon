namespace SalesManagement
{
    partial class ManChartForm
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
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.man_chart = new DevExpress.XtraCharts.ChartControl();
            this.list_man = new DevExpress.XtraEditors.ListBoxControl();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.man_chart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.list_man)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.AutoSize = true;
            this.groupControl1.Controls.Add(this.man_chart);
            this.groupControl1.Controls.Add(this.list_man);
            this.groupControl1.Location = new System.Drawing.Point(4, 10);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(676, 257);
            this.groupControl1.TabIndex = 1;
            // 
            // man_chart
            // 
            this.man_chart.Legend.Name = "Default Legend";
            this.man_chart.Location = new System.Drawing.Point(296, 35);
            this.man_chart.Name = "man_chart";
            this.man_chart.SeriesSerializable = new DevExpress.XtraCharts.Series[0];
            this.man_chart.Size = new System.Drawing.Size(300, 200);
            this.man_chart.TabIndex = 1;
            // 
            // list_man
            // 
            this.list_man.Cursor = System.Windows.Forms.Cursors.Default;
            this.list_man.Location = new System.Drawing.Point(40, 23);
            this.list_man.Name = "list_man";
            this.list_man.Size = new System.Drawing.Size(157, 229);
            this.list_man.TabIndex = 0;
            // 
            // ManChartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 283);
            this.Controls.Add(this.groupControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ManChartForm";
            this.Text = "ChartView-SalesMan";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.man_chart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.list_man)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraCharts.ChartControl man_chart;
        private DevExpress.XtraEditors.ListBoxControl list_man;
    }
}