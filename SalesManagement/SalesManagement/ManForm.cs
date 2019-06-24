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
    public partial class ManForm : Form
    {
        ModelEmployee m_model;

        public ManForm()
        {
            InitializeComponent();

            m_model = new ModelEmployee();
        }

        private void ManForm_Load(object sender, EventArgs e)
        {
            IList<IEmployee> w_list = m_model.GetItemList();
            grid_employees.Columns.Clear();
            grid_employees.DataSource = w_list;

        }

        private void btn_man_add_Click(object sender, EventArgs e)
        {
            m_model.AddItem(new Employee("AA-01", "BB", "kk@gmail.com", 2, 0));
            m_model.AddItem(new Employee("AA-02", "BB", "kk@gmail.com", 1, 0));
            m_model.AddItem(new Employee("AA-03", "BB", "kk@gmail.com", 1, 0));
            m_model.AddItem(new Employee("AA-04", "BB", "kk@gmail.com", 1, 0));
            m_model.AddItem(new Employee("AA-05", "BB", "kk@gmail.com", 2, 1));
            m_model.AddItem(new Employee("AA-06", "BB", "kk@gmail.com", 2, 1));
            m_model.AddItem(new Employee("AA-07", "BB", "kk@gmail.com", 1, 1));
            m_model.AddItem(new Employee("AA-08", "BB", "kk@gmail.com", 2, 1));
            m_model.AddItem(new Employee("AA-09", "BB", "kk@gmail.com", 1, 1));
            m_model.AddItem(new Employee("AA-10", "BB", "kk@gmail.com", 1, 1));
        }

    }
}
