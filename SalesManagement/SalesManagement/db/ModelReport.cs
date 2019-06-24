using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

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

        public IList<IReport> GetItemList()
        {
            IList<IReport> w_list = new List<IReport>();

            string w_query = string.Format(@"SELECT * FROM {0};"
                , m_tableName
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
    }
}
