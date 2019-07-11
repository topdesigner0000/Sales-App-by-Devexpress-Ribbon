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
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Term1");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Term2");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Term3");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Term4");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("2019", new System.Windows.Forms.TreeNode[] {
            treeNode6,
            treeNode7,
            treeNode8,
            treeNode9});
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btn_item = new DevExpress.XtraBars.BarButtonItem();
            this.btn_man = new DevExpress.XtraBars.BarButtonItem();
            this.btn_item_chart = new DevExpress.XtraBars.BarButtonItem();
            this.btn_man_chart = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup5 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage3 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar1 = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.date_control = new DevExpress.XtraEditors.Controls.CalendarControl();
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.tab_amount = new DevExpress.XtraTab.XtraTabControl();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.date_control.CalendarTimeProperties)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tab_amount)).BeginInit();
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
            this.ribbonControl1.ShowDisplayOptionsMenuButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl1.ShowExpandCollapseButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl1.Size = new System.Drawing.Size(1598, 152);
            this.ribbonControl1.StatusBar = this.ribbonStatusBar1;
            // 
            // btn_item
            // 
            this.btn_item.Caption = "Products";
            this.btn_item.Id = 1;
            this.btn_item.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_item.ImageOptions.Image")));
            this.btn_item.ItemAppearance.Hovered.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_item.ItemAppearance.Hovered.Options.UseFont = true;
            this.btn_item.ItemAppearance.Normal.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_item.ItemAppearance.Normal.Options.UseFont = true;
            this.btn_item.ItemAppearance.Pressed.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_item.ItemAppearance.Pressed.Options.UseFont = true;
            this.btn_item.Name = "btn_item";
            this.btn_item.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_item_ItemClick);
            // 
            // btn_man
            // 
            this.btn_man.Caption = "SalesMen";
            this.btn_man.Id = 2;
            this.btn_man.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_man.ImageOptions.Image")));
            this.btn_man.ItemAppearance.Hovered.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_man.ItemAppearance.Hovered.Options.UseFont = true;
            this.btn_man.ItemAppearance.Normal.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_man.ItemAppearance.Normal.Options.UseFont = true;
            this.btn_man.ItemAppearance.Pressed.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_man.ItemAppearance.Pressed.Options.UseFont = true;
            this.btn_man.Name = "btn_man";
            this.btn_man.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_man_ItemClick);
            // 
            // btn_item_chart
            // 
            this.btn_item_chart.Caption = "per Item";
            this.btn_item_chart.Id = 3;
            this.btn_item_chart.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_item_chart.ImageOptions.Image")));
            this.btn_item_chart.ItemAppearance.Hovered.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_item_chart.ItemAppearance.Hovered.Options.UseFont = true;
            this.btn_item_chart.ItemAppearance.Normal.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_item_chart.ItemAppearance.Normal.Options.UseFont = true;
            this.btn_item_chart.ItemAppearance.Pressed.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_item_chart.ItemAppearance.Pressed.Options.UseFont = true;
            this.btn_item_chart.Name = "btn_item_chart";
            this.btn_item_chart.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_item_chart_ItemClick);
            // 
            // btn_man_chart
            // 
            this.btn_man_chart.Caption = "per Man";
            this.btn_man_chart.Id = 4;
            this.btn_man_chart.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_man_chart.ImageOptions.Image")));
            this.btn_man_chart.ItemAppearance.Hovered.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_man_chart.ItemAppearance.Hovered.Options.UseFont = true;
            this.btn_man_chart.ItemAppearance.Normal.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_man_chart.ItemAppearance.Normal.Options.UseFont = true;
            this.btn_man_chart.ItemAppearance.Pressed.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_man_chart.ItemAppearance.Pressed.Options.UseFont = true;
            this.btn_man_chart.Name = "btn_man_chart";
            this.btn_man_chart.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_man_chart_ItemClick);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "SalesAmount";
            this.barButtonItem1.Id = 5;
            this.barButtonItem1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.Image")));
            this.barButtonItem1.ItemAppearance.Hovered.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barButtonItem1.ItemAppearance.Hovered.Options.UseFont = true;
            this.barButtonItem1.ItemAppearance.Normal.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barButtonItem1.ItemAppearance.Normal.Options.UseFont = true;
            this.barButtonItem1.ItemAppearance.Pressed.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barButtonItem1.ItemAppearance.Pressed.Options.UseFont = true;
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            // ribbonPageGroup5
            // 
            this.ribbonPageGroup5.ItemLinks.Add(this.barButtonItem1);
            this.ribbonPageGroup5.Name = "ribbonPageGroup5";
            this.ribbonPageGroup5.Text = "Amount";
            // 
            // ribbonPage3
            // 
            this.ribbonPage3.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ribbonPage3.Appearance.Options.UseFont = true;
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
            this.ribbonStatusBar1.Location = new System.Drawing.Point(0, 878);
            this.ribbonStatusBar1.Name = "ribbonStatusBar1";
            this.ribbonStatusBar1.Ribbon = this.ribbonControl1;
            this.ribbonStatusBar1.Size = new System.Drawing.Size(1598, 21);
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "ribbonPage2";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.treeView1);
            this.groupControl1.Controls.Add(this.date_control);
            this.groupControl1.Location = new System.Drawing.Point(0, 154);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.ShowCaption = false;
            this.groupControl1.Size = new System.Drawing.Size(233, 723);
            this.groupControl1.TabIndex = 3;
            // 
            // treeView1
            // 
            this.treeView1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.treeView1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treeView1.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.treeView1.LabelEdit = true;
            this.treeView1.LineColor = System.Drawing.Color.WhiteSmoke;
            this.treeView1.Location = new System.Drawing.Point(5, 59);
            this.treeView1.Name = "treeView1";
            treeNode6.Name = "Node1";
            treeNode6.Text = "Term1";
            treeNode7.Name = "Node2";
            treeNode7.Text = "Term2";
            treeNode8.Name = "Node3";
            treeNode8.Text = "Term3";
            treeNode9.Name = "Node4";
            treeNode9.Text = "Term4";
            treeNode10.Name = "Node0";
            treeNode10.Text = "2019";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode10});
            this.treeView1.Size = new System.Drawing.Size(222, 278);
            this.treeView1.TabIndex = 1;
            this.treeView1.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView1_NodeMouseDoubleClick);
            // 
            // date_control
            // 
            this.date_control.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.date_control.Location = new System.Drawing.Point(1, 496);
            this.date_control.Name = "date_control";
            this.date_control.Size = new System.Drawing.Size(232, 227);
            this.date_control.TabIndex = 0;
            this.date_control.SelectionChanged += new System.EventHandler(this.date_control_SelectionChanged);
            // 
            // defaultLookAndFeel1
            // 
            this.defaultLookAndFeel1.LookAndFeel.SkinName = "Office 2016 Dark";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tab_amount);
            this.panel1.Location = new System.Drawing.Point(233, 154);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1365, 718);
            this.panel1.TabIndex = 9;
            // 
            // tab_amount
            // 
            this.tab_amount.AppearancePage.Header.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tab_amount.AppearancePage.Header.ForeColor = System.Drawing.Color.Black;
            this.tab_amount.AppearancePage.Header.Options.UseBackColor = true;
            this.tab_amount.AppearancePage.Header.Options.UseForeColor = true;
            this.tab_amount.AppearancePage.HeaderActive.BackColor = System.Drawing.Color.Black;
            this.tab_amount.AppearancePage.HeaderActive.ForeColor = System.Drawing.Color.White;
            this.tab_amount.AppearancePage.HeaderActive.Options.UseBackColor = true;
            this.tab_amount.AppearancePage.HeaderActive.Options.UseForeColor = true;
            this.tab_amount.ClosePageButtonShowMode = DevExpress.XtraTab.ClosePageButtonShowMode.InActiveTabPageHeader;
            this.tab_amount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tab_amount.Location = new System.Drawing.Point(0, 0);
            this.tab_amount.Name = "tab_amount";
            this.tab_amount.Size = new System.Drawing.Size(1365, 718);
            this.tab_amount.TabIndex = 0;
            this.tab_amount.CloseButtonClick += new System.EventHandler(this.tab_amount_CloseButtonClick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1598, 899);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.ribbonStatusBar1);
            this.Controls.Add(this.ribbonControl1);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Glow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Ribbon = this.ribbonControl1;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StatusBar = this.ribbonStatusBar1;
            this.Text = "SalesManagement";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.date_control.CalendarTimeProperties)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tab_amount)).EndInit();
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
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.Controls.CalendarControl date_control;
        private DevExpress.XtraBars.BarButtonItem btn_item_chart;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage3;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.BarButtonItem btn_man_chart;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup5;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraTab.XtraTabControl tab_amount;
    }
}