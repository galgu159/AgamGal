using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgamGal
{
    class Product // מחלקת המוצר
    {
        private string name; // שם מוצר
        public Product(string name) 
        {
            this.name = name;
        }
        // GET SET
        public string GetName()
        {
            return this.name;
        }
        public void SetName(string a)
        {
            this.name = a;  
        }
    }
}
