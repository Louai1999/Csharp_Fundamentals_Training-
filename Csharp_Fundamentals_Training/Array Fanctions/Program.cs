using System.Runtime.InteropServices;

namespace Array_Fanctions
{
    internal class Program
    {
        //Storage vareple

        static double[] temperatures;

        static int[] studentScores ;

        static double[] productPrises;

        static int[] finishTimes;

        static int[] grades;



/// ///////////////////////////////////////////////////////////////////

        // First array temperatures
       public static void temperature() {
            double[] temperature = new double[] { 2.2, 3.3, 4.4, 5.5, 6.6, 7.7, 8.8 };

            for (int i = 0; i < temperature.Length; i++)   /// We useit for loob 
            {
                Console.WriteLine("Day " + (i + 1) + ": " + temperature[i] + " C");

            }
            Console.WriteLine("Total readings: " + temperature.Length);

        }

        //Student Score Board
        public static void studentScore ()
        {
            int[] studentScore = {90,80,75,60,55,50};


            foreach (int i in studentScores)
            {                                          
                Console.WriteLine(i);
            }


           Array.Reverse(studentScore);
            foreach (int i in studentScores)
            {  Console.WriteLine(i); }

        }

        //Product Price Finder
        public static void productPrise()
        {
            double[] productPrise = new double[] { 4.99, 9.99, 14.99, 19.99, 24.99 };
            for (int i = 0;i < productPrise.Length; i++)
            {
                Console.WriteLine("Product " + (i + 1) + ": " + productPrise[i]);
            }

            Array.IndexOf()
        }


        //Race Finich Time 
        public static void finishTime( )
        { }

        //Classroom Grade Report 
        public static void grade( )

        { }








        static void Main(string[] args)
        {
            switch (args.Length) {

                case 1:
                    temperature();
                    break;

                case 2:
                    studentScore();

                    break;
                case 3:
                    break;

                case 4:
                    break;

                case 5:
                    break;

                case 6:
                    break;

                case 7:
                    break;



            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            }
                 
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            





            }

            
        }
    }

