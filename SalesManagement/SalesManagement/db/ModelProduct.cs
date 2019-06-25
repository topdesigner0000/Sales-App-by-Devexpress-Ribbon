using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace SalesManagement.db
{
    interface IProduct
    {
        int id { get; set; }
        string name { get; set; }
        string type { get; set; }
        float cost { get; set; }
        float price { get; set; }
        float weight { get; set; }
        int invisible { get; set; }
    }

    class Product : IProduct
    {
        private int _id;
        private string _name;
        private string _type;
        private float _cost;
        private float _price;
        private float _weight;
        private int _invisible;

        public Product()
        {

        }

        public Product(string name, string type, float cost, float price)
        {
            this.name = name;
            this.type = type;
            this.cost = cost;
            this.price = price;
            this.weight = ((price-cost) / cost) * 100.0f;
            this.invisible = 1;
        }

        public int id { get { return _id; } set { _id = value; } }
        public string name { get { return _name; } set { _name = value; } }
        public string type { get { return _type; } set { _type = value; } }
        public float cost { get { return _cost; } set { _cost = value; } }
        public float price { get { return _price; } set { _price = value; } }
        public float weight { get { return _weight; } set { _weight = value; } }
        public int invisible { get { return _invisible; } set { _invisible = value; } }
    }


    class ModelProduct
    {
        string m_tableName = "tbl_product";

        public ModelProduct()
        {
        }

        ~ModelProduct()
        {
        }

        public bool AddItem(IProduct newItem)
        {
            bool w_ret = false;
            string w_query = string.Format(@"INSERT INTO {0} (name, type, cost, price, weight, invisible) VALUES ('{1}', '{2}', '{3}', '{4}', '{5}', '{6}')"
                                        , m_tableName
                                        , newItem.name
                                        , newItem.type == "Group" ? 1 : 0
                                        , newItem.cost
                                        , newItem.price
                                        , newItem.weight
                                        , newItem.invisible
                                    );

            w_ret = DbAssist.executeCommand(w_query);
            return w_ret;
        }

        public bool UpdateItem(IProduct udProduct)
        {
            bool w_ret = false;
            string w_query = string.Format(@"UPDATE {0} SET name='{1}', type='{2}', cost='{3}', price='{4}', weight='{5}', invisible='{6}' WHERE id='{7}';"
                                        , m_tableName
                                        , udProduct.name
                                        , udProduct.type == "Group" ? 1 : 0
                                        , udProduct.cost
                                        , udProduct.price
                                        , udProduct.weight
                                        , udProduct.invisible
                                        , udProduct.id
                                    );

            w_ret = DbAssist.executeCommand(w_query);
            return w_ret;
        }

        public bool DeleteItem(IProduct delProduct)
        {
            bool w_ret = false;

            string w_query = string.Format(@"DELETE FROM {0} WHERE id='{1}';"
                            , m_tableName
                            , delProduct.id
                        );

            w_ret = DbAssist.executeCommand(w_query);

            return w_ret;
        }

        public IList<IProduct> GetItemList()
        {
            IList<IProduct> w_list = new List<IProduct>();

            string w_query = string.Format(@"SELECT * FROM {0};"
                , m_tableName
            );

            SQLiteDataReader w_reader = DbAssist.executeQuery(w_query);
            if (w_reader != null)
            {
                while (w_reader.Read())
                {
                    Product w_item = new Product();
                    //. 01 - id
                    w_item.id = w_reader.GetInt32(0);
                    //. 02 - name
                    w_item.name = w_reader.GetString(1);
                    //. 03 - type
                    w_item.type = w_reader.GetInt32(2) == 1 ? "Group" : "Individual";
                    //. 04 - cost
                    w_item.cost = w_reader.GetFloat(3);
                    //. 05 - price
                    w_item.price = w_reader.GetFloat(4);
                    //. 06 - weight
                    w_item.weight = w_reader.GetFloat(5);
                    //. 07 - disable
                    w_item.invisible = w_reader.GetInt32(6);

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
