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
            order[0] = new ResultOrder("name", OrderDirection.Ascending);
            return client.Select("categories",null,null,fields,e,order);
        }
        public static DataTable getBrands()
        {
            List<string> fields = new List<string>();
            Expression e = new Expression();
            ResultOrder[] order = new ResultOrder[1];
            order[0] = new ResultOrder("name", OrderDirection.Ascending);
            return client.Select("brands", null, null, fields, e,order);
        }
        public static DataTable search(string query)
        {
            List<string> fields = new List<string>();
            char[] delimeters = { };
            string[] keywords = query.Split(delimeters, StringSplitOptions.RemoveEmptyEntries);
            string expression = "(1=1)";
           
            foreach (string s in keywords)
            {
                expression += " AND ((`productname` LIKE '%" + s + "%') OR (`brand` LIKE '%" + s + "%') OR (`category` LIKE '%" + s + "%'))";
              
            }
           
            return client.Query("SELECT * from `inventory` WHERE " + expression + " ORDER BY productname;");
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
            d = new Dictionary<string, object>();
            d.Add("brand", newName);
            client.Update("inventory", d, new Expression("brand", Operators.Equals, oldName));
        }
        public static void updateCategory(string oldName, string newName)
        {
            Dictionary<string, object> d = new Dictionary<string, object>();
            d.Add("name", newName);
            client.Update("categories", d, new Expression("name", Operators.Equals, oldName));
            d = new Dictionary<string, object>();         
            d.Add("category", newName);
            client.Update("inventory", d, new Expression("category", Operators.Equals, oldName));
        }
        public static DataTable getItemsInCategory(string category)
        {
            return client.Select("inventory", null, null, new List<string>(), new Expression("category", Operators.Equals, category));
        }
        public static DataTable getItemsInBrand(string brand)
        {
            return client.Select("inventory", null, null, new List<string>(), new Expression("brand", Operators.Equals, brand));
        }
        public static DataTable getOutOfStock()
        {
            return client.Select("inventory", null, null, new List<string>(), new Expression("quantity", Operators.LessThanOrEqualTo, 0));
        }
        public static void updateProductQuantity(int id, int quantity)
        {
            Dictionary<string, object> d = new Dictionary<string, object>();
            d.Add("quantity", quantity);
            client.Update("inventory", d, new Expression("id", Operators.Equals, id));
        }            

        public static DataTable getAllSales()
        {               
           return client.Select("sales", null, null, new List<string>(), new Expression());
        }

        public static DataTable getItemsById()
        {                     
           return client.Select("inventory", null, null, new List<string>(), new Expression());
        }

    }
}
