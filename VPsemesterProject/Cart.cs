using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VPsemesterProject
{
    struct Item
    {
        string brand;
        int id;
        int price;
    }
    class Cart
    {
        List<Item> list;
        Cart()
        {
            list = new List<Item>();
        }
        void remove(Item item)
        {
            list.Remove(item);
        }
        void add(Item item)
        {
            list.Add(item);
        }
    }
}
