// C# program that will read balance and withdraw amount from keyboard and display the remaining balance
// if balanace is greater than withdraw amount other than throw an user-defined exception
// with appropriate message

using System;

class Program44
{
    static void Main(string[] args)
    {
        try
        {
            Console.WriteLine("Enter the balance and withdraw amount:");
            double balance = double.Parse(Console.ReadLine());
            double withdraw = double.Parse(Console.ReadLine());

            if (balance < withdraw)
            {
                throw new Exception("Insufficient Balance");
            }
            else
            {
                balance = balance - withdraw;
                Console.WriteLine("Remaining Balance is:" + balance);
                Console.WriteLine("Transaction Successful");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Exception: " + ex.Message);
            Console.WriteLine("Block transaction");
        }
    }
}
