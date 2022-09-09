using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Checkpoint2
{
    internal class Product
    {
        public string productName;
        public int price;
        public Category category;
        public bool search;

        public Product(string productName, int price, Category category)
        {
            this.productName = productName;
            this.price = price;
            this.category = category;
            this.search = false;
        }

        public class Category
        {
            public string name;
            public string brand;
            public string mod_res;

            public Category(string name, string brand, string mod_res)
            {
                this.name = name;
                this.brand = brand;
                this.mod_res = mod_res;
            }
        }
    }
}
