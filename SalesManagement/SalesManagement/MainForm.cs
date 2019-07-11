using DevExpress.XtraTab;
using DevExpress.XtraTab.ViewInfo;
using SalesManagement.db;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace SalesManagement
{
    public partial class MainForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        ModelReport m_modelReport;

        public MainForm()
        {
            InitializeComponent();

            m_modelReport = new ModelReport();
        }

        // Initialize main form with the term 1 data.
        private void MainForm_Load(object sender, EventArgs e)
        {
            DateRange w_range = m_modelReport.GetReportDateRange();
            treeView1.Nodes[0].ExpandAll();
            treeView1.Nodes[0].Text = date_control.SelectedRanges.Start.Year.ToString();
            treeView1.SelectedNode = treeView1.Nodes[0].Nodes[0];
            refresh();
        }

        // display item manager and get result .
        private void btn_item_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ItemForm item_form = new ItemForm();
            item_form.ShowDialog();
            refresh();
            
        }
        // display man manager and get result .
        private void btn_man_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ManForm man_form = new ManForm();
            man_form.ShowDialog();
            refresh();
        }
        // display item chart.
        private void btn_item_chart_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ItemChartForm chart_form = new ItemChartForm();
            chart_form.ShowDialog();
        }
        // display Man chart.
        private void btn_man_chart_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ManChartForm chart_man = new ManChartForm();
            chart_man.ShowDialog();
        }
        // display monthly amount enter window.
        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SalesAmountForm amount_form = new SalesAmountForm();
            amount_form.ShowDialog();
            refresh();
        }

        // when the year is changed, change tree text and select term 1 node.
        private void date_control_SelectionChanged(object sender, EventArgs e)
        {
            treeView1.Nodes[0].EndEdit(false);
            string w_tmp_year = treeView1.Nodes[0].Text;
            treeView1.Nodes[0].Text = date_control.SelectedRanges.Start.Year.ToString();
            treeView1.SelectedNode = treeView1.Nodes[0].Nodes[0];
        }
        // when changing is appeared, call this function to refresh form.
        private void refresh()
        {
            int w_sel_year = date_control.SelectedRanges.Start.Year;
            int w_termNum = -1;
            List<int> w_quartes = new List<int>();
            
            if(treeView1.Nodes[0].Nodes[0].IsSelected)
            {
                w_quartes.Add(1);
                w_quartes.Add(2);
                w_quartes.Add(3);
                w_termNum = 1;

            }
            if (treeView1.Nodes[0].Nodes[1].IsSelected)
            {
                w_quartes.Add(4);
                w_quartes.Add(5);
                w_quartes.Add(6);
                w_termNum = 2;
            }
            if (treeView1.Nodes[0].Nodes[2].IsSelected)
            {
                w_quartes.Add(7);
                w_quartes.Add(8);
                w_quartes.Add(9);
                w_termNum = 3;
            }
            if (treeView1.Nodes[0].Nodes[3].IsSelected)
            {
                w_quartes.Add(10);
                w_quartes.Add(11);
                w_quartes.Add(12);
                w_termNum = 4;
            }
            
            if (w_quartes.Count == 0)
            {
                w_quartes.Add(date_control.SelectedRanges.Start.Month);
            }

            DataTable w_dt = new DataTable();
            w_dt = m_modelReport.GetReportPerMonth(w_sel_year, w_quartes);
            DataColumn w_col = w_dt.Columns.Add("Total", typeof(Int32));


            foreach (DataRow w_row in w_dt.Rows)
            {
                int total = 0;
                for (int i = 2; i <= w_dt.Columns.Count - 2; i++)
                {
                    total += (int)w_row[i];
                }
                w_row[w_dt.Columns.Count - 1] = total;
            }
            NewTab w_tab = new NewTab();
            w_tab.m_tab_text = w_sel_year.ToString() + "-" + w_termNum.ToString();
            tab_amount.TabPages.Add(w_tab.create_page(w_dt));
            tab_amount.SelectedTabPage.Refresh();
        }

        // double click method
        private void treeView1_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            refresh();
        }
        // close button method on tab page.
        private void tab_amount_CloseButtonClick(object sender, EventArgs e)
        {
            ClosePageButtonEventArgs arg = e as ClosePageButtonEventArgs;
            (arg.Page as XtraTabPage).PageVisible = false;
        }
    }
}
