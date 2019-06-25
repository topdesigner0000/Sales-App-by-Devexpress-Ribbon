using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace SalesManagement.db
{
    interface IEmployee
    {
        int id { get; set; }
        string f_name { get; set; }
        string g_name { get; set; }
        string email { get; set; }
        int code { get; set; }
        int team { get; set; }
        int invisible { get; set; }
    }

    class Employee : IEmployee
    {
        private int _id;
        private string _f_name;
        private string _g_name;
        private string _email;
        private int _code;
        private int _team;
        private int _invisible;

        public Employee()
        {

        }

        public Employee(string first_name, string given_name, string email, int code, int team)
        {
            this.f_name = first_name;
            this.g_name = given_name;
            this.email = email;
            this.code = code;
            this.team = team;
            this.invisible = 1;
        }

        public int id { get { return _id; } set { _id = value; } }
        public string f_name { get { return _f_name; } set { _f_name = value; } }
        public string g_name { get { return _g_name; } set { _g_name = value; } }
        public string email { get { return _email; } set { _email = value; } }
        public int code { get { return _code; } set { _code = value; } }
        public int team { get { return _team; } set { _team = value; } }
        public int invisible { get { return _invisible; } set { _invisible = value; } }
    }


    class ModelEmployee
    {
        string m_tableName = "tbl_employee";

        public ModelEmployee()
        {
        }

        ~ModelEmployee()
        {
        }

        public bool AddItem(IEmployee newEmployee)
        {
            bool w_ret = false;
            string w_query = string.Format(@"INSERT INTO {0} (f_name, g_name, email, code, team, invisible) VALUES ('{1}', '{2}', '{3}', '{4}', '{5}', '{6}')"
                                        , m_tableName
                                        , newEmployee.f_name
                                        , newEmployee.g_name
                                        , newEmployee.email
                                        , newEmployee.code
                                        , newEmployee.team
                                        , newEmployee.invisible
                                    );

            w_ret = DbAssist.executeCommand(w_query);
            return w_ret;
        }

        public bool UpdateItem(IEmployee udEmployee)
        {
            bool w_ret = false;
            string w_query = string.Format(@"UPDATE {0} SET f_name='{1}', g_name='{2}', email='{3}', code='{4}', team='{5}', invisible='{6}' WHERE id='{7}';"
                                        , m_tableName
                                        , udEmployee.f_name
                                        , udEmployee.g_name
                                        , udEmployee.email
                                        , udEmployee.code
                                        , udEmployee.team
                                        , udEmployee.invisible
                                        , udEmployee.id
                                    );

            w_ret = DbAssist.executeCommand(w_query);
            return w_ret;
        }

        public bool DeleteItem(IEmployee delEmployee)
        {
            bool w_ret = false;

            string w_query = string.Format(@"DELETE FROM {0} WHERE id='{1}';"
                            , m_tableName
                            , delEmployee.id
                        );

            w_ret = DbAssist.executeCommand(w_query);

            return w_ret;
        }

        public IList<IEmployee> GetItemList()
        {
            IList<IEmployee> w_list = new List<IEmployee>();

            string w_query = string.Format(@"SELECT * FROM {0};"
                , m_tableName
            );

            SQLiteDataReader w_reader = DbAssist.executeQuery(w_query);
            if (w_reader != null)
            {
                while (w_reader.Read())
                {
                    Employee w_item = new Employee();
                    //. 01 - id
                    w_item.id = w_reader.GetInt32(0);
                    //. 02 - f_name
                    w_item.f_name = w_reader.GetString(1);
                    //. 03 - g_name
                    w_item.g_name = w_reader.GetString(2);
                    //. 04 - email
                    w_item.email = w_reader.GetString(3);
                    //. 05 - code
                    w_item.code = w_reader.GetInt32(4);
                    //. 06 - team
                    w_item.team = w_reader.GetInt32(5);
                    //. 07 - invisible
                    w_item.invisible = w_reader.GetInt32(6);   //x w_reader.GetBoolean(6);

                    w_list.Add(w_item);
                }
            }

            return w_list;
        }
        public bool DeleteAll()
        {
            string w_query = string.Format(@"DELETE FROM {0};"
                            , m_tableName
                        );

            bool w_ret = DbAssist.executeCommand(w_query);
            return w_ret;
        }
    }
}
