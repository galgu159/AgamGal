using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgamGal
{
    class CashRegister
    {
        private Queue<Costumer> QCostumers; //תור האנשים שמחכים בקופה
        private Queue<Costumer> QCostumersOut;
        private int counter1;
        private int counter; // סופר אנשים שמחכים בתור לקופה
        //private Costumer[] ArrCostumerBuy; // מערך אנשים היו בקופה

                                          
        public CashRegister(Queue<Costumer> QCostumers, int counter, Queue<Costumer> QCostumersOut)
        {
            this.QCostumers= QCostumers;
            this.counter = counter;
            this.QCostumersOut= QCostumersOut;
            this.counter1 = 0;

        }
        public void AddCostumerQ(Costumer c) // הוספת אנשים לתור שמחכה בקופה
        {
            QCostumers.Enqueue(c);
            counter++;
        }
        public Costumer RemoveCostumerQ() // הוצאת אנשים מהתור שמחכה לקופה
        {
            counter--;
            Costumer c = QCostumers.Dequeue();
            return c;
            
        }


        public void AddCostumerQOut(Costumer c) // הוספת אנשים לתור שהיה בקופה
        {
            QCostumersOut.Enqueue(c);
            counter1++;
        }
        public Costumer RemoveCostumerQOut() // הוצאת אנשים מהתור שהיה לקופה
        {
            counter1--;
            Costumer c = QCostumersOut.Dequeue();
            return c;

        }


        public int GetCounter() //מביא את מספר האנשים שנמצאים כרגע בתור 
        {
            return this.counter;
        }
        public int GetCounter1() //מביא את מספר האנשים שקנו באותו בתור 
        {
            return this.counter1;
        }
    }
}
