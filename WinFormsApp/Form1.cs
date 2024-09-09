using ExpenseLib;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ExpenseWinForms;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
        LoadExpenses();
    }

    private void LoadExpenses()
    {
        try
        {
            ExpenseTask.Load("expenses.txt");
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Error loading expenses: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        List<Expense> expenses = ExpenseTask.Expenses;
        Expense? maxExpense = ExpenseTask.MaxAmontExpense;
        double totalAmount = ExpenseTask.AmountTotal;

        label1.Text = maxExpense != null
            ? $"Max-amount expense> No: {maxExpense.No}, Descr: {maxExpense.Descr}"
            : "No maximum expense found.";

        dataGridView1.DataSource = expenses;

        dataGridView1.Columns["No"].HeaderText = "No";
        dataGridView1.Columns["Amount"].HeaderText = "Amount";
        dataGridView1.Columns["Descr"].HeaderText = "Description";
    }
}
