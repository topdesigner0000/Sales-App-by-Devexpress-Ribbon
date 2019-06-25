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
    public partial class ItemForm : DevExpress.XtraEditors.XtraForm
    {
        ModelProduct m_model;

        public ItemForm()
        {
            InitializeComponent();

            m_model = new ModelProduct();
        }

        private void ItemForm_Load(object sender, EventArgs e)
        {
            refresh();
        }

        private void btn_item_add_Click(object sender, EventArgs e)
        {
            IList<IProduct> w_list = grid_items.DataSource as IList<IProduct>;
            Product w_new = new Product("","",0,0);
            w_new.id = w_list.Count + 1;
            w_new.weight = 0;
            w_list.Add(w_new);
            grid_items.DataSource = null;
            grid_items.DataSource = w_list;
            grid_items.Columns[0].Visible = false;
            grid_items.Columns[6].Visible = false;
            grid_items.CurrentCell = grid_items.Rows[grid_items.Rows.Count - 1].Cells[1];
            grid_items.BeginEdit(true);
        }

        private void btn_item_del_Click(object sender, EventArgs e)
        {
            string message = "Do you want to delete this product?";
            string title = "Remove product";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                int w_selRow = grid_items.CurrentCell.RowIndex;
                if (w_selRow != -1)
                {
                    IProduct w_selProduct = (IProduct)grid_items.Rows[w_selRow].DataBoundItem;
                    m_model.DeleteItem(w_selProduct);
                    refresh();
                }
            }
            else
            {

            }
        }
        private void refresh()
        {
            IList<IProduct> w_list = m_model.GetItemList();
            grid_items.Columns.Clear();
            grid_items.DataSource = w_list;
            grid_items.Columns[0].Visible = false;
            grid_items.Columns[6].Visible = false;
        }

        private void btn_item_save_Click(object sender, EventArgs e)
        {
            IList<IProduct> w_list = grid_items.DataSource as IList<IProduct>;
            if (m_model.DeleteAll())
            {
                foreach (Product item in w_list)
                {
                    m_model.AddItem(item);
                }
                refresh();
            }
            
        }
    }
}
