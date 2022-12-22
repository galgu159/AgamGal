using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgamGal
{
    class Employee
    {
        private string name; // שם העובד
        private double[,] workHours; // מערך של שעות עבודה מספר קופה שעבד עליה ותאריך העבודה
        private Queue<Costumer> queueCostumerCash;

        public Employee(string name)
        {
            this.name = name;
            this.workHours = new double[4, 7];
        }
        public Employee(string name, Queue<Costumer> queueCostumerCash)
        {
            this.name = name;
            this.workHours = new double[4, 7];
            this.queueCostumerCash = queueCostumerCash;
        }
        public void SetQueueCash(Queue<Costumer> queueCostumerCash)
        {
            this.queueCostumerCash=queueCostumerCash;
        }
        public Queue<Costumer> GetQueueCash()
        {
            return this.queueCostumerCash;
        }
        public string GetName()
        {
            return this.name;
        }
        public void SetName(string name)
        {
            this.name = name;
        }
        
        public double AddWorkHour() // הוספת פרטי עבודת העובדים השבועית שלהם והחזרת שעות העבודה שלהם
        {
            double startHour = 0;
            double endHour = 0;
            double CashRegisterNum; 
            double Counter =0;
            string nameEmployee;
            double Date;
            double temp;

            Console.WriteLine("Enter details about your work in this week");
            for (int t = 0; t < 7; t++)
            {
                Console.WriteLine("Enter the date");
                Date = double.Parse(Console.ReadLine());
                Console.WriteLine("When did you start to working ? hour 1- 24");
                startHour = double.Parse(Console.ReadLine());
                Console.WriteLine("When did you end to working ? hour 1- 24");
                endHour = double.Parse(Console.ReadLine());
                Console.WriteLine("Which CashRegister ? please enter with number 0,1,2,3..");
                CashRegisterNum = double.Parse(Console.ReadLine());
                if (endHour - startHour > 0)
                    Counter = Counter + (endHour - startHour);
                else
                    Console.WriteLine("You don't write well the work hours");
                this.workHours[0, t] = Date;
                this.workHours[1, t] = startHour;
                this.workHours[2, t] = endHour;
                this.workHours[3, t] = CashRegisterNum;
                
            }
            return Counter * 30;
        }
        public double GetDate(int i)
        {
            return this.workHours[0, i];
        }

        public void AddqueueCostumerCash(Costumer c)
        {
            this.queueCostumerCash.Enqueue(c);
        }
    }
}
