using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SalesManagement.db;

namespace SalesManagement
{
    public partial class SalesAmountForm : DevExpress.XtraEditors.XtraForm
    {
        ModelReport w_model;
        
        public SalesAmountForm()
        {
            InitializeComponent();

            w_model = new ModelReport();
           
        }

        private void SalesAmountForm_Load(object sender, EventArgs e)
        {
            refresh();
        }

        private void btn_amount_save_Click(object sender, EventArgs e)
        {
            DataTable w_dt = (DataTable)dataGridView1.DataSource;

            w_model.SetReport(choose_month.SelectedRanges.Start.Year, choose_month.SelectedRanges.Start.Month, w_dt);
        }

        private void refresh()
        {
            List<int> w_selMonth = new List<int>();
            w_selMonth.Add(choose_month.SelectedRanges.Start.Month);
            DataTable w_dt = w_model.GetReportPerMonth(choose_month.SelectedRanges.Start.Year, w_selMonth);
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = w_dt;

            foreach (DataGridViewColumn col in dataGridView1.Columns)
            {
                col.HeaderText = w_dt.Columns[col.HeaderText].Caption;
            }
            dataGridView1.Columns[0].Visible = false;
        }

        
        private void choose_month_ValueChanged(object sender, EventArgs e)
        {
            refresh();
        }
    }
}
