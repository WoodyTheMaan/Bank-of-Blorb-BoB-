using System.Data.SqlTypes;
using System.Runtime.CompilerServices;

namespace Bank_of_Blorb__BoB_
{
    internal class Program
    {
        public static double money = 150.0;
        static void Main(string[] args)
        {

            //Program works best in full screen, whithout fullscreen the letters don't appear fully
            Console.WriteLine("Thanks for choosing Bank of Blorb, if you do not yet have an account with us you must create an account before using this ATM");
            Console.WriteLine("Please press enter, by doing so the enter key will scan your finger print. (Please note, you must use the same finger you used when registering)");
            Thread.Sleep(500);
            Console.WriteLine("Notifications:");
            Console.WriteLine("---------------------------------------------------------");
            Console.WriteLine("You have ONE notification about terms and conditions. please press enter to read.");
            Console.ReadLine();
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Bank of Blorb - Updated Terms and Conditions Effective Date: October 16, 2023 ");
            Console.WriteLine("Introduction: Welcome to the Bank of Blorb! We're thrilled to have you as a customer and want to ensure you're up-to-date with our latest terms and conditions. Please take a moment to review these updated terms carefully. By continuing to use our services, you agree to be bound by these terms. If you already have an account with us, please read this document thoroughly.");
            Console.WriteLine("");
            Console.WriteLine("1. Account Usage: You may use your Bank of Blorb account for personal or business purposes on the planet Blorb. Your account details and any associated access credentials are confidential and should not be shared with others. You are responsible for all actions taken on your account. Please notify us immediately if you suspect any unauthorized activity. ");
            Console.WriteLine("2. Privacy and Security: We take your privacy and security seriously. For more details, please refer to our Privacy Policy, which is an integral part of these terms. Bank of Blorb will never request your personal or account information via email or phone calls. Beware of phishing attempts.");
            Console.WriteLine("3. Account Statements: You will receive regular account statements detailing your transactions. Review them promptly and report any discrepancies to us.");
            Console.WriteLine("4. Fees and Charges: Fees for various services may apply. Details on applicable fees can be found on our website or by contacting our customer support. ");
            Console.WriteLine("5. Changes to Terms:  Bank of Blorb reserves the right to modify these terms and conditions. Any significant changes will be communicated to you via email or through our website. Continued use of our services after receiving notice of changes implies your acceptance of the updated terms");
            Console.WriteLine("6. Termination: Bank of Blorb reserves the right to terminate your account for any reason, including but not limited to fraudulent activity, violation of these terms, or other unlawful conduct. 7. Contact Information: To contact us, you can visit our headquarters on Blorb, send an interplanetary transmission, or call our customer support.");
            Console.WriteLine("© 2023 Bank of Blorb. All rights reserved.");
            Thread.Sleep(3000);
            Console.WriteLine("Please click 'enter' to have your finger scanned");
            Console.ReadLine();
            Console.WriteLine("Reading...");
            Thread.Sleep(700);
            Console.WriteLine("Succsesfull! Welcome back, Zorblaxianthor!");
            Console.WriteLine("Please enter you password:");
            Console.ReadLine();
            Console.WriteLine("");
            Console.WriteLine("PLEASE WAIT WHILE WE COMFIRM THIS IS YOUR PASSWORD...");
            Console.WriteLine("");
            Thread.Sleep(1000);
            Console.WriteLine("COMFIRMED Welcome back to BoB Zorblaxianthor!");
            Console.WriteLine("___________________________________________________________");
            Menu();

        }
        public static void Menu()
        {
            string userInput;
            Console.WriteLine($"You have {money} Blorbian dollars");
            Thread.Sleep(500);
            Console.WriteLine("Please choose an option");
            Console.WriteLine("");
            Console.WriteLine("1 ------- Deposit");
            Console.WriteLine("2 ------- Withdrawal");
            Thread.Sleep(300);
            Console.WriteLine("3 ------- Bill Payment");
            Console.WriteLine("4 ------- Account Balance Update");
            Console.WriteLine("5 ------- Exit");
            Thread.Sleep(400);
            Console.WriteLine("========================================");
            Console.WriteLine("PLEASE NOTE: INVALID RESPONSE GIVEN WILL RESULT IN FEES SUBTRACTING FROM YOUR ACCOUNT");
            Console.WriteLine("proteted by terms and conditions. See website to read.");
            userInput = Console.ReadLine();

            if (userInput == "1")
            {
                Console.WriteLine("You have chosen Deposit, please wait while we send you to the deposit server");
                Thread.Sleep(500);
                Console.WriteLine("Fetching server...");
                Thread.Sleep(700);
                Console.WriteLine("Loading attachments...");
                Thread.Sleep(400);
                Console.WriteLine("Connected!");
                Thread.Sleep(300);
                Deposit();
            }
            else if (userInput == "2")
            {

                Console.WriteLine("You have chosen Withdeawl, please wait while we send you to the Withdrawl server");
                Thread.Sleep(500);
                Console.WriteLine("Fetching server...");
                Thread.Sleep(700);
                Console.WriteLine("Loading attachments...");
                Thread.Sleep(400);
                Console.WriteLine("Connected!");
                Thread.Sleep(300);
                Withdrawl();
            }
            else if (userInput == "3")
            {
                Console.WriteLine("You have chosen Bill Payment, please wait while we send you to the Bill Payment server");
                Thread.Sleep(500);
                Console.WriteLine("Fetching server...");
                Thread.Sleep(700);
                Console.WriteLine("Loading attachments...");
                Thread.Sleep(400);
                Console.WriteLine("Connected!");
                Thread.Sleep(300);
                BillPayment();
            }
            else if (userInput == "4")
            {
                Console.WriteLine("You have chosen Account Balance Update, please wait while we send you to the Account Balance Update server");
                Thread.Sleep(500);
                Console.WriteLine("Fetching server...");
                Thread.Sleep(700);
                Console.WriteLine("Loading attachments...");
                Thread.Sleep(400);
                Console.WriteLine("Connected!");
                Thread.Sleep(300);
                AccountUpdate();
            }
            else if (userInput == "5")
            {
                Exit();
            }
            else
            {
                NotValid();
            }
        }

