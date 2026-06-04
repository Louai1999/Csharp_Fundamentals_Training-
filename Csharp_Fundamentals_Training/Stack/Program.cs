using System.Reflection.Metadata.Ecma335;

namespace Stack
{
    internal class Program
    {


        public static int menu()
        {
            Console.WriteLine("");
            Console.WriteLine("P1");
            Console.WriteLine("P2");
            Console.WriteLine("P3");
            Console.WriteLine("P4");
            Console.WriteLine("P5");
            Console.WriteLine("P6");
            Console.WriteLine("0. Exit");


            Console.WriteLine("==Select option==");
            return int .Parse(Console.ReadLine());

        }
        


        public static void p1()
        {
        Stack<string> browserHistory = new Stack<string>();
            browserHistory.Push("https://claude.ai/chat/ad0290ef-d5ae-4ca4-8aa0-aa549e411065");
            browserHistory.Push("https://www.youtube.com/watch?v=GG5ebyJPTtE&list=RDnc6whxRH8Zc&index=4");
            browserHistory.Push("https://drive.google.com/drive/folders/15Vrhbsj27PfhIjEO7i7l2Xrm2RPfkfNx");
            browserHistory.Push("https://www.w3schools.com/cs/cs_switch.php");
            browserHistory.Push("https://github.com/EngKarimSalah/CsharpCoureImplementaions/tree/master/BuiltInFunctions");


            foreach (string WebSite in browserHistory)

            { 
            Console.WriteLine($"Wep page are  {WebSite}");
            
            }
            browserHistory.Peek();


            browserHistory.Pop();
            browserHistory.Pop();


            foreach (string WebSite in browserHistory)

            {
                Console.WriteLine($"Wep page are  {WebSite}");

            }

            if (browserHistory.Contains("https://claude.ai/chat/ad0290ef-d5ae-4ca4-8aa0-aa549e411065") == true)
            {
                Console.WriteLine("The URL is here");
            }
            else
            {
                Console.WriteLine("We didint found it");
            }

          Console.WriteLine("This is the fainal total: " + browserHistory.Count);

        }


        public static void p2()
        {
            Queue<string>checkInQueue = new Queue<string>();
            checkInQueue.Enqueue("Guest Name : Salim");
            checkInQueue.Enqueue("Guest Name :Ahmed");
            checkInQueue.Enqueue("Guest Name :Hamid");
            checkInQueue.Enqueue("Guest Name :Mohammed");
            checkInQueue.Enqueue("Guest Name :Abdullah");

            foreach (string guest in checkInQueue)
            { 
            Console.WriteLine($"Guest name : {guest}");
            
            }

            checkInQueue.Peek();

            checkInQueue.Dequeue();
            checkInQueue.Dequeue();

            foreach (string guest in checkInQueue)
            {
                Console.WriteLine($"Remaining {guest}");
            }

            if (checkInQueue.Contains("mohammed") == true)
            {
                Console.WriteLine("Still waiting");
            }

            else
            {
                Console.WriteLine("Leave");
            }
            Console.WriteLine("Remaining guest" + checkInQueue.Count);

        }


        public static void p3()
        {
            Stack<string>undoStack = new Stack<string>();
            Stack<string>tempStack = new Stack<string>();
            undoStack.Push("Enter.1");
            undoStack.Push("Enter.2");
            undoStack.Push("Enter.3");
            undoStack.Push("Enter.4");
            undoStack.Push("Enter.5");
            undoStack.Push("Enter.6");
            undoStack.Push("Enter.7");


            foreach (string enter in undoStack)

            {
                Console.WriteLine("Finde" + enter);
            }

            undoStack.Peek();

            Console.WriteLine(undoStack.Pop());
            Console.WriteLine(undoStack.Pop());

            tempStack.Push(undoStack.Pop());
            tempStack.Push(undoStack.Pop());
            undoStack.Pop();
            undoStack.Push(tempStack.Pop());
            undoStack.Push(tempStack.Pop());

            Console.WriteLine("This the final Action:" + tempStack);




        }


        public static void p4()
        {

        }


        public static void p5()
        {

        }


        public static void p6()
        {

        }











        static void Main(string[] args)
        {
            bool lop = true;
            do
            {

                switch (menu()) 

                {

                    case 1:
                        p1();
                        break;


                    case 2:
                        p2 ();
                        break;



                    case 3:
                        p3();
                        break;


                    case 4:
                        p4();
                        break;


                    case 5:
                        p5 ();
                        break;


                    case 6:
                        p6();
                        break;

                    default:
                        Console.WriteLine("Please select another option");
                        break;



                }

                Console.WriteLine("Plese select option");
                Console.ReadKey();
                Console.Clear();





            } while (lop == true) ;



        }
    }
}
