using System.Transactions;
using System.Xml.Linq;

namespace CMS
{
    internal class Program
    {
        static void Main(string[] args)
        {




            const int MAX_PATIENTS = 3;
            const int MAX_DOCTORS = 2;
            const int MAX_APPOINTMENTS = 3;


            ////pation 1
            ///
            string p1Name = "";
            int p1Age = 0;
            string p1Phone = "";
            bool p1Active = false;


            /////Pation 2
            ///
            string p2Name = "";
            int p2Age = 0;
            string p2Phone = "";
            bool p2Active = false;

            /////Pation 3
            ///
            string p3Name = "";
            int p3Age = 0;
            string p3Phone = "";
            bool p3Active = false;

            ////Doctore 1 
            ///
            string d1Name = "";
            string d1Spec = "";
            double d1Fee = 0;
            bool d1Active = false;

            ///Doctore 2
            ///
            string d2Name = "";
            string d2Spec = "";
            double d2Fee = 0;
            bool d2Active = false;

            ////Appointment 
            ///
            string a1Patient = "";
            string a1Doctor = "";
            string a1Date = "";
            string a1Status = "";
            bool a1Active = false;

            //// Appointment 2
            ///
            string a2Patient = "";
            string a2Doctor = "";
            string a2Date = "";
            string a2Status = "";
            bool a2Active = false;

            //// Appointment 3 
            ///
            string a3Patient = "";
            string a3Doctor = "";
            string a3Date = "";
            string a3Status = "";
            bool a3Active = false;

            ////
            ///
            int patientCount = 0;
            int doctorCount = 0;
            int appointmentCount = 0;

            ///===============>   Main Menu  <===================////

            while (true)
            {
                Console.Clear();

                Console.WriteLine("CLINIC MANAGMENT SYSTEM");

                Console.WriteLine($"1) Patient Mangment ");

                Console.WriteLine($"2) Doctor Managment ");

                Console.WriteLine($"3) Appointment Managment ");

                Console.WriteLine($"0) Exit ");

                Console.Write("Enter Your Choice");

                int choice = Convert.ToInt32(Console.ReadLine());

                /*
                                               ╔══════════════════════════════════════╗ 
                                               ║     CLINIC MANAGEMENT SYSTEM         ║ 
                                               ╠══════════════════════════════════════╣ 
                                               ║  1. Patient Management               ║ 
                                               ║  2. Doctor Management                ║ 
                                               ║  3. Appointment Management           ║ 
                                               ║  0. Exit                             ║ 
                                               ╚══════════════════════════════════════╝ 
                                                             Enter your choice: 

                    */


                switch (choice)

                {
                    case 1:
                        Console.WriteLine("Patient Mangment");


                        break;


                    case 2:
                        Console.WriteLine("Doctor Managment");


                        break;


                    case 3:
                        Console.WriteLine("Appointment Managment");


                        break;


                    case 0:
                        Console.WriteLine("Exit");

                        return;

                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;

                } 
                //Wile end

                /////////////////////////////////////// Sup-Menu Option /////////////////////////////////////////


                /*

                                                             Patient Management Sub-Menu 
                                                       ╔══════════════════════════════════════╗ 
                                                       ║     PATIENT MANAGEMENT               ║ 
                                                       ╠══════════════════════════════════════╣ 
                                                       ║  1. Add New Patient                  ║ 
                                                       ║  2. Display All Patients             ║ 
                                                       ║  3. Update Patient Phone             ║ 
                                                       ║  4. Delete Patient                   ║ 
                                                       ║  0. Back to Main Menu                ║ 
                                                       ╚══════════════════════════════════════╝ 

                */
              
                    while (true)
                    {
                        Console.WriteLine("----PATIENT MANAGMENT----");
                        Console.WriteLine($"1) Add New Patient ");
                        Console.WriteLine($"2) Display All Patients");
                        Console.WriteLine($"3) Update Patients");
                        Console.WriteLine($"4) Delete Patient ");
                        Console.WriteLine($"0) Back to Main Menu");

                        int patientChoice = Convert.ToInt32(Console.ReadLine());

                        switch (choice)
                        {
                            case 1:
                                break;


                            case 2:

                                break;

                            case 3:

                                break;

                            case 4:

                                break;

                            case 0:

                                break;


                            default:
                                Console.WriteLine("Invalid choice.");
                                break;
                                if (patientChoice == 0) break;


                        }
                        break;
                    }










                    }// while end 



            }
}
}

    