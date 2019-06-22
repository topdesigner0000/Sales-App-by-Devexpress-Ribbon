using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace SalesManagement.db
{
    interface ITeam
    {
        int id { get; set; }
        string name { get; set; }
        string desc { get; set; }
    }

    class Team : ITeam
    {
        private int _id;
        private string _name;
        private string _desc;

        public int id { get { return _id; } set { _id = value; } }
        public string name { get { return _name; } set { _name = value; } }
        public string desc { get { return _desc; } set { _desc = value; } }
    }


    class ModelTeam
    {
        string m_tableName = "tbl_team";

        ModelTeam()
        {
        }

        ~ModelTeam()
        {
        }

        bool AddProduct(ITeam newTeam)
        {
            bool w_ret = false;
            string w_query = string.Format(@"INSERT INTO {0} (name, desc) VALUES ({1}, {2})"
                                        , m_tableName
                                        , newTeam.name
                                        , newTeam.desc
                                    );

            w_ret = DbAssist.executeCommand(w_query);
            return w_ret;
        }

        bool UpdateProduct(ITeam udTeam)
        {
            bool w_ret = false;
            string w_query = string.Format(@"UPDATE {0} SET name={1}, desc={2};"
                                        , m_tableName
                                        , udTeam.name
                                        , udTeam.desc
                                    );

            w_ret = DbAssist.executeCommand(w_query);
            return w_ret;
        }

        bool DeleteProdcut(ITeam delTeam)
        {
            bool w_ret = false;

            string w_query = string.Format(@"DELETE FROM {0} WHERE id={1};"
                            , m_tableName
                            , delTeam.id
                        );

            w_ret = DbAssist.executeCommand(w_query);

            return w_ret;
        }

        IList<ITeam> GetProducts()
        {
            IList<ITeam> w_list = new List<ITeam>();

            string w_query = string.Format(@"SELECT * FROM {0};"
                , m_tableName
            );

            SQLiteDataReader w_reader = DbAssist.executeQuery(w_query);
            if (w_reader != null)
            {
                while (w_reader.Read())
                {
                    Team w_item = new Team();
                    //. 01 - id
                    w_item.id = w_reader.GetInt32(0);
                    //. 02 - name
                    w_item.name = w_reader.GetString(1);
                    //. 03 - desc
                    w_item.desc = w_reader.GetString(2);

                    w_list.Add(w_item);
                }
            }

            return w_list;
        }
    }
}
