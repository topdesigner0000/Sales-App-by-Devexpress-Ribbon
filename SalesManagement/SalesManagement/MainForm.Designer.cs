namespace SalesManagement
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btn_item = new DevExpress.XtraBars.BarButtonItem();
            this.btn_man = new DevExpress.XtraBars.BarButtonItem();
            this.btn_item_chart = new DevExpress.XtraBars.BarButtonItem();
            this.btn_man_chart = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage3 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar1 = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.grid_sales = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.field_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.field_name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.field_item1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.field_item2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.field_itemd3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.field_item4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.chk_term4 = new DevExpress.XtraEditors.CheckEdit();
            this.chk_term3 = new DevExpress.XtraEditors.CheckEdit();
            this.chk_term2 = new DevExpress.XtraEditors.CheckEdit();
            this.chk_term1 = new DevExpress.XtraEditors.CheckEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.month_pick = new DevExpress.XtraEditors.Controls.CalendarControl();
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            this.ribbonPageGroup5 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_sales)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chk_term4.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chk_term3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chk_term2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chk_term1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.month_pick.CalendarTimeProperties)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.AllowDrop = true;
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.btn_item,
            this.btn_man,
            this.btn_item_chart,
            this.btn_man_chart,
            this.barButtonItem1});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 6;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1,
            this.ribbonPage3});
            this.ribbonControl1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2013;
            this.ribbonControl1.Size = new System.Drawing.Size(1095, 148);
            this.ribbonControl1.StatusBar = this.ribbonStatusBar1;
            // 
            // btn_item
            // 
            this.btn_item.Caption = "Products";
            this.btn_item.Id = 1;
            this.btn_item.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_item.ImageOptions.Image")));
            this.btn_item.ItemAppearance.Normal.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_item.ItemAppearance.Normal.Options.UseFont = true;
            this.btn_item.Name = "btn_item";
            this.btn_item.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_item_ItemClick);
            // 
            // btn_man
            // 
            this.btn_man.Caption = "SalesMen";
            this.btn_man.Id = 2;
            this.btn_man.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_man.ImageOptions.Image")));
            this.btn_man.ItemAppearance.Normal.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_man.ItemAppearance.Normal.Options.UseFont = true;
            this.btn_man.Name = "btn_man";
            this.btn_man.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_man_ItemClick);
            // 
            // btn_item_chart
            // 
            this.btn_item_chart.Caption = "per Item";
            this.btn_item_chart.Id = 3;
            this.btn_item_chart.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_item_chart.ImageOptions.Image")));
            this.btn_item_chart.ItemAppearance.Normal.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_item_chart.ItemAppearance.Normal.Options.UseFont = true;
            this.btn_item_chart.Name = "btn_item_chart";
            this.btn_item_chart.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_item_chart_ItemClick);
            // 
            // btn_man_chart
            // 
            this.btn_man_chart.Caption = "per Man";
            this.btn_man_chart.Id = 4;
            this.btn_man_chart.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_man_chart.ImageOptions.Image")));
            this.btn_man_chart.ItemAppearance.Normal.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_man_chart.ItemAppearance.Normal.Options.UseFont = true;
            this.btn_man_chart.Name = "btn_man_chart";
            this.btn_man_chart.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_man_chart_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ribbonPage1.Appearance.Options.UseFont = true;
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup2,
            this.ribbonPageGroup5});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Sale";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btn_item);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Products Management";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.btn_man);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "Man Management";
            // 
            // ribbonPage3
            // 
            this.ribbonPage3.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup3,
            this.ribbonPageGroup4});
            this.ribbonPage3.Name = "ribbonPage3";
            this.ribbonPage3.Text = "Statistic";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.btn_item_chart);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Text = "Items";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.ItemLinks.Add(this.btn_man_chart);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            this.ribbonPageGroup4.Text = "SalesMen";
            // 
            // ribbonStatusBar1
            // 
            this.ribbonStatusBar1.Location = new System.Drawing.Point(0, 828);
            this.ribbonStatusBar1.Name = "ribbonStatusBar1";
            this.ribbonStatusBar1.Ribbon = this.ribbonControl1;
            this.ribbonStatusBar1.Size = new System.Drawing.Size(1095, 21);
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "ribbonPage2";
            // 
            // grid_sales
            // 
            this.grid_sales.Location = new System.Drawing.Point(234, 146);
            this.grid_sales.MainView = this.gridView1;
            this.grid_sales.MenuManager = this.ribbonControl1;
            this.grid_sales.Name = "grid_sales";
            this.grid_sales.Size = new System.Drawing.Size(853, 668);
            this.grid_sales.TabIndex = 2;
            this.grid_sales.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Appearance.HeaderPanel.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold);
            this.gridView1.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.field_ID,
            this.field_name,
            this.field_item1,
            this.field_item2,
            this.field_itemd3,
            this.field_item4});
            this.gridView1.GridControl = this.grid_sales;
            this.gridView1.Name = "gridView1";
            // 
            // field_ID
            // 
            this.field_ID.Caption = "ID";
            this.field_ID.Name = "field_ID";
            this.field_ID.Visible = true;
            this.field_ID.VisibleIndex = 0;
            this.field_ID.Width = 31;
            // 
            // field_name
            // 
            this.field_name.Caption = "Name";
            this.field_name.Name = "field_name";
            this.field_name.Visible = true;
            this.field_name.VisibleIndex = 1;
            this.field_name.Width = 108;
            // 
            // field_item1
            // 
            this.field_item1.Caption = "Item1";
            this.field_item1.Name = "field_item1";
            this.field_item1.Visible = true;
            this.field_item1.VisibleIndex = 2;
            this.field_item1.Width = 138;
            // 
            // field_item2
            // 
            this.field_item2.Caption = "Item2";
            this.field_item2.Name = "field_item2";
            this.field_item2.Visible = true;
            this.field_item2.VisibleIndex = 3;
            this.field_item2.Width = 141;
            // 
            // field_itemd3
            // 
            this.field_itemd3.Caption = "Item3";
            this.field_itemd3.Name = "field_itemd3";
            this.field_itemd3.Visible = true;
            this.field_itemd3.VisibleIndex = 4;
            this.field_itemd3.Width = 139;
            // 
            // field_item4
            // 
            this.field_item4.Caption = "Item4";
            this.field_item4.Name = "field_item4";
            this.field_item4.Visible = true;
            this.field_item4.VisibleIndex = 5;
            this.field_item4.Width = 135;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.groupControl2);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.month_pick);
            this.groupControl1.Location = new System.Drawing.Point(0, 146);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(233, 668);
            this.groupControl1.TabIndex = 3;
            // 
            // groupControl2
            // 
            this.groupControl2.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupControl2.Appearance.Options.UseFont = true;
            this.groupControl2.AppearanceCaption.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupControl2.AppearanceCaption.Options.UseFont = true;
            this.groupControl2.Controls.Add(this.chk_term4);
            this.groupControl2.Controls.Add(this.chk_term3);
            this.groupControl2.Controls.Add(this.chk_term2);
            this.groupControl2.Controls.Add(this.chk_term1);
            this.groupControl2.Location = new System.Drawing.Point(28, 79);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(200, 300);
            this.groupControl2.TabIndex = 2;
            this.groupControl2.Text = "Term";
            // 
            // chk_term4
            // 
            this.chk_term4.Location = new System.Drawing.Point(47, 197);
            this.chk_term4.MenuManager = this.ribbonControl1;
            this.chk_term4.Name = "chk_term4";
            this.chk_term4.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_term4.Properties.Appearance.Options.UseFont = true;
            this.chk_term4.Properties.Caption = "Term4";
            this.chk_term4.Size = new System.Drawing.Size(75, 23);
            this.chk_term4.TabIndex = 3;
            // 
            // chk_term3
            // 
            this.chk_term3.Location = new System.Drawing.Point(47, 149);
            this.chk_term3.MenuManager = this.ribbonControl1;
            this.chk_term3.Name = "chk_term3";
            this.chk_term3.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_term3.Properties.Appearance.Options.UseFont = true;
            this.chk_term3.Properties.Caption = "Term3";
            this.chk_term3.Size = new System.Drawing.Size(75, 23);
            this.chk_term3.TabIndex = 2;
            // 
            // chk_term2
            // 
            this.chk_term2.Location = new System.Drawing.Point(47, 100);
            this.chk_term2.MenuManager = this.ribbonControl1;
            this.chk_term2.Name = "chk_term2";
            this.chk_term2.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_term2.Properties.Appearance.Options.UseFont = true;
            this.chk_term2.Properties.Caption = "Term2";
            this.chk_term2.Size = new System.Drawing.Size(75, 23);
            this.chk_term2.TabIndex = 1;
            // 
            // chk_term1
            // 
            this.chk_term1.Location = new System.Drawing.Point(47, 57);
            this.chk_term1.MenuManager = this.ribbonControl1;
            this.chk_term1.Name = "chk_term1";
            this.chk_term1.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_term1.Properties.Appearance.Options.UseFont = true;
            this.chk_term1.Properties.Caption = "Term1";
            this.chk_term1.Size = new System.Drawing.Size(75, 23);
            this.chk_term1.TabIndex = 0;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(31, 35);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(44, 24);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "2018";
            // 
            // month_pick
            // 
            this.month_pick.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.month_pick.Location = new System.Drawing.Point(0, 441);
            this.month_pick.Name = "month_pick";
            this.month_pick.Size = new System.Drawing.Size(232, 227);
            this.month_pick.TabIndex = 0;
            // 
            // defaultLookAndFeel1
            // 
            this.defaultLookAndFeel1.LookAndFeel.SkinName = "Office 2016 Dark";
            // 
            // ribbonPageGroup5
            // 
            this.ribbonPageGroup5.ItemLinks.Add(this.barButtonItem1);
            this.ribbonPageGroup5.Name = "ribbonPageGroup5";
            this.ribbonPageGroup5.Text = "Amount";
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "SalesAmount";
            this.barButtonItem1.Id = 5;
            this.barButtonItem1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.Image")));
            this.barButtonItem1.ItemAppearance.Normal.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barButtonItem1.ItemAppearance.Normal.Options.UseFont = true;
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1095, 849);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.grid_sales);
            this.Controls.Add(this.ribbonStatusBar1);
            this.Controls.Add(this.ribbonControl1);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Glow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Ribbon = this.ribbonControl1;
            this.StatusBar = this.ribbonStatusBar1;
            this.Text = "SalesManagement";
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_sales)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chk_term4.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chk_term3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chk_term2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chk_term1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.month_pick.CalendarTimeProperties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.BarButtonItem btn_item;
        private DevExpress.XtraBars.BarButtonItem btn_man;
        private DevExpress.XtraGrid.GridControl grid_sales;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.Controls.CalendarControl month_pick;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.CheckEdit chk_term4;
        private DevExpress.XtraEditors.CheckEdit chk_term3;
        private DevExpress.XtraEditors.CheckEdit chk_term2;
        private DevExpress.XtraEditors.CheckEdit chk_term1;
        private DevExpress.XtraGrid.Columns.GridColumn field_ID;
        private DevExpress.XtraGrid.Columns.GridColumn field_name;
        private DevExpress.XtraGrid.Columns.GridColumn field_item1;
        private DevExpress.XtraGrid.Columns.GridColumn field_item2;
        private DevExpress.XtraBars.BarButtonItem btn_item_chart;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage3;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.BarButtonItem btn_man_chart;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraGrid.Columns.GridColumn field_itemd3;
        private DevExpress.XtraGrid.Columns.GridColumn field_item4;
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup5;
    }
}