        public static void Deposit()
        {
            Console.Clear();
            Console.WriteLine("Please insert money and press enter. (Note, this transaction will cost a fee of 0.75 to do)");
            Console.ReadLine();
            Console.WriteLine("Reading money.....");
            Thread.Sleep(850);
            money = money + 82;
            Console.WriteLine("82 Blorbian dollars succssfully added to your account, thanks!");
            Console.WriteLine($"You now have {money}");
            Console.WriteLine($"Click enter to exit");
            Console.ReadLine();
            Exit();

        }

        public static void Withdrawl()
        {
            double withdrawlAmount;
            Console.Clear();
            Console.WriteLine("Please enter the amount of blorbian dollars you would like to withdrawl (Note, this transaction will cost a fee of 0.75 to do)");
            withdrawlAmount = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Waiting for request to be processed...");
            Thread.Sleep(1000);
            if (money == 0)
            {
                Console.WriteLine("You don't have the funds to use anything, please press enter to exit.");
                Console.ReadLine();
                Exit();
            }
            money = money - 0.75;

            if (withdrawlAmount > money)
            {
                Console.WriteLine("Request Failed...");
                Console.WriteLine("If you withdrawled less Bloarbian dollars than you have please come to a branch to get things sorted");
                Thread.Sleep(700);
                Console.WriteLine("Removing 0.75 from your account");
                Thread.Sleep(500);
                Console.WriteLine($"You now have {money}, please click enter to exit.");
                Console.ReadLine();
                Exit();
            }
            else
            {
                money = money - withdrawlAmount;
                Console.WriteLine($"{withdrawlAmount} of Blorbian Dollars has been withdrawled, money should be below you, Thanks!");
                Console.WriteLine($"You now have {money}");
                Console.WriteLine($"Click enter to exit");
                Console.ReadLine();


            }

            Exit();
        }

