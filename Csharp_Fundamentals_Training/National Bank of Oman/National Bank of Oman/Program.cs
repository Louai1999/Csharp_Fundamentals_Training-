namespace National_Bank_of_Oman
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int accountNumber = 0;
            string holderName = " ";
            double balance = 0;
            bool isActive = false;
            char accountType = ' ';
            bool isEmployed = false;
            double salary = 0;
            int creditScore = 0;
            int age = 0;
            double deposit = 0;
            double withdrawal = 0;
            double annualRate = 0;
            double avgBalance = 0;
            bool setupDone = false;
            /*
             * accountNumber ==> enter account number
             * holderName ==> enter holder Name 
             * Balance ==> enter current balance 
             * isActive ==> enter 1=active /0=inactive
             * accountType ==> enter S/C/F
             * isEmloyed ==> enter 1=employed/0=not
             * salary ==> enter monthly salary
             * creditScore ==> enter credit score
             * age ==> enter customer age 
             * deposit ==> enter last deposit amount 
             * withdrawal ==> enter lasst withdrawal 
             * annualRate ==> enter annual interest rate
             * avgBalance ==> enter avh monthly balance
             */

            while (!setupDone)
            {
             Console.WriteLine("=== SYSTEM SETUP — Enter Account & Customer Data ===");
               
                Console.WriteLine($"1) Account Number (int)        current: {accountNumber}");
                Console.WriteLine($"2) Holder Name (string)        current: {holderName}");
                Console.WriteLine($"3) Balance (double)            current: {balance}OMR");
                Console.WriteLine($"4) isActive (bool)              current: {isActive} [enter 1=yes / 0=no]");
                Console.WriteLine($"5) AccountType (char)           current: {accountType}[ enter s /c /f]");
               
      
               
               Console.WriteLine(" ==  Customer Profile == ");
                Console.WriteLine($"6) Employed (bool)              Current:{isEmployed}[enter 1=yes / 0-no]");
                Console.WriteLine($"7) Salary (double)           current:{salary}OMR");
                Console.WriteLine($"8) Credit Score (int)        current:{creditScore}");
               
                Console.WriteLine($"9) Customer Age (int)      current:{age}");
                Console.WriteLine("== Transaction Data==");

                Console.WriteLine($"10) Last deposit Amount (double) current:{deposit} OMR");
                Console.WriteLine($"11) Last Withdrawal (double)    current :{withdrawal} OMR");

                Console.WriteLine($"12) Annual Interest Rate (double) current:{annualRate}[e.g. 0.035 =3.5%]");
                Console.WriteLine($"13) Avg Monthly Balance (double) current:{avgBalance} OMR");
                ///////////// setup complete////////////////
                Console.WriteLine("0) Setup complete — launch Main Menu");
                Console.Write("Select Option");

                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice) {
                    case 1:
                        Console.Write(" Enter account number: ");
                        accountNumber = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine($" Account number set to: {accountNumber}");
                        break;
                         
                        case 2:
                        Console.Write("Enter holder Name: ");
                        holderName = Console.ReadLine();
                        Console.WriteLine($" Holder name set to: {holderName}");
                        break;

                    case 3:
                        Console.Write("Enter Current Balance: ");
                        balance = Convert . ToDouble (Console.ReadLine());
                        Console.WriteLine($"Current Balance set to: {balance}");
                        break;

                    case 4:
                        Console.Write("Enter 1=active / 0=inactive: ");
                        isActive = Console.ReadLine() == "1";
                        Console.WriteLine($" Account status set to: {(isActive ? "Active" : "Inactive")}");
                        break;

                    case 5:
                        Console.Write("Enter Account type (S/ C/ F): ");
                        accountType = Convert . ToChar (Console.ReadLine()) ;
                        Console.WriteLine($"Account Type set to {accountType}");
                        break;

                        case 6:
                        Console.Write("Enter 1=Employee / 0=Not: ");
                        isEmployed = Console.ReadLine() == "1";
                        Console.WriteLine($" Employed set to {isEmployed}");
                        break;

                        case 7:
                        Console.Write("Enter Monthly Salary:(OMR)");
                        salary = Convert . ToDouble (Console.ReadLine());
                        Console.WriteLine($"Salary set to {salary} OMR ");
                        break;


                    case 8:
                        Console.Write("Enter Credit Score : ");
                        creditScore = Convert .ToInt32 (Console.ReadLine());
                        Console.WriteLine($"Credit Score set to {creditScore}");
                        break;
                    case 9:
                        Console.Write("Age: ");
                        age = Convert .ToInt32 (Console.ReadLine());
                        Console.WriteLine($"Age set to {age}");
                        break;
                    case 10:
                        Console.Write("Enter Last Deposit Amount: (OMR)");
                        deposit = Convert . ToDouble (Console.ReadLine());
                        Console.WriteLine($" Last Deposit set to {deposit} OMR");
                        break;
                    case 11:
                        Console.Write("Enter last Withdrawal: (OMR) ");
                        withdrawal = Convert . ToDouble (Console.ReadLine());
                        Console.WriteLine($" Last withdrawal set to 1{withdrawal}OMR");
                        break;
                        case 12:
                        Console.Write("Enter Annual Interest Rate (e.g. 0.035 =3.5%): ");
                        annualRate = Convert . ToDouble (Console.ReadLine());
                        Console.WriteLine($"Annual Interest Rate set to {annualRate}[e.g. 0.035 =3.5%]");
                        break;
                    case 13:
                        Console.Write("Avg Monthly Balance: (OMR) ");
                
                       avgBalance = Convert . ToDouble (Console.ReadLine());
                        Console.WriteLine($" Avg Monthly Balance set to {avgBalance}OMR");
                        break;

                    case 0:
                   
                        Console.WriteLine(" Setup complete. Launching Main Menu...");
                        setupDone = true;
                        break;
                        default: Console.WriteLine("Invalid option. Please choose 1–13 or 0 to finish");
                        break;




                }//switch end



            }




        }
    }
}
