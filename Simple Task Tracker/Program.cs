namespace Simple_Task_Tracker
{
    internal class Program
    {
        static string[] tasks = new string[10];
        static int taskIndex = 0;
        static void Main(string[] args)
        {

            Console.WriteLine(" ** Simple Task Tracker ** \n +-+-+-+-+-+-+-+-+-+-+-+-+");
            while (true)
            {
                Console.WriteLine(" Enter your choice to modify your tasks !");
                Console.WriteLine(" 1.ADD TASK  2.VIEW TASKS \n 3.MARK A TASK COMPLETED \n 4.REMOVE TASK  5.EXIT");
                string userChoice = Console.ReadLine();

                switch (userChoice)
                {
                    case "1": 
                        AddTask();
                        break;

                    case "2": 
                        ViewTasks();
                        break;

                    case "3":
                        Completetask();
                        break;

                    case "4":
                        Removetask();
                        break;

                    case "5":
                        Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("Allowed numbers from 1~5 !!!");
                        break;
                }
            }


          
        }
        private static void AddTask()
        {
            Console.WriteLine("Enter your task :");
            string taskEntered = Console.ReadLine();
            tasks[taskIndex] = taskEntered;
            taskIndex++;
            Console.WriteLine(" task added ................;) \n ");
        }
        private static void ViewTasks()
        {
            Console.WriteLine("*** TASKS ***");
            for (int i = 0; i < taskIndex; i++)
            {
                Console.WriteLine($"{i+1} >>>> {tasks[i]}");
            }
        }
        private static void Completetask()
        {
            Console.WriteLine("Enter task number to mark complete");
            int taskNum =Convert.ToInt16(Console.ReadLine());
            tasks[taskNum] = tasks[taskNum]+"... Completed";

        }
        private static void Removetask()
        {
            Console.WriteLine("Enter task number to remove.");
            int taskNum = Convert.ToInt16(Console.ReadLine());
            // will find out a proper way to remove better later 7.april.24
            tasks[taskNum] =string.Empty;
            

        }

    }
}
