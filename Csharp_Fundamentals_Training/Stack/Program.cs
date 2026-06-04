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
        


        }


        public static void p2()
        {

        }


        public static void p3()
        {

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
