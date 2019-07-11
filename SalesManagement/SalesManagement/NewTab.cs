using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesManagement
{
    // the class for a new tab page with grid control.
    class NewTab
    {
        public string m_tab_text;
        public DevExpress.XtraGrid.GridControl m_grid;
        public NewTab()
        {

        }
        public DevExpress.XtraTab.XtraTabPage create_page(DataTable p_dataSource)
        {
            DevExpress.XtraTab.XtraTabPage tabPage = new DevExpress.XtraTab.XtraTabPage();
            tabPage.Text = m_tab_text;

            DevExpress.XtraGrid.GridControl grid = new DevExpress.XtraGrid.GridControl();
            
            grid.Dock = DockStyle.Fill;
            grid.DataSource = null;
            grid.DataSource = p_dataSource;
            tabPage.Controls.Add(grid);
            m_grid = grid;
            return tabPage;
        }
    }
}
