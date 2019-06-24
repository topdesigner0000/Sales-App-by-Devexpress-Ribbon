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
        public MainForm()
        {
            InitializeComponent();
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
    }
}
