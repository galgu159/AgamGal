using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;

namespace AgamGal
{
    class Program

    {
        
        static void Main(string[] args)
        {
            Console.WriteLine(" Welcome to AgamMacolet !!!");
            Console.WriteLine("We are in epidemic of Corona Virus ... ");
            Console.WriteLine("You must help us take control of the queues to the store");
            Console.WriteLine("and queues at the tills");
            Console.WriteLine("In the store there are 2 cash register");
            Console.WriteLine("Employee and costumer with high temperature, whitout a mask or needs to be in isolation will not enter to the AgamMacolet.");
            Console.WriteLine("In addition, employee that not listen to the rule need to pay 40 shekels.");
            Console.WriteLine("   ");
            Console.WriteLine("To get started, you have to answer a few questions");
            //Console.WriteLine("How many cash register are there in the store? (1-10)");
            //string cashRTemp= Console.ReadLine();
            //while (cashRTemp != "1" && cashRTemp != "2" && cashRTemp != "3" && cashRTemp != "4" && cashRTemp != "5" && cashRTemp != "6" && cashRTemp != "7" && cashRTemp != "8" && cashRTemp != "9" && cashRTemp != "10")
            //{
            //    Console.WriteLine(" Invalide input, please enter another number");
            //    cashRTemp = Console.ReadLine();
            //}
            //int cashR=int.Parse(cashRTemp); //  מספר הקופות בחנות
            //CashRegister[] ArrCash = new CashRegister[cashR]; // מערך של קופות בחנות


            Console.WriteLine("How many employees are there in the store? (1-10)"); //מספר העובדים בחנות
            string NumOfEmployeeTemp = Console.ReadLine();
            while (NumOfEmployeeTemp != "1" && NumOfEmployeeTemp != "2" && NumOfEmployeeTemp != "3" && NumOfEmployeeTemp != "4" && NumOfEmployeeTemp != "5" && NumOfEmployeeTemp != "6" && NumOfEmployeeTemp != "7" && NumOfEmployeeTemp != "8" && NumOfEmployeeTemp != "9" && NumOfEmployeeTemp != "10")
            {
                Console.WriteLine(" Invalide input, please enter another number");
                NumOfEmployeeTemp = Console.ReadLine();
            }
            int NumOfEmployee = int.Parse(NumOfEmployeeTemp);

            

            Employee[] ArrEmployee = new Employee[NumOfEmployee]; // מערך של מספר עובדים בחנות
            //הכנסת שמות בעובדים בחנות
            for(int s=0; s<NumOfEmployee; s++)
            {
                int index1 = s - 1;
                string nameEmployee0;
                Console.WriteLine("Enter the name of employee " + index1);
                nameEmployee0= Console.ReadLine();
                ArrEmployee[s] = new Employee(nameEmployee0);
            }



            CostumersQueue QueueCostumers = new CostumersQueue();// פתיחה של תור לקוחות שמחכים בחוץ 



            // בניית הקופות ואנשים שמחכים בתור של הקופות

            Costumer c1 = new Costumer("gal", 36, true, false);
            Costumer c2 = new Costumer("shira", 36, true, false);
            Costumer c3 = new Costumer("viki", 36, true, false);
            Costumer cTemp = new Costumer("Temp", 36, true, false); //לקוח בדיקה כדי לדעת שהמחסנית ריקה

            Queue<Costumer> q3 = new Queue<Costumer>();
            Queue<Costumer> q4 = new Queue<Costumer>();

            Queue<Costumer> q1 = new Queue<Costumer>();
            q1.Enqueue(c1);
            q1.Enqueue(c2);
            Queue<Costumer> q2 = new Queue<Costumer>();
            q2.Enqueue(c3);
            int counter1 = 2;
            int counter2 = 1;

            
            // הגדרת הקופות
            CashRegister cashRegister1 = new CashRegister(q1, counter1, q3);
            CashRegister cashRegister2 = new CashRegister(q2, counter2, q4);


            CashRegister[] ArrCash = new CashRegister[2]; // מערך של קופות בחנות
            ArrCash[0] = cashRegister1;
            ArrCash[1] = cashRegister2;


            
            // הסבר על לחיצת המקשים על מנת לפעול לפי הפקודות
            Console.WriteLine("Hello cosrumer, please follow the intruction");
            Console.WriteLine("1. Putting a customer in line at the store entrance ");
            Console.WriteLine("2. Let costumer in to the store");
            Console.WriteLine("3. Print list of costumers that are in line of enter");
            Console.WriteLine("4. Exit from this sysyem");
            Console.WriteLine("5. For employee ---- Stamping the weekly working hours - follow your intruction");
            Console.WriteLine("6. If you are Employee in cash register");
            Console.WriteLine("7. Isolation of Corona ");

            // הכנסת המספר על מנת להגיע לשלב הבא
            string temp = Console.ReadLine();
            // נוודא שהכניסו מספר בין 1-4 ולא משהו אחר 
            while (temp != "1" && temp != "2" && temp != "3" && temp != "4" && temp != "5" && temp != "6" & temp != "7" & temp != "10")
            {
                Console.WriteLine(" Invalide input, please enter another number");
                temp = Console.ReadLine();
            }
            int num = int.Parse(temp);

            while (num != 4) //  (כל עוד המספר לא שווה 4 (שזה יציאה מהלולאה 
            {
                

                // הכנסת אנשים לתור האנשים שמחכים מחוץ לחנות
                if (num == 1)
                {
                    string name;
                    double temperature;
                    bool mask;
                    bool isolation;
                    Console.WriteLine("What is the name of costumer ?");
                    name = Console.ReadLine();
                    Console.WriteLine("What is the temperature of costumer ?");
                    temperature = double.Parse(Console.ReadLine());
                    Console.WriteLine("The costumer are wearing mask? ( true / false) ");
                    temp = Console.ReadLine();
                    while (temp != "true" && temp != "false")
                    {
                        Console.WriteLine("Invalide input, please enter another inpute");
                        temp = Console.ReadLine();
                    }
                    mask = bool.Parse(temp);
                    Console.WriteLine("Costumer need to be in isolation ? ( true / false )");
                    temp = Console.ReadLine();
                    while (temp != "true" && temp != "false")
                    {
                        Console.WriteLine("Invalide input, please enter another inpute");
                        temp = Console.ReadLine();
                    }
                    isolation = bool.Parse(temp);

                    if (temperature < 38 && mask == true && isolation == false)
                    {
                        Costumer c = new Costumer(name, temperature, mask, isolation);
                        QueueCostumers.AddCostumer(c);
                        Console.WriteLine("This person add to the list successful!");
                    }
                    else
                        Console.WriteLine("This person is not add to the list successful becouse Corona's rules");

                }


                // הכנסת אנשים מהתור בחוץ למכולת לקופה הקצרה ביותר
                if (num == 2)
                {
                    int numCostumerIn;
                    Console.WriteLine("How many people can enter to the agamacolet ?");
                    numCostumerIn = int.Parse(Console.ReadLine());
                    if(numCostumerIn > QueueCostumers.GetCounter())
                    {
                        Console.WriteLine("There aren't enough people in line outside, please try again");
                        numCostumerIn = int.Parse(Console.ReadLine());
                    }
                    Costumer c4;


                    for (int d = 0; d <= numCostumerIn; d++) // חוזר על עצמו לפי מספר האנשים שאמורים להיכנס למכולת 
                    {
                        
                        if (numCostumerIn <= QueueCostumers.GetCounter())
                        {
                            c4 = QueueCostumers.AllowIn(1); // הכנסת לקוחות לחנות והחזרת הלקוח שהיה בתור

                            int MinCash = ArrCash[0].GetCounter(); // מוצא את המספר המינימלי של הלקוחות שמחכים בקופה
                            int CounterArray = 0; // שומר על המיקום של הקופה הקצרה ביותר בתור במערך הקופות
                            for (int m = 0; m < ArrCash.Length; m++)
                            {
                                if (MinCash > ArrCash[m].GetCounter())
                                {
                                    MinCash = ArrCash[m].GetCounter();
                                    CounterArray = m;
                                }
                            }
                            ArrCash[CounterArray].AddCostumerQ(c4); //הוספת הלקוח לתור שנמצא בקופה הכי קצרה
                            Console.WriteLine("The costumer ");
                            c4.Print();
                            CounterArray++;
                            Console.WriteLine(" is added to the cash register number " + CounterArray);

                        }

                    }

                }

                // הדפסת האנשים שמחכים בתור בחוץ
                if (num == 3)
                {
                    QueueCostumers.PrintCostumers();
                }

                if (num == 5) //הכנסת פרטי עובד שבועית וגביית הקנס במידה ולא עמד בתנאי הקורונה 
                {
                    Console.WriteLine("Hello to the employees! The week is finally over now each of you must enter your working hours for the week");
                    Employee e;
                    double payment = 0;
                    string answer;
                    string nameEmployee;
                    Console.WriteLine("hello employees!! please follow the intruction ");
                    if (NumOfEmployee > 0)
                    {
                        for (int g = 0; g < NumOfEmployee; g++)
                        {

                            Console.WriteLine("The name of employee is " + ArrEmployee[g].GetName());
                  
                            e = ArrEmployee[g];
                            payment = e.AddWorkHour();

                            ArrEmployee[g] = e;
                            Console.WriteLine("The employee follow the rules ? (Yes or No)" );
                            answer = Console.ReadLine();
                            while (answer != "Yes" && answer != "No" && answer != "yes" && answer != "no")
                            {
                                Console.WriteLine("Try Again");
                                answer = Console.ReadLine();
                            }
                            if (answer == "Yes" || answer == "yes")
                                Console.WriteLine("PAYMENT   " + payment);
                            else
                            {
                                payment = payment - 40;
                                Console.WriteLine("The employee need to pay 40 shekels. His Payment will be " + payment);

                            }


                        }

                    }

                }



                if (num == 6) // ריקון התור בקופה ושמירת האנשים שעברו בקופה בבמערך הקופות ושמירת המוצרים שכל לקוח קנה במחסנית המוצרים של כל לקוח
                {
                    int x1=0, x3;
                    string x2;
                    Console.WriteLine("Enter you work number 1-"+NumOfEmployee);
                    x2= Console.ReadLine();
                    while (x2 != "1" && x2 != "2" && x2 != "3" && x2 != "4" && x2 != "5" && x2 != "6" && x2 != "7" && x2 != "8" && x2 != "9" && x2 != "10")
                    {
                        Console.WriteLine("try again");
                        x2 = Console.ReadLine();
                    }
                    x1 = int.Parse(x2);
                    

                    x1--;
                    Queue<Costumer> queueCostumerCashe = new Queue<Costumer>();
                    string workCashTemp;
                    int workCash; //מספר הקופה
                    Console.WriteLine("which of cash register do you work ?");
                    workCashTemp = Console.ReadLine();
                    while(workCashTemp != "1" && workCashTemp != "2")
                    {
                        Console.WriteLine("There are 2 cash registers, please try again");
                        workCashTemp= Console.ReadLine();
                    }
                    workCash = int.Parse(workCashTemp);
                    workCash--;
                    Console.WriteLine(ArrCash[workCash].GetCounter());
                    if (ArrCash[workCash].GetCounter() != 0)
                    {
                        while (0 < ArrCash[workCash].GetCounter()) // אם התור לא ריק
                        {
                            Costumer c = ArrCash[workCash].RemoveCostumerQ(); //הראשון שבתור 
                            c.Print();
                            queueCostumerCashe.Enqueue(c);
                            ArrCash[workCash].AddCostumerQOut(c); // העברת הלקוח מהתור למחסנית האנשים היו בקופה
                            string w2;
                            Console.WriteLine("Enter what did you buy? in the end write 0 ?");
                            w2 = Console.ReadLine();
                            Stack<Product> SProduct = new Stack<Product>();
                            while (w2 != "0")
                            {
                                Product p = new Product(w2);
                                SProduct.Push(p);
                                Console.WriteLine("Enter what did you buy? in the end write 0 ?");
                                w2 = Console.ReadLine();
                            }
                            c.SetProducts(SProduct);
                        }
                    }
                    else
                        Console.WriteLine("The cash is empty from costumers ...");
                    ArrEmployee[x1].SetQueueCash(queueCostumerCashe); //תור של לקוחות שעברו אצל העובד שמספר העובד שלו הוא X1

                }


                if (num == 7) // בידוד לקורונה
                {
                    int numCashR, m = 0;
                    string numCashTemp;
                    Console.WriteLine("Whice of the CASHREGISTER have corona?");
                    numCashTemp = Console.ReadLine();
                    while (numCashTemp != "1" && numCashTemp != "2")
                    {
                        Console.WriteLine("There is not such register");
                        numCashTemp = Console.ReadLine();
                    }
                    numCashR = int.Parse(numCashTemp);

                    numCashR--;
                    string nameCostumCorona;
                    Console.WriteLine("What is the name of sick human ?");
                    nameCostumCorona = Console.ReadLine();


                    int test = ArrCash[numCashR].GetCounter1();
                    if ( test == 0)
                        Console.WriteLine("No one was in this cash ..");
                    else
                    {
                        Costumer[] arrCorona = new Costumer[counter1]; //מערך האנשים שהיו בקופה לפי סדר 

                        for (int i = 0; i < test; i++) 
                        {
                            Costumer cTest = ArrCash[numCashR].RemoveCostumerQOut();
                            arrCorona[i] = cTest;
                            ArrCash[numCashR].AddCostumerQOut(cTest);
                        }
                        for(int t = 0; t< arrCorona.Length; t++)
                        {
                            if (arrCorona[t].GetName() == nameCostumCorona)
                            {
                                if (t == 0 && arrCorona.Length == 1)
                                    Console.WriteLine("No one from the costumer need to be in isolation");
                                else if (t == 0 && t <= arrCorona.Length)
                                    Console.WriteLine("The costumer " + arrCorona[t + 1].GetName() + " need isolation");
                                else if (t == arrCorona.Length - 1)
                                    Console.WriteLine("The costumer " + arrCorona[t - 1].GetName() + " need isolation");
                                else
                                    Console.WriteLine("The costumer " + arrCorona[t - 1].GetName() + " and the costumer " + arrCorona[t + 1].GetName() + " need isolation");
                                
                                //נבדוק מתי הלקוח היה כדי לראות איזה קופאי היה ולהכניס אותו לבידוד
                                for(int a=0; a<ArrEmployee.Length; a++)
                                {
                                    Queue<Costumer> qTry = new Queue<Costumer>();
                                    qTry = ArrEmployee[a].GetQueueCash();
                                    if (qTry.Peek().GetName() != nameCostumCorona)
                                    {
                                        qTry.Dequeue();
                                    }
                                    else
                                        Console.WriteLine("Employee " + ArrEmployee[a].GetName() + " need isolation");
                                }
                            
                            }
                            else
                                m++;
                        }
                        if (m == arrCorona.Length)
                            Console.WriteLine("This name is not exist in this cash");
                    }
                    
                }
            
                Console.WriteLine("");
                Console.WriteLine("Hello cosrumer, please follow the intruction");
                Console.WriteLine("1. Putting a customer in line at the store entrance ");
                Console.WriteLine("2. Let costumer in to the store");
                Console.WriteLine("3. Print list of costumers that are in line of enter");
                Console.WriteLine("4. Exit from this sysyem");
                Console.WriteLine("5. For employee ---- Stamping the weekly working hours - follow your intruction");
                Console.WriteLine("6. If you are Employee in cash register");
                Console.WriteLine("7. Isolation of Corona ");
                
                // הכנסת המספר על מנת להגיע לשלב הבא
                temp = Console.ReadLine();
                // נוודא שהכניסו מספר בין 1-4 ולא משהו אחר 
                while (temp != "1" && temp != "2" && temp != "3" && temp != "4" && temp != "5" && temp != "6" & temp != "7" & temp != "10")
                {
                    Console.WriteLine(" Invalide input, please enter another number");
                    temp = Console.ReadLine();
                }
                num = int.Parse(temp);
            }





        }
        
        
    }
}