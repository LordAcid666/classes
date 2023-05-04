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
        public string Number { get; }
        public string Owner { get; set; }

        public void MakeDeposit(decimal amount, DateTime date, string note)
        {

        }

        public void MakeWithdrawal(decimal amount, DateTime date, string note)
        {

        }
    }
}
