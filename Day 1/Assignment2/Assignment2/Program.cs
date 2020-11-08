using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Assignment2
{
    enum BankAccountTypes : byte
    { 
        Checking = 1 ,Deposit 
    }

    struct BankAccount
    {
        public long accountNumber;
        public decimal accountBalance;
        public BankAccountTypes accountType;
    };

    public class Program
    {   
        static void Main(string[] args)
        {
            // A-
            //the common type systems are classes structures enumerations interfaces delegates 
            // yes
            // no , as it will show an error list saying use of unassigned variable
            //yes if we make a divison and store the reminder in int it will store the integer reminder and 
            // neglect the decimal reminder 

            // C-
             //y will be 10 as it is assgined by x then x incremented
             //x will be 11 before the addtion of the 10 and 21 after added by 10
             //a will be 321 multiplication will happen first 30 * 10 then addtion 21 + 300
             //check if a is equal to be an dthe value will be false
            //
            //D-
            // symbol //
            // false
            // 255
            // 51
            // if
            // true


            //Exercise 1
            //Console.WriteLine("The Bank account types are {0} and {1}", BankAccountTypes.Checking, BankAccountTypes.Deposit);
            //Console.ReadLine();

            //Exercise 2
            //BankAccount client1;
            //client1.accountNumber = 929292998;
            //client1.accountBalance = 13751.64M;
            //client1.accountType = BankAccountTypes.Checking;

            //BankAccount client2;
            //client2.accountNumber = 1245475;
            //client2.accountBalance = 5753.84M;
            //client2.accountType = BankAccountTypes.Deposit;

            //Console.WriteLine("The data of the Client 1 is \n" +
            //    "The Account Number {0} \n" +
            //    "The Account Balance {1} \n" +
            //    "The Account Type {2} \n"
            //    , client1.accountNumber, client1.accountBalance, client1.accountType);

            //Console.WriteLine("The data of the Client 2 is \n" +
            //    "The Account Number {0} \n" +
            //    "The Account Balance {1} \n" +
            //    "The Account Type {2}"
            //    , client2.accountNumber, client2.accountBalance, client2.accountType);

            //Console.ReadLine();

            //Excerise 3
            //BankAccount client3;
            //Console.WriteLine("Enter the Account Number...");
            //client3.accountNumber = long.Parse(Console.ReadLine());

            //Console.WriteLine("Enter the Account Balance...");
            //client3.accountBalance = decimal.Parse(Console.ReadLine());

            //Console.WriteLine("Enter the Account Type \n" +
            //    "Enter one for Checking Account \n" +
            //    "Enter two for Deposit Account...");

            //byte accountType = byte.Parse(Console.ReadLine());
            //client3.accountType = (BankAccountTypes)accountType;

            //Console.WriteLine("The data of the Client 3 is \n" +
            //    "The Account Number {0} \n" +
            //    "The Account Balance {1} \n" +
            //    "The Account Type {2}"
            //    , client3.accountNumber, client3.accountBalance, client3.accountType);

            //Console.ReadLine();

            //int x = 10;
            //int y = x++;
            //x += 10;
            //int z = 30;
            //int a = x + y * z;

            //Console.WriteLine(a);

            int lo;

            int z = lo;
            Console.WriteLine(lo);
            
            Console.ReadLine();

        }
    }
}
