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
    public partial class ItemForm : Form
    {
        ModelProduct m_model;

        public ItemForm()
        {
            InitializeComponent();

            m_model = new ModelProduct();
        }

        private void ItemForm_Load(object sender, EventArgs e)
        {
            IList<IProduct> w_list = m_model.GetItemList();
            grid_items.Columns.Clear();
            grid_items.DataSource = w_list;
        }

        private void btn_item_add_Click(object sender, EventArgs e)
        {
            //x grid_items.Rows.Add();

            //*
            m_model.AddItem(new Product("Sugar", 1, 100, 120));
            m_model.AddItem(new Product("Bisket", 0, 50, 55));
            m_model.AddItem(new Product("Brade", 0, 80, 100));
            m_model.AddItem(new Product("Juce", 0, 10, 12.5f));
            m_model.AddItem(new Product("Jerry", 0, 10, 12.5f));
            m_model.AddItem(new Product("Kimchi", 0, 23, 32.5f));
            //*/
        }

        private void btn_item_del_Click(object sender, EventArgs e)
        {
            int w_selRow = grid_items.CurrentCell.RowIndex;
            if (w_selRow != -1)
            {
                IProduct w_selProduct = (IProduct)grid_items.Rows[w_selRow].DataBoundItem;
                m_model.DeleteItem(w_selProduct);
            }
        }
    }
}
