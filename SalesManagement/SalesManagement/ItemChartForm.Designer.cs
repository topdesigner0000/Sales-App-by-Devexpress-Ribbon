namespace SalesManagement
{
    partial class ItemChartForm
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
            this.item_chart = new DevExpress.XtraCharts.ChartControl();
            this.list_item = new DevExpress.XtraEditors.ListBoxControl();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.item_chart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.list_item)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.AutoSize = true;
            this.groupControl1.Controls.Add(this.item_chart);
            this.groupControl1.Controls.Add(this.list_item);
            this.groupControl1.Location = new System.Drawing.Point(12, 12);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(676, 257);
            this.groupControl1.TabIndex = 0;
            // 
            // item_chart
            // 
            this.item_chart.Legend.Name = "Default Legend";
            this.item_chart.Location = new System.Drawing.Point(296, 35);
            this.item_chart.Name = "item_chart";
            this.item_chart.SeriesSerializable = new DevExpress.XtraCharts.Series[0];
            this.item_chart.Size = new System.Drawing.Size(300, 200);
            this.item_chart.TabIndex = 1;
            // 
            // list_item
            // 
            this.list_item.Cursor = System.Windows.Forms.Cursors.Default;
            this.list_item.Location = new System.Drawing.Point(40, 23);
            this.list_item.Name = "list_item";
            this.list_item.Size = new System.Drawing.Size(157, 229);
            this.list_item.TabIndex = 0;
            // 
            // ItemChartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 280);
            this.Controls.Add(this.groupControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ItemChartForm";
            this.Text = "ChartView-Product";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.item_chart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.list_item)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraCharts.ChartControl item_chart;
        private DevExpress.XtraEditors.ListBoxControl list_item;
    }
}