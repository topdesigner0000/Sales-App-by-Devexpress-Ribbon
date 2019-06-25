using DevExpress.XtraCharts;
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
    public partial class ItemChartForm : Form
    {
        ModelProduct m_model;
        ModelReport m_report_model;
        IList<IProduct> w_list;

        int m_year;
        int m_month;
        public ItemChartForm()
        {
            InitializeComponent();
            m_model = new ModelProduct();
            m_report_model = new ModelReport();
        }

        private void ItemChartForm_Load(object sender, EventArgs e)
        {
            w_list = m_model.GetItemList();
            
            foreach (Product w_item in w_list)
            {
                list_item.Items.Add(w_item.name);
            }
            m_year = ctl_calendar.SelectedRanges.Start.Year;
            m_month = ctl_calendar.SelectedRanges.Start.Month;
        }

        private void list_item_SelectedIndexChanged(object sender, EventArgs e)
        {
            int w_id = 0;
            m_year = ctl_calendar.SelectedRanges.Start.Year;
            m_month = ctl_calendar.SelectedRanges.Start.Month;
            foreach (Product w_item in w_list)
            {
                if((string)list_item.SelectedValue == w_item.name)
                {
                    w_id = w_item.id;
                    List<int> w_quartes = new List<int>();
                    w_quartes.Add(m_month);
                    DataTable w_dt = m_report_model.GetReportPerItem(m_year, w_quartes, w_id);

                    //*****//
                    item_chart.Series.Clear();
                    Series series1 = new Series(w_item.name + " per SalesMan", ViewType.Pie);
                    foreach(DataRow w_man in w_dt.Rows)
                    {
                        series1.Points.Add(new SeriesPoint(w_man[1], w_man[2]));
                    }
                    item_chart.Series.Add(series1);
                    series1.Label.TextPattern = "{A}: {VP:p0}";
                    

                    PieSeriesView myView = (PieSeriesView)series1.View;
                    myView.Titles.Add(new SeriesTitle());
                    myView.Titles[0].Text = series1.Name;
                    


                    break;
                }
            }
            
        }

        private void ctl_calendar_SelectionChanged(object sender, EventArgs e)
        {
            list_item_SelectedIndexChanged(sender, e);
        }
    }
}
