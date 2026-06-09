using System.Net.NetworkInformation;
using System.Xml.Linq;

namespace Mini_Flight_Management_System
{
    internal class Program
    {
        //Storage 
        static List<string> passengerNames = new List<string> { "Ali", "Ahmed", "Fahad", "Louai", "Salim" };

        static List<string> ticketNumbers = new List<string> {"T001","T002","T003","T004","T005"};
        
        static string[] flightNumbers = {"OA101,OA102,OA103,OA104,OA105,OA106"};
        
        static List<string> availableDate = new List<string> { "01-10-2026,02-10-2026,03-10-2026,04-10-2026" };
        
        static Dictionary<string, string> bookingRecord = new Dictionary<string, string>{ {"T001", "OA101|12-Jan-2026"}, {"T002", "OA102|15-Jan-2026"} };
        
        Queue<string> checkedInQueue = new Queue<string> ();
        
        Stack<string> boardingStack = new Stack<string>();
        
        static List<string> cancelledTickets = new List<string>();
        
        Dictionary<string, string> passengerSeatMap = new Dictionary<string, string>();


        //Main menu 
        public static string Menu()
        {
            Console.WriteLine("***Sky Wings Flight Mangment System***");

            Console.WriteLine();
            Console.WriteLine("1. Register New Passenger");
            Console.WriteLine("2. View All Passengers");
            Console.WriteLine("3. Book a Flight Ticket");
            Console.WriteLine("4. View Booking Details");
            Console.WriteLine("5. Update a Booking");
            Console.WriteLine("6. Cancel a Ticket");
            Console.WriteLine("7. Passenger Check-In");
            Console.WriteLine("8. Board Passengers (Boarding Stack)");
            Console.WriteLine("9. Generate Flight Manifest");
            Console.WriteLine("10. Manage Waitlist & Seat Assignment");
            Console.WriteLine("0.Exit");

            return Console.ReadLine();
        } //Menu

        public static void RegisterNewPassenger()
        {
            Console.WriteLine("Enter your full name");
            string name= Console.ReadLine();

            if(string.IsNullOrEmpty(name))
            {
                Console.WriteLine("Error: please enter your name");
                return;
                Console.ReadLine();

            }

            foreach (string passenger in passengerNames)
            {
                if (passenger.ToLower() == name.ToLower())
                {
                    Console.WriteLine("Error: Name already existing.");
                    return;
                }
            }

            int nextNumber = passengerNames.Count + 1;
            string ticketID = "TKT-" + nextNumber.ToString().PadLeft(3, '0'); //XX

            passengerNames.Add(name);
            ticketNumbers.Add(ticketID);


            Console.WriteLine("Registered Ticket ID" + ticketID);
            

        } //1

        public static void ViewAllPassengers()
        {
        if(passengerNames.Count==0)
            {
                Console.WriteLine("No passengers registered yet.");
                return;
            }

            Console.WriteLine("No. | Passenger Name. | Ticket ID | Status. ");
            Console.WriteLine("------------------------------------------------");



            for (int i = 0; i<passengerNames.Count; i++ )
            {
                string status = cancelledTickets.Contains(ticketNumbers[i])
                                ? "CANCELLED"
                                : "Active";
                Console.WriteLine((i + 1) + " | " + passengerNames[i] + " | " + ticketNumbers[i] + " | " + status);

            }


        } //2


