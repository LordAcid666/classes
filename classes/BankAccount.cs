/*
 * Questo file conterrà la definizione di un conto bancario.
 * La programmazione orientata agli oggetti organizza il codice creando tipi sotto forma di classi.
 * Queste classi contengono il codice che rappresenta un'entità specifica.
 * La classe BankAccount rappresenta un conto bancario.
 * Il codice implementa operazioni specifiche tramite metodi e proprietà.
 * In questa esercitazione il conto bancario supporta questo comportamento:

Esiste un numero di 10 cifre che identifica in modo univoco il conto.
Esiste una stringa in cui vengono archiviati i nomi dei titolari.
È possibile recuperare il saldo.
Il conto accetta versamenti.
Il conto accetta prelievi.
Il saldo iniziale deve essere positivo.
I prelievi non possono comportare un saldo negativo.

 */


namespace Classes
{
    public class BankAccount
    {
        // PROPERTIES
        private static int accountNumberSeed = 1234567890;
        public string Number { get; }
        public string Owner { get; set; }
        public decimal Balance 
        {
            get
            {
                decimal balance = 0;
                foreach (var item in allTransactions)
                {
                    balance += item.Amount;
                }

                return balance;
            }
        }

        // CONSTRUCTORS
        public BankAccount(string name, decimal initialBalance)
        {
            this.Number = accountNumberSeed.ToString();
            accountNumberSeed++;

            this.Owner = name;
            MakeDeposit(initialBalance, DateTime.Now, "Initial balance");
        }

        private List<Transaction> allTransactions = new List<Transaction>();  

        // METHODS
        public void MakeDeposit(decimal amount, DateTime date, string note)
        {
            if (amount <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "Amount of deposit must be positive");
            }
            var deposit = new Transaction(amount, date, note);
            allTransactions.Add(deposit);
        }

        public void MakeWithdrawal(decimal amount, DateTime date, string note)
        {
            if (amount <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "Amount of withdrawal must be positive");
            }
            if (Balance - amount < 0)
            {
                throw new InvalidOperationException("Not sufficient funds for this withdrawal");
            }
            var withdrawal = new Transaction(-amount, date, note);
            allTransactions.Add(withdrawal);
        }
    }
}
