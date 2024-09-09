using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
namespace ExpenseLib
{
    public class ExpenseTask
    {
        private static List<Expense>? expenses = null;
        public static void Load(string filename)
        {
            try
            {
                string jsonData = File.ReadAllText(filename);
                JsonSerializerOptions option = new JsonSerializerOptions()
                { PropertyNamingPolicy = JsonNamingPolicy.CamelCase };
                expenses = JsonSerializer.Deserialize<List<Expense>>(jsonData, option) ?? new();
            }
            catch (Exception) { throw; }
        }

        public static List<Expense> Expenses => expenses ?? new();
        public static double AmountTotal => expenses?.Sum(x => x.Amount) ?? 0;
        public static Expense? MaxAmontExpense
        {
            get
            {
                if (expenses == null || !expenses.Any()) { return null; }
                double maxAmount = expenses.Max(x => x.Amount);
                return expenses.FirstOrDefault(x => x.Amount == maxAmount);
            }
        }

    }
}
