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
    public partial class ManForm : DevExpress.XtraEditors.XtraForm
    {
        ModelEmployee m_model;
        int save_flag = 0;

        public ManForm()
        {
            InitializeComponent();

            m_model = new ModelEmployee();
        }

        private void ManForm_Load(object sender, EventArgs e)
        {
            refresh();

        }

        private void btn_man_add_Click(object sender, EventArgs e)
        {
            IList<IEmployee> w_list = grid_employees.DataSource as IList<IEmployee>;
            Employee w_new = new Employee("", "", "", "", 0);
            w_new.id = w_list.Count + 1;
            w_list.Add(w_new);
            grid_employees.DataSource = null;
            grid_employees.DataSource = w_list;
            grid_employees.Columns[0].Visible = false;
            grid_employees.Columns[6].Visible = false;
            grid_employees.CurrentCell = grid_employees.Rows[grid_employees.Rows.Count - 1].Cells[1];
            grid_employees.BeginEdit(true);
        }
        private void refresh()
        {
            IList<IEmployee> w_list = m_model.GetItemList();
            grid_employees.Columns.Clear();
            grid_employees.DataSource = w_list;
            grid_employees.Columns[0].Visible = false;
            grid_employees.Columns[6].Visible = false;
        }

        private void btn_man_delete_Click(object sender, EventArgs e)
        {
            string message = "Do you want to delete this man?";
            string title = "Remove salesman";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                this.Close();
                int w_selRow = grid_employees.CurrentCell.RowIndex;
                if (w_selRow != -1)
                {
                    IEmployee w_selEmployee = (IEmployee)grid_employees.Rows[w_selRow].DataBoundItem;
                    m_model.DeleteItem(w_selEmployee);
                    refresh();
                }
            }
            else
            {
                // Do something  
            }
            
        }

        private void btn_man_save_Click(object sender, EventArgs e)
        {
            IList<IEmployee> w_list = grid_employees.DataSource as IList<IEmployee>;
            if (m_model.DeleteAll())
            {
                foreach (Employee man in w_list)
                {
                    m_model.AddItem(man);
                }
                refresh();
            }
        }
    }
}
