using System.ComponentModel.Design;

namespace ListsFunction
{
    internal class Program
    {
        //Menu Function
        public static string Menu()
        {
            Console.WriteLine("==Select Option==");
            Console.WriteLine("1. Temperature");
            Console.WriteLine("2. Student Score Board");
            Console.WriteLine("3. Product Price Finder");
            Console.WriteLine("4. Race Finish Times");
            Console.WriteLine("5. Classroom Grade Report");
            Console.WriteLine("6. Warehouse inventory check");
            Console.WriteLine("7. Library shelf Scanner");
            Console.WriteLine("0. Exit");

            return Console.ReadLine();

        }

        public static void problem1()
        {
            List<double> list = [2.2, 3.3, 4.4, 5.5, 6.6, 7.7, 8.8];
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine($"Day {i + 1}:  " + list[i]);

            }

            Console.WriteLine();
            Console.WriteLine("Total: " + list.Count);


        }

        public static void problem2()
        {
            List<int> studentScores = [90, 80, 75, 60, 55, 50]; //initialization
            foreach (int studentScore in studentScores)
            {
                Console.WriteLine($"Lists:  {studentScore}");

            }

            studentScores.Reverse();

            foreach (int studentScore in studentScores)
            {
                Console.WriteLine($"Lists:  {studentScore}");
            }
        }

        public static void problem3()
        {
            List<double> productPrices = [4.99, 9.99, 14.99, 19.99, 24.99];
            for (int i = 0; i < productPrices.Count; i++)
            {
                Console.WriteLine($"Product price {i + 1}:" + productPrices[i]);
            }

            if (productPrices.Contains(4.99) == true)
            {
                Console.WriteLine("Product found");
            }

            else
            {
                Console.WriteLine("Sorry we didnt founded");
            }



        }


        public static void problem4()
        {
            List<int> finishTimes = [10, 20, 30, 40, 50, 60, 70, 80];
            foreach (int finishTime in finishTimes)
            {
                Console.WriteLine($"Finish Time {finishTime}");
            }
            finishTimes.Sort();

            foreach (int finishTime in finishTimes)
            {
                Console.WriteLine($"Finish Time {finishTime}");
            }
            Console.WriteLine(finishTimes.Count());
        }


        public static void problem5()
        {
            List<int> grades = [55, 60, 65, 70, 75, 80, 85, 90, 95, 100];

            grades.Sort();

            grades.Reverse();

            for (int i = 0; i < grades.Count; i++)
            {
                Console.WriteLine($"Rank {i + 1}: " + grades[i]);
            }


        }

        public static void problem6()
        {
            List<int> quantities = [80, 70, 60, 50, 40, 30, 20, 10];


            int total = 0; // for calculate

            for (int i = 0; i < quantities.Count; i++)
            {
                total = total + quantities[i];
            }
            Console.WriteLine("total element" + total);

            //Average

            Console.WriteLine("Average are :" + total / quantities.Count);

            //For serch 
            if (quantities.IndexOf(70) == -1)
            {
                Console.WriteLine("Not found");
            }
            else
            {
                Console.WriteLine("The element 70 in index: " + quantities.IndexOf(7));
            }


        }

        public static void problem7()
        {
            List<int> copies = [1, 2, 3, 4, 5, 6, 7, 8, 9];
            foreach (int copy in copies)
            {
                Console.WriteLine($"Copies{copy}");
            }
            copies.Sort();
            Console.WriteLine(copies[9]);
            foreach (int copy in copies)
            {
                if (copy == 0)
                {
                    Console.WriteLine("Out of Stock");
                }

        }

            }
            static void Main(string[] args)
            {


                switch (Menu())
                {
                    case "0":
                        Console.WriteLine("Thank you :)");
                        break;

                    case "1":
                        problem1();
                        break;

                    case "2":
                        problem2();
                        break;

                    case "3":
                        problem3();
                        break;

                    case "4":
                        problem4();
                        break;

                    case "5":
                        problem5();
                        break;

                    case "6":
                        problem6();
                        break;

                    case "7":
                        problem7();
                        break;




                }



            }
        }
    }
    
