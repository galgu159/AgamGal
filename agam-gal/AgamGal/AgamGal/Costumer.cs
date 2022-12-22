using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgamGal
{
    class Costumer // מחלקת לקוח
    {
        private string name; // שם הלקוח
        private double temperature; // טמפ' חום גופו
        private bool mask; // מסכה
        private bool isolation; // האם צריך להיות בבידוד 
        private Stack<Product> products; // מחסנית עם כלל המוצרים שהלקוח קונה
        
        public Costumer(string name, double temperature, bool mask, bool isolation)
        {
            this.name = name;
            this.temperature = temperature;
            this.mask = mask;
            this.isolation = isolation;
        }
        public Costumer(string name, double temperature, bool mask, bool isolation, Stack<Product> products)
        {
            this.name = name;
            this.temperature = temperature;
            this.mask = mask;
            this.isolation = isolation;
            this.products = products;
        }
        // GET SET
        public string GetName()
        {
            return this.name;
        }
        public double GetTemp()
        {
            return this.temperature;
        }
        public bool GetMask()
        {
            return this.mask;
        }
        public bool GetIsolation()
        {
            return this.isolation;
        }
        
        public void SetName(string a)
        {
            this.name = a;
        }
        public void SetTemp(double a)
        {
            this.temperature = a;
        }
        public void SetMask(bool a)
        {
            this.mask = a;
        }
        public void SetIsolation(bool a)
        {
            this.isolation = a;
        }

        public void Print() // הדפסת פרטי הלקוח המלאים
        {
            Console.WriteLine("Name  " + name + "  temp  " + temperature + "  got mask  " + mask + "  is he isiolation  " + isolation);
        }
        public void SetProducts(Stack<Product> s)  // קבלת מחסנית המוצרים
        {
            this.products = s;
        }



    }
}
