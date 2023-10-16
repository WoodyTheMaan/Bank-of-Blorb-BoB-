namespace Bank_of_Blorb__BoB_
{
    internal class Program
    {
        static void Main(string[] args)
        {
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
            Console.Read();
        }
        
       
    }
} 