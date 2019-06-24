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
    public partial class SalesAmountForm : Form
    {
        ModelReport w_model;
        
        public SalesAmountForm()
        {
            InitializeComponent();

            w_model = new ModelReport();
           
        }

        private void SalesAmountForm_Load(object sender, EventArgs e)
        {

            DataTable w_dt = w_model.GetReport(2019, 6);
            dataGridView1.DataSource = w_dt;

            foreach (DataGridViewColumn col in dataGridView1.Columns)
            {
                col.HeaderText = w_dt.Columns[col.HeaderText].Caption;
            }
        }

        private void btn_amount_save_Click(object sender, EventArgs e)
        {
            DataTable w_dt = (DataTable)dataGridView1.DataSource;

            w_model.SetReport(2019, 6, w_dt);
        }
    }
}