        public static void BookFlightTicket()
        {
            Console.WriteLine("Enter your ticket ID");
            string ID = Console.ReadLine();

            if (ticketNumbers.Contains(ID))
            {
                Console.WriteLine("Ticket ID invalid");
                return;
            }
            else if (cancelledTickets.Contains(ID))
            {
                Console.WriteLine("Ticket ID has been cancelled");
            }
            else
            {
                Console.WriteLine($"Ticket ID is active and valid {ID}");
            }


            if (bookingRecord.ContainsKey(ID))
            {
                Console.WriteLine("Sorry this ticket alredy booked");
                return;
            }


            Console.WriteLine("Available Flights:");
            for (int i = 0; i < flightNumbers.Length; i++)
            {
                Console.WriteLine((i + 1) + ". " + flightNumbers[i]);
            }


            Console.WriteLine("Please select flight (1-" + flightNumbers.Length + ");");
            int flightChoice = int.Parse(Console.ReadLine());
            if (flightChoice < 1 || flightChoice > flightNumbers.Length) ;
            {
                Console.WriteLine("Error Invalid flight");
                return;
            }
            string selectFlight = flightNumbers[flightChoice - 1];



            Console.WriteLine("Available Dates:");
            for (int i = 0; i < availableDate.Count; i++)
            {
                Console.WriteLine((i + 1) + ". " + availableDate[i]);
            }

            Console.Write("Select date (1-" + availableDate.Count + "): ");
            int dateChoice = int.Parse(Console.ReadLine());

            // Validate
            if (dateChoice < 1 || dateChoice > availableDate.Count)
            {
                Console.WriteLine("Error: Invalid selection.");
                return;
            }

            string selectedDate = availableDate[dateChoice - 1];

            //6 booking record

            bookingRecord[ID] = $"{selectFlight}|{selectedDate}";

            string flight = bookingRecord[ID].Split('|')[0];





            //7
            int passengerIndex = ticketNumbers.IndexOf(ID);
            string passengerName = passengerNames[passengerIndex];
            Console.WriteLine("{Boooking Conformation}");
            Console.WriteLine("Ticket ID :" + ID);
            Console.WriteLine("Passenger name :" + passengerNames);
            Console.WriteLine("Flight"+ selectFlight );
            Console.WriteLine("Date" + selectedDate );






        }  //3


        public static void ViewBookingDetails()
        {
            Console.WriteLine("Please enter ticket ID");
            string validate = Console.ReadLine();
            if (string.IsNullOrEmpty(validate))
            {
                Console.WriteLine("Error: Ticket ID cannot be empty");
                return;
            }

            int matching = ticketNumbers.IndexOf(validate);

            if (matching == -1)
            {
                Console.WriteLine($"Error: Ticket ID {validate} does not exist.");
                return;
            }
            else
            {
                Console.WriteLine($"Thank you.");
            }

            string passengerName = passengerNames[matching];
            {
                Console.WriteLine($"Passenger name: {passengerName}");
            }


            //3
            if(cancelledTickets.Contains(validate))
            {
                Console.WriteLine("That ticket has ben cancelled");
                return;
            }

            //4
            if(bookingRecord.TryGetValue(validate,out string rawBookingValue))
            {
                Console.WriteLine("No booking found for this ticket");
                return;
            }

            //5

                
                




                        



        } //4


        public static void UpdateBooking()
        {

        } // 5


        public static void CancelTicket()
        {
        } //6


        public static void PassengerCheckIn()
        {
        }

        public static void BoardPassengers()
        {
        }

        public static void GenerateFlightManifest()
        {
        }

        public static void ManageSeat()
        {
        }










        static void Main(string[] args)
        {
            bool lop = true;
            do
            {

                switch (Menu())
                {
                    case ("1"):
                        RegisterNewPassenger();
                        break;

                    case ("2"):
                        ViewAllPassengers();
                        break;

                    case ("3"):
                        BookFlightTicket();
                        break;

                    case ("4"):
                        ViewBookingDetails();
                        break;

                    case ("5"):
                        UpdateBooking();
                        break;

                    case ("6"):
                        CancelTicket();
                        break;

                    case ("7"):
                        PassengerCheckIn();
                        break;

                    case ("8"):
                        BoardPassengers();
                        break;

                    case ("9"):
                        GenerateFlightManifest();
                        break;

                    case ("10"):
                        ManageSeat();
                        break;


                }


                Console.WriteLine("Enter your choice");
                Console.ReadKey();
                Console.Clear();

            } while (lop == true);


        }
    }
}
