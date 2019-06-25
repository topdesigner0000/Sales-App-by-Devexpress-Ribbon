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
            DevExpress.XtraCharts.Pie3DSeriesView pie3DSeriesView2 = new DevExpress.XtraCharts.Pie3DSeriesView();
            this.list_item = new DevExpress.XtraEditors.ListBoxControl();
            this.ctl_calendar = new DevExpress.XtraEditors.Controls.CalendarControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.item_chart = new DevExpress.XtraCharts.ChartControl();
            ((System.ComponentModel.ISupportInitialize)(this.list_item)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctl_calendar.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.item_chart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(pie3DSeriesView2)).BeginInit();
            this.SuspendLayout();
            // 
            // list_item
            // 
            this.list_item.Cursor = System.Windows.Forms.Cursors.Default;
            this.list_item.Location = new System.Drawing.Point(0, 0);
            this.list_item.Name = "list_item";
            this.list_item.Size = new System.Drawing.Size(232, 348);
            this.list_item.TabIndex = 0;
            this.list_item.SelectedIndexChanged += new System.EventHandler(this.list_item_SelectedIndexChanged);
            // 
            // ctl_calendar
            // 
            this.ctl_calendar.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ctl_calendar.Location = new System.Drawing.Point(0, 347);
            this.ctl_calendar.Name = "ctl_calendar";
            this.ctl_calendar.Size = new System.Drawing.Size(232, 227);
            this.ctl_calendar.TabIndex = 2;
            this.ctl_calendar.SelectionChanged += new System.EventHandler(this.ctl_calendar_SelectionChanged);
            // 
            // groupControl1
            // 
            this.groupControl1.AutoSize = true;
            this.groupControl1.Controls.Add(this.item_chart);
            this.groupControl1.Controls.Add(this.ctl_calendar);
            this.groupControl1.Controls.Add(this.list_item);
            this.groupControl1.Location = new System.Drawing.Point(12, 12);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.ShowCaption = false;
            this.groupControl1.Size = new System.Drawing.Size(779, 577);
            this.groupControl1.TabIndex = 0;
            // 
            // item_chart
            // 
            this.item_chart.Legend.Name = "Default Legend";
            this.item_chart.Location = new System.Drawing.Point(233, 2);
            this.item_chart.Name = "item_chart";
            this.item_chart.SeriesSerializable = new DevExpress.XtraCharts.Series[0];
            this.item_chart.SeriesTemplate.View = pie3DSeriesView2;
            this.item_chart.Size = new System.Drawing.Size(543, 572);
            this.item_chart.TabIndex = 3;
            // 
            // ItemChartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 591);
            this.Controls.Add(this.groupControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ItemChartForm";
            this.Text = "ChartView-Product";
            this.Load += new System.EventHandler(this.ItemChartForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.list_item)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctl_calendar.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(pie3DSeriesView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.item_chart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private DevExpress.XtraEditors.ListBoxControl list_item;
        private DevExpress.XtraEditors.Controls.CalendarControl ctl_calendar;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraCharts.ChartControl item_chart;
    }
}