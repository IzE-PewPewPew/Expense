# Expense
C# Lesson Expense StaticLib: Console, .NET WinForms

Use .NET CLI and WinForms via Command Line to create a solution containing 3 projects by following steps:
1- Create a solution named “Expenses”
cmd…>dotnet new sln -o Expenses -n Expenses
2- Create a new class library project named “ExpenseLib”
cmd…>dotnet new classlib -o ./Expenses/Library -n ExpenseLib
3- Change to the directory “Expenses”
cmd…>cd expenses
4- Add the project “ExpenseLib” into the solution “Expenses”
cmd…\Exepnses>dotnet sln add ./library/expenselib.csproj
5- Create a new console project named “ExpenseConsole”
cmd…\Expenses>dotnet new console -o Console -n ExpenseConsole --use-program-main
6- Add the project “ExpenseConsole” into the solution “Expenses”
cmd…\Expenses>dotnet sln add console\expenseconsole.csproj
7- Change directory to “Console”
cmd…\Expenses>cd console
8- Add the project reference, “ExpenseLib” in the project “ExpenseConsole”
cmd…\Expenses\Console>dotnet add reference ..\library\expenselib.csproj
9- Verify the project reference done in the step 8
cmd…\Expenses\Console>notepad ExpenseConsole.cspro
10- Change back directory “Expense”
cmd…\Expenses>cd ../
11- Add New .NET WinForms Project
cmd…\Expenses>dotnet new winforms -o WinFormsApp -n ExpenseWinForms
12- Add the new WinForms project to the solution
cmd…\Expenses>dotnet sln add WinFormsApp\ExpenseWinForms.csproj
13- Add the project reference, “ExpenseLib” in the project “ExpenseConsole”
cmd…\Expenses\>dotnet add WinFormsApp\ExpenseWinForms.csproj reference Library\ExpenseLib.csproj
