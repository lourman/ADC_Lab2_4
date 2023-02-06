using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1
{
    public partial class HealthRecord : Form
    {
        public HealthRecord()
        {
            InitializeComponent();
        }
    }

    class Student
    {
        public string ID { get; }

        public string Name { get; }

        public decimal Module1Score { get; set; }
        public decimal Module2Score { get; set; }
        public decimal Module3Score { get; set; }

        public Student(string providedID, string fullStudentName)
        {
            Name = fullStudentName;
            ID = providedID;
        }

    }

        class Account
    {
        private decimal balance;

        /// <summary>
        /// Name of the acount
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Consturctor for creating an account
        /// </summary>
        /// <param name="accountName">The name of the acount</param>
        /// <param name="initialBalance">The initial amount of the acount when created</param>
        public Account(string accountName, decimal initialBalance)
        {
            Name = accountName;
            balance = initialBalance;
        }

        /// <summary>
        /// Balance property
        /// </summary>
        public decimal Balance
        {
            get
            {
                return balance;
            }
            private set
            {
                if (value <0.0m)
                {
                    balance = value;
                }
            }
        }

        /// <summary>
        /// Method to deposit a valid amount of money
        /// </summary>
        /// <param name="amountToDeposit">The money to add to the account</param>
        public void Deposit(decimal amountToDeposit)
        {
            if (amountToDeposit > 0.0m)
            {
                Balance = Balance + amountToDeposit;
            }
        }            
    }
}
