// Author: [Zaid Rojas]
// Course: COMP003A
// Faculty: Jonathan Cruz
// Purpose: Demonstrate encapsulation using private fields and properties in C#

namespace COMP003A.LectureActivity5_2
{

    internal class Program
    {
        static void Main(string[] args)
        {

            // Create a new BankAccount object
            BankAccount myAccount = new BankAccount("12345678", 500.00);

            // Display the account number and initial balance
            Console.WriteLine($"Account Number: {myAccount.AccountNumber}");
            Console.WriteLine($"Initial Balance: {myAccount.Balance:C}");

            //Deposit and withdraw money
            myAccount.Deposit(150.00);
            myAccount.Withdraw(50.00);
            myAccount.Withdraw(700.00); // Should print an insufficient funds message.
        }
    }


    internal class BankAccount
    {
        // Fields
        private string _accountNumber;
        private double _balance;

        /// Properties
        /// <summary>
        /// Gets the account nubmer.
        /// </summary>
        public string AccountNumber
        {
            get { return _accountNumber; }
        }

        /// <summary>
        ///  Gets or sets the account balance with validation
        /// </summary>
        public double Balance
        {
            get { return _balance;  }
            set
            {
                if (value >= 0)
                    _balance = value;
            }
        }

        /// <summary>
        /// Initilizes a new instance of BankAccount with an account number and initial balance.
        /// </summary>
        public BankAccount(string accountNumber, double initialBalance)
        {
            // Set the account number and initial balance
            _accountNumber = accountNumber;
            // Validate the initial balance
            Balance = initialBalance;
        }

        /// <summary>
        /// Deposits money into the account.
        /// </summary>
        /// <param name="amount">Amount to deposit.</param>
        public void Deposit(double amount)
        {
            if (amount > 0)
            {
                _balance += amount;
                Console.WriteLine($"Deposited: {amount:C}. New Balance: {_balance:C}");
            }
        }

        /// <summary>
        /// Withdraws money from the account if sufficient balance is available.
        /// </summary>
        /// <param name="amount">Amount to withdaraw. </param>
        public void Withdraw(double amount)
        {
            if (amount > 0 && _balance >= amount)
            {
                _balance -= amount;
                Console.WriteLine($"Withdrawn: {amount:C}. New Balance: {_balance:C}");
            }
            else
            {
                Console.WriteLine("Insufficient funds.");
            }
        }
    }


}
