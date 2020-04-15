using ExeFixacao.Entities;
using ExeFixacao.Execeptions;
using System;
using System.Globalization;

namespace ExeFixacao
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter account data");
                Console.Write("Number: ");
                int number = int.Parse(Console.ReadLine());
                Console.Write("Holder: ");
                string holder = Console.ReadLine();
                Console.Write("Initial balance: ");
                double balance = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Withdraw limit: ");
                double withDrawLimit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Account account = new Account(number, holder, balance, withDrawLimit);

                Console.WriteLine();
                Console.Write("Enter amount for withdraw: ");
                double amount = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                account.WithDraw(amount);
                Console.WriteLine("New balance: " + account.Balance.ToString("F2", CultureInfo.InvariantCulture));
            }
            catch (DomainException e)
            {
                Console.WriteLine("Erro ao realizar saque: " + e.Message);
            }
            catch (FormatException e)
            {
                Console.WriteLine("Erro na conversão de dados." +e.Message);
            }
        }
    }
}