        public static void BillPayment()
        {
            string yOrN;
            double billAmountPaid, blorbcoinDepository = 20.12;
            Console.WriteLine("Welcome, to Bill Payment! You have ONE outstanding bill from BLORBCOIN DEPOSITORY");
            Console.WriteLine("The bill is 20.12 do you wish to pay for it now? (Y/N)");
            yOrN = Console.ReadLine().ToLower();
            if (yOrN == "y")
            {



                Console.WriteLine("How much do you want to pay? (Note: what you input is FINAL. INVALID RESPONSE WILL RESULT IN EXITING ATM)");
                billAmountPaid = Convert.ToDouble(Console.ReadLine());
                if (billAmountPaid < blorbcoinDepository)
                {
                    Thread.Sleep(700);
                    Console.WriteLine($"Thanks! for paying {billAmountPaid}");
                    Console.WriteLine("Subtracting 0.75 from account");
                    money = money - 0.75;
                    Console.WriteLine($"You now have {money}");
                    Console.WriteLine("Click enter to exit");
                    blorbcoinDepository = billAmountPaid - blorbcoinDepository;
                    money = billAmountPaid - money;
                    Console.ReadLine();
                    Exit();
                }
                else if (billAmountPaid > blorbcoinDepository) 
                {
                    Thread.Sleep(700);
                    Console.WriteLine("INVALID RESPONSE");
                    Console.WriteLine("Subtracting 0.75 from account");
                    money = money - 0.75;
                    Console.WriteLine($"You now have {money}");
                    Console.WriteLine("Click enter to exit");
                    Console.ReadLine();
                    Exit();
                }



                Thread.Sleep(500);
                Console.WriteLine($"You paid {billAmountPaid} of Blorbian dollars");
                Console.WriteLine($"You still must pay {blorbcoinDepository} amount of money");
                Console.WriteLine("Click enter to exit");
                Console.ReadLine();
                Exit();


            }
            else if (yOrN == "n")
            {
                Console.WriteLine("You've selected 'No' please click enter to exit");
                money = money - 0.75;
                Console.WriteLine($"You now have {money}");
                Console.ReadLine();
                Exit();
            }

        }

        public static void AccountUpdate()
        {
            Random generator = new Random();
            string userInput;
            double savingsAmount;
            generator.Next();
            savingsAmount = generator.Next(3, 91);
            Console.WriteLine("Welcome to Account Balance Update!");
            Console.WriteLine("1 ------- Chequing");
            Console.WriteLine("2 ------- Savings");
            userInput = Console.ReadLine();
            if (userInput == "1")
            {
                Console.WriteLine($"You've chosen chequing");
                Console.WriteLine($"You have {money} amount of Blorbian Dollars in your chequing account");
                money = money - 0.75;
                Console.WriteLine($"Fee of 0.75 you now have {money}");
                Console.WriteLine("Please press enter to exit");
                Console.ReadLine();
                Exit();
            }
            else if (userInput == "2")
            {
                Console.WriteLine($"You've chosen savings");
                Console.WriteLine($"You have {savingsAmount} amount of Blorbian Dollars in your savings account");
                savingsAmount = savingsAmount - 0.75;
                Console.WriteLine($"Fee of 0.75 you now have {savingsAmount}");
                Console.WriteLine("Please press enter to exit");
                Console.ReadLine();
                Exit();
            }
        }

        public static void NotValid()
        {
            Console.Clear();
            Console.WriteLine("NOT A VALID INPUT. SUBTRACTING SEVENTY FIVE CENTS FROM ACCOUNT");

            Console.WriteLine("Click enter to return to menu");
            money = money - 0.75;
            Console.ReadLine();
            Menu();
            
        }

        public static void Exit()
        {
            Console.Clear();
            Console.WriteLine("Thanks for using BoB goodbye.");
            Thread.Sleep(1500);

        }

    }
}