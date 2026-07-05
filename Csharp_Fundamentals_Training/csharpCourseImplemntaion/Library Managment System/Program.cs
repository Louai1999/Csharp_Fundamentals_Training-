namespace Library_Managment_System
{
    internal class Program
    {
        //System Storge    تعريف المتغيرات 

        static string MemberName = "";
        static string MemberId = "";
        static string Memberemail = "";
        static string MembershipExpiryDate = "";
        static string MemberTire = "";
        static bool MemberRegistered = false;
        static string bookTitle = "";
        static string bookAuthor = "";
        static string bookGenre = "";
        static int bookCopies = 0;
        static bool bookRegistered = false;
        static int sessionBorrowed = 0;
        static double sessionFinesPaid = 0.0;



        /// دالة المنيو يكتب فيها كل  المنيو



        public static void PrintMenu()
        {
            Console.WriteLine("Main Menu: ");
            Console.WriteLine("0.Member Name ");
            Console.WriteLine("1. Member Id ");
            Console.WriteLine("2. Member email");
            Console.WriteLine("3. Membership expiry date");
            Console.WriteLine("4. Member Tire");
            Console.WriteLine("5. Member registered ");
            Console.WriteLine("6. Book title");
            Console.WriteLine("7. Book author");
            Console.WriteLine("8. Book genre");
            Console.WriteLine("9. Book copies");
            Console.WriteLine("10. Book registered ");
            Console.WriteLine("11. session borrowed ");
            Console.WriteLine("12. session fines paid");

        }

        //خطوات تسجيل الدخول للعميل

        public static void RegisterMember()
        {
            Console.WriteLine("Please enter your name:");
            MemberName = Console.ReadLine();

            Console.WriteLine("Enter your email: ");
            Memberemail = Console.ReadLine();

            Console.WriteLine("Member id:");
            MemberId = (Console.ReadLine());

            Console.WriteLine("Membership Expiry date");
            MembershipExpiryDate = DateTime.Now.ToString("yyy-MM-dd"); //طريقة كتابه التاريخ 

            Console.WriteLine("Member tire");
            MemberTire = Console.ReadLine();

            Console.WriteLine("Member registered");
            MemberRegistered = true;


        }

        public static void DisplayMemberProfile()  // في هذه الدالة نكتب ما يعرض للمستخدم


        {
            //  نوع المتغير  |   الي يعرض للمستخدم   | لغة سي شارب

            Console.WriteLine("Name: " + MemberName);
            Console.WriteLine("ID:   " + MemberId);
            Console.WriteLine("Email: " + Memberemail);
            Console.WriteLine("Expiry Date: " + MembershipExpiryDate);
            Console.WriteLine("Tier: " + MemberTire);

        }

        public static void SearchBookByTitle(string keyword) // في هذه الدالة نستخدمها في حال بغينا البحث او طريقة للبحث
        {
            bool found = bookTitle.ToLower().Contains(keyword.ToLower());
            if (found == true)
            {
                Console.WriteLine("We found the book");
            }
            else 
            {
                Console.WriteLine("Sorry we didnt found book");
            }
            

        }











        //// هذه الدالة ترجع نسخة للمكتبة وتزيد العدد المتاح بواحد
        // تستخدم ref عشان تعدل على المتغير الأصلي مباشرة
        // Math.Min تضمن ما يتجاوز الحد الأقصى
        public static void BorrowBook(ref int copies)
        {
            copies = Math.Max(0, copies - 1);       // الطريقة الحسابية للتاكد من كتب المكتبة و تضمن ما يتجاوز الحد الاقصى للكتب نستخدم(Math.Max)


        }





        /*
                 ============================================================================================================

                   كل الدوال تكتب قبل الـميــن علشان نقدر نستخدمها في اكثر من بروجكت لنفس السليوشن اهم شي تكون عامة او ببلك

                 ============================================================================================================
        */


        static void Main(string[] args)
        {

            while (true)
            {
                PrintMenu();

                Console.WriteLine("Enter your choice: ");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 0:
                        RegisterMember();

                        break;

                    case 1:

                        DisplayMemberProfile();
                        break;









                }
            }
        }
    }
}