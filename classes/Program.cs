
// https://learn.microsoft.com/it-it/dotnet/csharp/fundamentals/tutorials/classes
// https://learn.microsoft.com/en-us/dotnet/csharp/fundamentals/tutorials/classes


// See https://aka.ms/new-console-template for more information


using Classes;

var account = new BankAccount("GiacConto", 1000);
Console.WriteLine($"Account {account.Number} was created for {account.Owner} with {account.Balance} initial balance.");