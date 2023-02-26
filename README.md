Giovanni Morelli 4H - WPFThreads

Le Lambda Expression sono una funzionalità introdotta in C# 3.0 che consente di scrivere funzioni anonime in modo più conciso e leggibile. In pratica, le Lambda Expression sono un modo per definire una funzione in-linea, ovvero senza la necessità di creare una classe separata per la funzione.

In C#, le Lambda Expression possono essere utilizzate in diverse situazioni, ad esempio:
Come parametro di una funzione: ad esempio, una funzione che prende in input una Lambda Expression che rappresenta un predicato per filtrare una lista di oggetti.
Come delegati: ad esempio, una Lambda Expression può essere assegnata a un delegato che rappresenta una funzione con un determinato tipo di input e output.
Come espressioni LINQ: ad esempio, una Lambda Expression può essere utilizzata per definire una query di selezione di dati.

Ecco un esempio di Lambda Expression che definisce una funzione che prende due numeri interi e ne restituisce la somma:

(int x, int y) => x + y


Il costrutto C# lock è utilizzato per creare sezioni di codice critico che possono essere eseguite in modo sicuro da più thread contemporaneamente. In altre parole, il costrutto lock consente di evitare che più thread accedano contemporaneamente a una risorsa condivisa e causino problemi di sincronizzazione.
Il costrutto lock in C# richiede un oggetto di blocco, ovvero un oggetto che viene utilizzato per sincronizzare l'accesso a una risorsa condivisa. Il blocco viene creato utilizzando la parola chiave lock seguita dall'oggetto di blocco.
Ad esempio, il seguente codice utilizza il costrutto lock per sincronizzare l'accesso a una variabile condivisa:


class Program
{
    static int counter = 0;
    static object counterLock = new object();

    static void Main(string[] args)
    {
        for (int i = 0; i < 100; i++)
        {
            new Thread(() =>
            {
                lock (counterLock)
                {
                    counter++;
                }
            }).Start();
        }

        Thread.Sleep(1000);
        Console.WriteLine("Counter value: {0}", counter);
        Console.ReadLine();
    }
}


In questo esempio, viene creato un oggetto di blocco "counterLock" e utilizzato all'interno di un blocco "lock" per sincronizzare l'accesso alla variabile "counter". Il codice crea 100 thread che incrementano la variabile "counter" in modo asincrono, ma grazie al costrutto lock, l'accesso alla variabile è sincronizzato in modo che solo un thread alla volta possa accedervi. Alla fine del processo, viene stampato il valore di "counter".
