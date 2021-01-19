using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DatabaseWrapper.Core;
using DatabaseWrapper.Mysql;
using ClosedXML.Excel;
using ClosedXML.Attributes;
using ClosedXML.Utils;
using System.IO;
using System.Windows.Forms;

namespace VPsemesterProject
{
    class Cart
    {
        public DataTable data = new DataTable();
        public List<int> ids = new List<int>();
        Dictionary<int, int> stock = new Dictionary<int, int>();
        public Cart()
        {
            data.Columns.Add("id", typeof(int));
            data.Columns.Add("productname",typeof(string));
            data.Columns.Add("category",typeof(string));
            data.Columns.Add("brand",typeof(string));
            data.Columns.Add("price",typeof(int));
            data.Columns.Add("amount",typeof(int));
        }
        public void remove(int index)
        {
            ids.Remove(data.Rows[index].Field<int>("id"));
            stock.Remove(data.Rows[index].Field<int>("id"));
            data.Rows[index].Delete();
        }
        public void add(DataRow row)
        {
            DataRow n = data.NewRow();
            n["id"] = row["id"];
            n["productname"] = row["productname"];
            n["category"] = row["category"];
            n["brand"] = row["brand"];
            n["price"] = row["price"];
            n["amount"] = 1;
            ids.Add(row.Field<int>("id"));
            stock.Add(row.Field<int>("id"), row.Field<int>("quantity"));
            data.Rows.Add(n);
        }
        public void changeAmount(int index, int amount)
        {
            int inStock;
            stock.TryGetValue(data.Rows[index].Field<int>("id"),out inStock);
            if (inStock < amount)
                throw new Exception("Amount excedes the number of items in stock");
            else
            {
                data.Rows[index].SetField<int>("amount", amount);
            }
        }
        public void checkOut(CartForm current)
        {
            if (data.Rows.Count == 0)
                throw new Exception("There are no Items in cart");
            else
            {
                MakeSaleForm mksl = new MakeSaleForm(data,current);
                mksl.Show();
            }            
        }
        public void makeSale(DataTable table, string salesid,int bill, int recievedAmount)
        {
            for(int i=0; i< table.Rows.Count-1;i++)
            {
                DataRow r = table.Rows[i];
                int inStock;
                stock.TryGetValue(r.Field<int>("id"), out inStock);
                Connection.updateProductQuantity(r.Field<int>("id"), inStock - r.Field<int>("amount"));
            }
            DataRow recieved = table.NewRow();
            recieved.SetField<string>("productname", "Amount Recieved");
            recieved.SetField<int>("total", recievedAmount);
            table.Rows.Add(recieved);
            DataRow remainder = table.NewRow();
            remainder.SetField<string>("productname", "Remainder");
            remainder.SetField<int>("total", recievedAmount - bill);
            table.Rows.Add(remainder);
            XLWorkbook wb = new XLWorkbook();
            wb.Worksheets.Add(table, "sheet1");
            wb.SaveAs("reciepts\\" + salesid + ".xlsx");
            data.Clear();
            ids.Clear();
            stock.Clear();

            Dictionary<string, object> d = new Dictionary<string, object>();
            d.Add("salesid", salesid);
            Connection.client.Insert("sales", d);
        }
    }

    class Instance
    {
        public static Cart cart = new Cart();
    }
}
