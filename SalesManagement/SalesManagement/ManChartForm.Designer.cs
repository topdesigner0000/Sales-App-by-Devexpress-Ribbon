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
            DevExpress.XtraCharts.Pie3DSeriesView pie3DSeriesView1 = new DevExpress.XtraCharts.Pie3DSeriesView();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManChartForm));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.man_chart = new DevExpress.XtraCharts.ChartControl();
            this.ctl_man_calendar = new DevExpress.XtraEditors.Controls.CalendarControl();
            this.list_man = new DevExpress.XtraEditors.ListBoxControl();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.man_chart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(pie3DSeriesView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctl_man_calendar.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.list_man)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.AutoSize = true;
            this.groupControl1.Controls.Add(this.man_chart);
            this.groupControl1.Controls.Add(this.ctl_man_calendar);
            this.groupControl1.Controls.Add(this.list_man);
            this.groupControl1.Location = new System.Drawing.Point(4, 2);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.ShowCaption = false;
            this.groupControl1.Size = new System.Drawing.Size(779, 577);
            this.groupControl1.TabIndex = 1;
            // 
            // man_chart
            // 
            this.man_chart.Legend.Name = "Default Legend";
            this.man_chart.Location = new System.Drawing.Point(233, 2);
            this.man_chart.Name = "man_chart";
            this.man_chart.SeriesSerializable = new DevExpress.XtraCharts.Series[0];
            this.man_chart.SeriesTemplate.View = pie3DSeriesView1;
            this.man_chart.Size = new System.Drawing.Size(543, 572);
            this.man_chart.TabIndex = 3;
            // 
            // ctl_man_calendar
            // 
            this.ctl_man_calendar.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ctl_man_calendar.DateTime = new System.DateTime(2019, 6, 25, 0, 0, 0, 0);
            this.ctl_man_calendar.EditValue = new System.DateTime(2019, 6, 25, 0, 0, 0, 0);
            this.ctl_man_calendar.Location = new System.Drawing.Point(1, 347);
            this.ctl_man_calendar.Name = "ctl_man_calendar";
            this.ctl_man_calendar.Size = new System.Drawing.Size(244, 227);
            this.ctl_man_calendar.TabIndex = 2;
            this.ctl_man_calendar.SelectionChanged += new System.EventHandler(this.ctl_man_calendar_SelectionChanged);
            // 
            // list_man
            // 
            this.list_man.Cursor = System.Windows.Forms.Cursors.Default;
            this.list_man.Location = new System.Drawing.Point(1, 0);
            this.list_man.Name = "list_man";
            this.list_man.Size = new System.Drawing.Size(232, 348);
            this.list_man.TabIndex = 0;
            this.list_man.SelectedIndexChanged += new System.EventHandler(this.list_man_SelectedIndexChanged);
            // 
            // ManChartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 580);
            this.Controls.Add(this.groupControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ManChartForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChartView-SalesMan";
            this.Load += new System.EventHandler(this.ManChartForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(pie3DSeriesView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.man_chart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctl_man_calendar.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.list_man)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraCharts.ChartControl man_chart;
        private DevExpress.XtraEditors.Controls.CalendarControl ctl_man_calendar;
        private DevExpress.XtraEditors.ListBoxControl list_man;
    }
}