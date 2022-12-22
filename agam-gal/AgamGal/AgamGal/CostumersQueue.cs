using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgamGal
{
    class CostumersQueue // מחלקת תור הלקוחות שמחכים בחוץ 
    {
        private Queue<Costumer> ququeCostumers; // מקבלת תור של לקוחות
        private int counter; // משתנה שיספור את מספר איברי התור
        public CostumersQueue()
        {
            ququeCostumers= new Queue<Costumer>();
            counter = 0;
        }
        public CostumersQueue(Queue<Costumer> ququeCostumers, int counter)
        {
            this.ququeCostumers = ququeCostumers;
            this.counter = counter;
        }
        public int GetCounter()
        {
            return this.counter;
        }
        public void AddCostumer(Costumer c) // הוספת לקוח לתור
        {
            ququeCostumers.Enqueue(c);
            this.counter++;
        }
        public Costumer AllowIn(int num) //  הכנסת לקוח מהתור לחנות והחזרת הערך של הלקוח שהוצאנו מהתור 
        {
            Costumer c1;
            if (counter >= num)
            {
                this.counter--;
                c1 = ququeCostumers.Dequeue();
                Console.WriteLine("The costumer add to the store!");
                return c1;
            }
            else
                Console.WriteLine("The costumers did not add to the store");
            return null;
        }
        public void PrintCostumers() // הדפסת תור הלקוחות ברגע נתון
        {
            if (counter == 0)
                Console.WriteLine("there is not costumer in the queue");
            else
                for(int i=0; i<counter; i++)
                {
                    Costumer c= ququeCostumers.Dequeue();
                    c.Print();
                    ququeCostumers.Enqueue(c);
                }
        }
    }
}
