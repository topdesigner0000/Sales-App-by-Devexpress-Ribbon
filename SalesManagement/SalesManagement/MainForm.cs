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

        private void MainForm_Load(object sender, EventArgs e)
        {
            DateRange w_range = m_modelReport.GetReportDateRange();
            cmbReportYear.Items.Clear();
            for (int i = w_range.m_begin_year; i <= w_range.m_end_year; i++)
            {
                cmbReportYear.Items.Add(i);
            }
            cmbReportYear.SelectedIndex = (cmbReportYear.Items.Count - 1);

        }

        private void btn_item_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ItemForm item_form = new ItemForm();
            item_form.ShowDialog();
        }

        private void btn_man_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ManForm man_form = new ManForm();
            man_form.ShowDialog();
        }

        private void btn_item_chart_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ItemChartForm chart_form = new ItemChartForm();
            chart_form.ShowDialog();
        }

        private void btn_man_chart_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ManChartForm chart_man = new ManChartForm();
            chart_man.ShowDialog();
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SalesAmountForm amount_form = new SalesAmountForm();
            amount_form.ShowDialog();
        }

        private void cmbReportYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshReportTable();
        }

        private void chk_term_CheckedChanged(object sender, EventArgs e)
        {
            RefreshReportTable();
        }

        private void RefreshReportTable()
        {
            int w_sel_year = (int)cmbReportYear.Items[cmbReportYear.SelectedIndex];

            List<int> w_quartes = new List<int>();
            if ( chk_term1.Checked)
            {
                w_quartes.Add(1);
                w_quartes.Add(2);
                w_quartes.Add(3);
            }

            if (chk_term2.Checked)
            {
                w_quartes.Add(4);
                w_quartes.Add(5);
                w_quartes.Add(6);
            }

            if (chk_term3.Checked)
            {
                w_quartes.Add(7);
                w_quartes.Add(8);
                w_quartes.Add(9);
            }

            if (chk_term4.Checked)
            {
                w_quartes.Add(10);
                w_quartes.Add(11);
                w_quartes.Add(12);
            }

            if (w_quartes.Count == 0)
            {
                w_quartes.Add(DateTime.Today.Month);
            }

            DataTable w_dt = m_modelReport.GetReportPerMonth(w_sel_year, w_quartes);

            DataColumn w_col = w_dt.Columns.Add("Total", typeof(Int32));
            
            
            foreach(DataRow w_row in w_dt.Rows)
            {
                int total = 0;
                for(int i=2;i<=w_dt.Columns.Count-2;i++)
                {
                    total += (int)w_row[i];
                }
                w_row[w_dt.Columns.Count - 1] = total;
            }
            grid_sales.DataSource = null;
            grid_sales.DataSource = w_dt;
        }
    }
}
