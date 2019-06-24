using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Data;

namespace SalesManagement.db
{
    interface IReport
    {
        int id { get; set; }
        int year { get; set; }
        int month { get; set; }
        int day { get; set; }
        int employee { get; set; }
        int product { get; set; }
        int amount { get; set; }
    }

    class Report : IReport
    {
        private int _id;
        private int _year;
        private int _month;
        private int _day;
        private int _employee;
        private int _product;
        private int _amount;

        public Report()
        {

        }

        public Report(int year, int month, int day, int employee, int product, int amount)
        {
            this.year = year;
            this.month= month;
            this.day = day;
            this.employee = employee;
            this.product = product;
            this.amount = amount;
        }

        public int id { get { return _id; } set { _id = value; } }
        public int year { get { return _year; } set { _year = value; } }
        public int month { get { return _month; } set { _month = value; } }
        public int day { get { return _day; } set { _day = value; } }
        public int employee { get { return _employee; } set { _employee = value; } }
        public int product { get { return _product; } set { _product = value; } }
        public int amount { get { return _amount; } set { _amount = value; } }
    }


    class ModelReport
    {
        string m_tableName = "tbl_Report";

        public ModelReport()
        {
        }

        ~ModelReport()
        {
        }

        public bool AddItem(IReport newItem)
        {
            bool w_ret = false;
            string w_query = string.Format(@"INSERT INTO {0} (year, month, day, employee, product, amount) VALUES ('{1}', '{2}', '{3}', '{4}', '{5}', '{6}')"
                                        , m_tableName
                                        , newItem.year
                                        , newItem.month
                                        , newItem.day
                                        , newItem.employee
                                        , newItem.product
                                        , newItem.amount
                                    );

            w_ret = DbAssist.executeCommand(w_query);
            return w_ret;
        }

        public bool UpdateItem(IReport udReport)
        {
            bool w_ret = false;
            string w_query = string.Format(@"UPDATE {0} SET year='{1}', month='{2}', day='{3}', employee='{4}', product='{5}', amount='{6}' WHERE id='{7}';"
                                        , m_tableName
                                        , udReport.year
                                        , udReport.month
                                        , udReport.day
                                        , udReport.employee
                                        , udReport.product
                                        , udReport.amount
                                        , udReport.id
                                    );

            w_ret = DbAssist.executeCommand(w_query);
            return w_ret;
        }

        public bool DeleteItem(IReport delReport)
        {
            bool w_ret = false;

            string w_query = string.Format(@"DELETE FROM {0} WHERE id='{1}';"
                            , m_tableName
                            , delReport.id
                        );

            w_ret = DbAssist.executeCommand(w_query);

            return w_ret;
        }

        public bool DeleteAll(int year, int month)
        {
            bool w_ret = false;

            string w_query = string.Format(@"DELETE FROM {0} WHERE year='{1}' AND month='{2}';"
                            , m_tableName
                            , year
                            , month
                        );

            w_ret = DbAssist.executeCommand(w_query);

            return w_ret;
        }


        protected IList<IReport> GetItemList(int year, int mounth)
        {
            IList<IReport> w_list = new List<IReport>();

            string w_query = string.Format(@"SELECT * FROM {0} WHERE year='{1}' AND month = '{2}';"
                , m_tableName
                , year
                , mounth
            );

            SQLiteDataReader w_reader = DbAssist.executeQuery(w_query);
            if (w_reader != null)
            {
                while (w_reader.Read())
                {
                    Report w_item = new Report();
                    //. 01 - id
                    w_item.id = w_reader.GetInt32(0);
                    //. 02 - year
                    w_item.year = w_reader.GetInt32(1);
                    //. 03 - month
                    w_item.month = w_reader.GetInt32(2);
                    //. 04 - day
                    w_item.day = w_reader.GetInt32(3);
                    //. 05 - employee
                    w_item.employee = w_reader.GetInt32(4);
                    //. 06 - product
                    w_item.product = w_reader.GetInt32(5);
                    //. 07 - amount
                    w_item.amount = w_reader.GetInt32(6);

                    w_list.Add(w_item);
                }
            }

            return w_list;
        }

        protected int GetSalesCount(IList<IReport> sales_info, int employee_id, int product_id)
        {
            int w_count = 0;
            
            foreach (IReport w_item in sales_info)
            {
                if (w_item.employee == employee_id && w_item.product == product_id)
                {
                    w_count = w_item.amount;
                }
            }
            return w_count;
        }

        public DataTable GetReport(int year, int month)
        {
            DataTable w_table = new DataTable();

            //. Columns
            ModelProduct w_products = new ModelProduct();
            IList<IProduct> w_prdList = w_products.GetItemList();

            DataColumn w_col = w_table.Columns.Add("id", typeof(Int32));
            w_col.AllowDBNull = false;
            w_col.Unique = true;

            w_col = w_table.Columns.Add("Employee", typeof(string));
            w_col.AllowDBNull = false;
            w_col.Unique = true;
            foreach (IProduct w_prdItem in w_prdList)
            {
                w_col = w_table.Columns.Add(w_prdItem.id.ToString(), typeof(Int32));
                w_col.Caption = w_prdItem.name;
            }

            //. Rows.
            ModelEmployee w_employees = new ModelEmployee();
            IList<IEmployee> w_manList = w_employees.GetItemList();
            IList<IReport> w_salesList = this.GetItemList(year, month);

            foreach (IEmployee w_empItem in w_manList)
            {
                DataRow w_row = w_table.NewRow();
                foreach (DataColumn w_col1 in w_table.Columns)
                {
                    if (w_col1.Ordinal == 0)
                    {
                        w_row[0] = w_empItem.id;
                        continue;
                    }

                    if (w_col1.Ordinal == 1)
                    {
                        w_row[1] = w_empItem.f_name + "." + w_empItem.g_name;
                        continue;
                    }

                    int w_prdId = int.Parse(w_col1.ColumnName);
                    int w_amount = GetSalesCount(w_salesList, w_empItem.id, w_prdId);
                    w_row[w_col1.Ordinal] = w_amount;
                }

                w_table.Rows.Add(w_row);
            }

            return w_table;
        }

        public bool SetReport(int year, int month, DataTable salse_info)
        {
            if (salse_info == null)
                return false;

            if (!this.DeleteAll(year, month))
                return false;

            int w_col_num = salse_info.Columns.Count;
            foreach (DataRow w_row in salse_info.Rows)
            {
                int w_emp_id = (int)w_row[0];
                for (int i = 2; i < w_col_num; i++)
                {
                    if (w_row[i] == System.DBNull.Value)
                        continue;
                    int w_prd_id = int.Parse(salse_info.Columns[i].ColumnName);
                    int w_amount = (int)w_row[i];

                    if (w_amount != 0)
                    {
                        Report w_report = new Report(year, month, 1, w_emp_id, w_prd_id, w_amount);
                        this.AddItem(w_report);
                    }
                }
            }

            return true;
        }
    }
}
