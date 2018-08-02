using carDealership.Models;
using carDealership.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace carDealership.Factories
{
    class TransactionFactory
    {
        public Transaction CreateTransaction(Car car, bool isIncoming)
        {
            Transaction createdTransaction = null;
            Console.WriteLine("Bill or invoice?: ");
            Console.WriteLine("1.Bill");
            Console.WriteLine("2.Invoice");
            var chosenTransaction = Console.ReadKey(true);
            switch (chosenTransaction.Key)
            {
                case ConsoleKey.D1:
                    createdTransaction = CreateBill(car,isIncoming);
                    break;
                case ConsoleKey.D2:
                    createdTransaction = CreateFvat(car,isIncoming);
                    break;
            }
            return createdTransaction;
        }

        private Transaction CreateBill(Car car,bool isIncoming)
        {
            var bill = new Bill();
            FillTransactionFields(bill, car, isIncoming);
            Console.WriteLine("Enter nip: ");
            bill.Nip = int.Parse(Console.ReadLine());
            return bill;
        }

        private Transaction CreateFvat(Car car,bool isIncoming)
        {
            var fvat = new Fvat();
            FillTransactionFields(fvat,car,isIncoming);
            Console.WriteLine("Enter precentage: ");
            fvat.Percentage = int.Parse(Console.ReadLine());
            fvat.CompanyName = Console.ReadLine();
            return fvat;
        }

        public virtual void FillTransactionFields(Transaction transaction, Car car, bool isIncoming)
        {
            Console.WriteLine($"Date: ");
            // parse to datetime
            Console.WriteLine($"Model of car: ");
            transaction.Car = car;
            if(isIncoming == true)
            {
                transaction.IsIncoming = true;
            }
            else
            {
                transaction.IsIncoming = false;
            }
            Console.WriteLine($"Value of transaction: ");
            transaction.Price = int.Parse(Console.ReadLine());
        }
    }
}
