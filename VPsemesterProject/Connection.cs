using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatabaseWrapper.Core;
using DatabaseWrapper.Mysql;
using System.Data;

namespace VPsemesterProject
{
    class Connection
    {
        public static DatabaseSettings settings = new DatabaseSettings(DbTypes.Mysql,"localhost", 3306, "root", "pakistan", "vp");
        public static DatabaseClient client = new DatabaseClient(settings);

        public static void addProduct(string productName, string category, string brand, int price, int quantity)
        {
            Dictionary<string, object> d = new Dictionary<string, object>();
            d.Add("productname", productName);
            d.Add("category", category);
            d.Add("brand", brand);
            d.Add("price", price);
            d.Add("quantity", quantity);
            client.Insert("inventory", d);
        }
        public static void addCategory(string name)
        {
            Dictionary<string, object> d = new Dictionary<string, object>();
            d.Add("name", name);
            client.Insert("categories", d);
        }
        public static void addBrand(string name)
        {
            Dictionary<string, object> d = new Dictionary<string, object>();
            d.Add("name", name);
            client.Insert("brands", d);
        }
        public static DataTable getCategories()
        {
            List<string> fields = new List<string>();
            Expression e = new Expression();
            ResultOrder[] order = new ResultOrder[1];
            order[1] = new ResultOrder("name", OrderDirection.Ascending);
            return client.Select("categories",0,0,fields,e,order);
        }
        public static DataTable getBrands()
        {
            List<string> fields = new List<string>();
            Expression e = new Expression();
            ResultOrder[] order = new ResultOrder[1];
            order[1] = new ResultOrder("name", OrderDirection.Ascending);
            return client.Select("brands", 0, 0, fields, e,order);
        }
        public static DataTable search(string query)
        {
            List<string> fields = new List<string>();
            char[] delimeters = { };
            string[] keywords = query.Split(delimeters, StringSplitOptions.RemoveEmptyEntries);
            Expression e = new Expression("id",Operators.NotEquals,null);
            foreach (string s in keywords)
            {
                Expression t = new Expression("productname", Operators.Contains, s);
                t = new Expression {
                    LeftTerm = new Expression("brand", Operators.Contains, s),
                    Operator = Operators.Or,
                    RightTerm = t
                };
                t = new Expression{
                    LeftTerm = new Expression("category", Operators.Contains, s),
                    Operator = Operators.Or,
                    RightTerm =t
                };
                e = new Expression(e, Operators.And, t);
            }
            return client.Select("inventory", 0, 0, fields, e);
        }
        public static void deleteProduct(int id)
        {
            Expression e = new Expression("id", Operators.Equals, id);
            client.Delete("inventory", e);
        }
        public static void deleteBrand(string brand)
        {
            client.Delete("inventory", new Expression("brand", Operators.Equals, brand));
            client.Delete("brands", new Expression("name", Operators.Equals, brand));
        }
        public static void deleteCategory(string category)
        {
            client.Delete("inventory", new Expression("category", Operators.Equals, category));
            client.Delete("categories", new Expression("name", Operators.Equals, category));
        }
        public static void updateProduct(int id, string productName, string category, string brand, int price, int quantity)
        {
            Dictionary<string, object> d = new Dictionary<string, object>();
            d.Add("productname", productName);
            d.Add("category", category);
            d.Add("brand", brand);
            d.Add("price", price);
            d.Add("quantity", quantity);
            client.Update("inventory", d, new Expression("id", Operators.Equals, id));
        }
        public static void updateBrand(string oldName, string newName)
        {
            Dictionary<string, object> d = new Dictionary<string, object>();
            d.Add("name", newName);
            client.Update("brands", d, new Expression("name", Operators.Equals, oldName));
        }
        public static void updateCategory(string oldName, string newName)
        {
            Dictionary<string, object> d = new Dictionary<string, object>();
            d.Add("name", newName);
            client.Update("categories", d, new Expression("name", Operators.Equals, oldName));
        }
    }
}
