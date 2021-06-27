using System;

namespace Mamas
{
    class Program
    {
        public static Boolean CheckStartMenuChoice(int choice)
        {
            return choice == 1 || choice == 2;
        }
        public static Boolean CheckNamesMenu(int choise, Worker[] workers){
            return choise >= 0 && choise < workers.Length;
        }
        public static void ShowAllNames(Worker [] workers)
        {
            for(int i=0; i<workers.Length; i++)
            {
                Console.WriteLine("Press " + i + " - " + workers[i].name);
            }
        }
        public static void ShowStartMenu()
        {
            Console.WriteLine("Do you want to :");
            Console.WriteLine("Press 1 - Get in / out");
            Console.WriteLine("Press 2 - Show your salary up to now");
        }
        public static void ShowInOutMenu()
        {
            Console.WriteLine("Do you want to :");
            Console.WriteLine("Press 1 - Get in");
            Console.WriteLine("Press 2 - Get out");
        }
        public static void Main(string[] args)
        {
            Worker [] workers = new Worker[5];
            workers[0] = new Chef("Dorin");
            workers[1] = new Doctor("Lior");
            workers[2] = new Intern("Coral");
            workers[3] = new Intern("Sharon");
            workers[4] = new Cleaner("Thomas");

            while(true) {
                ShowStartMenu();
                int choice = int.Parse(Console.ReadLine());
                if(CheckStartMenuChoice(choice))
                {
                    ShowAllNames(workers);
                    int choiseName = int.Parse(Console.ReadLine());
                    if(CheckNamesMenu(choiseName, workers))
                    {
                        Worker temp = workers[choiseName];
                        if (choice == 1) 
                        {
                            // Put hours
                            ShowInOutMenu();
                            int choiceInOut = int.Parse(Console.ReadLine());
                            if(CheckStartMenuChoice(choiceInOut))
                            {
                                if (choiceInOut == 1)
                                {
                                    temp.InsertStartHour();
                                }
                                if (choiceInOut == 2)
                                {
                                    temp.InsertEndHour();
                                }
                                Console.WriteLine("I puted you in");
                            }
                            else
                            {
                                Console.WriteLine("Wrong input stupid !");
                            }
                        }
                        if (choice == 2) {
                            // Get Salart
                            double salary = temp.GetSalary();
                            Console.WriteLine(temp.name + "'s salary is : " + salary);
                        }
                    }
                    else
                    {
                        Console.WriteLine("Wrong input");
                    }

                }
                else
                {
                    Console.WriteLine("You can enter only 1 or 0");
                }

                Console.WriteLine();
                Console.WriteLine("***************************************");
                Console.WriteLine();

            }
        }
    }
}
