using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr14_BankAccountAndSorting
{
    public class BankAccount
    {
        public string Name {  get; set; }

        private double _balance;
        public double Balance { get { return _balance; } }
            
        private bool _locked = false;

        public BankAccount(string name, double balance, bool locked) 
        {
            Name = name;
            _balance = balance;
            _locked = locked;
        }
        public BankAccount(string name, double balance) :
            this (name, balance, false)
        {
        }
        public BankAccount(double balance) :
            this ("", balance, false)
        {
            
        }

        public void Deposit(double amount)
        {
            if (!(_locked)) 
            {
                _balance += amount;
            }


        }
        public void Withdraw(double amount)
        { 
            if (!(_locked) && amount <= _balance) 
            {
                _balance -= amount;
            }


        }
        public void ChangeLockState()
        {
            _locked = !(_locked);
        }
        public string ToString()
        {
            return "Name: " + Name + ", Balance: " + Balance;
        }

    }
}
