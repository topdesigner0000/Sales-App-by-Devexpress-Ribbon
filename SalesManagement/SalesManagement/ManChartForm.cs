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
    public partial class ManChartForm : Form
    {
        ModelEmployee m_model;
        ModelReport m_report_model;
        IList<IEmployee> w_list;

        int m_year;
        int m_month;
        public ManChartForm()
        {
            InitializeComponent();
            m_model = new ModelEmployee();
            m_report_model = new ModelReport();
        }

        private void ManChartForm_Load(object sender, EventArgs e)
        {
            w_list = m_model.GetItemList();

            foreach (Employee w_man in w_list)
            {
                list_man.Items.Add(w_man.f_name);
            }
            m_year = ctl_man_calendar.SelectedRanges.Start.Year;
            m_month = ctl_man_calendar.SelectedRanges.Start.Month;
        }

        private void list_man_SelectedIndexChanged(object sender, EventArgs e)
        {
            int w_id = 0;
            m_year = ctl_man_calendar.SelectedRanges.Start.Year;
            m_month = ctl_man_calendar.SelectedRanges.Start.Month;
            foreach (Employee w_item in w_list)
            {
                if ((string)list_man.SelectedValue == w_item.f_name)
                {
                    w_id = w_item.id;
                    List<int> w_quartes = new List<int>();
                    w_quartes.Add(m_month);
                    DataTable w_dt = m_report_model.GetReportPerMan(m_year, w_quartes, w_id);

                    //*****//
                    man_chart.Series.Clear();
                    Series series1 = new Series(w_item.f_name + " sales of all items", ViewType.Pie);
                    foreach (DataRow w_man in w_dt.Rows)
                    {
                        series1.Points.Add(new SeriesPoint(w_man[1], w_man[2]));
                    }
                    man_chart.Series.Add(series1);
                    series1.Label.TextPattern = "{A}: {VP:p0}";


                    PieSeriesView myView = (PieSeriesView)series1.View;
                    myView.Titles.Add(new SeriesTitle());
                    myView.Titles[0].Text = series1.Name;



                    break;
                }
            }
        }

        private void ctl_man_calendar_SelectionChanged(object sender, EventArgs e)
        {
            list_man_SelectedIndexChanged(sender, e);
        }
    }
}
