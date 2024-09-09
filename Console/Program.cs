﻿using ExpenseLib;

namespace ExpenseConsole;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            ExpenseTask.Load("expenses.txt");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            return;
        }

        List<Expense> expenses = ExpenseTask.Expenses;
        Expense? max = ExpenseTask.MaxAmontExpense;
        double total = ExpenseTask.AmountTotal;

        Console.WriteLine($"{"No",-10} {"Amount",10} {"Descr",-30}");
        string line = new string('-', 52);
        Console.WriteLine(line);
        expenses.ForEach(x => Console.WriteLine($"{x.No,-10} {x.Amount,10:C2} {x.Descr,-30}")); ;
        Console.WriteLine(line);
        Console.WriteLine($"Amount Total={total:c2}");
        Console.WriteLine($"Max-amount expense> no:{max?.No}, descr:{max?.Descr}");
        Console.ReadLine();
    }
}
