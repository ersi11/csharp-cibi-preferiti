// Cibi preferiti

Console.WriteLine("-----ESERCIZIO CIBO PTEFERITI-----");

//DICHIARO ARRAY

string[] cibiPreferiti = {"Pizza", "Pasta", "Hamburger",
    "Gelato", "Snack", "Panini", "Biscotti", "Pop-corn", "Patatine"};

// DICHIARO LUNGHEZZA CLASSIFICA

Console.WriteLine("la mia lista è composta da: " + cibiPreferiti.Length + " piatti");

//La vostra classifica (dunque stampare l’intero array in ordine indicando la posizione in classifica)

Console.WriteLine("classifica cibi: ");

for (int i = 0; i < cibiPreferiti.Length; i++) 
{
    Console.WriteLine(cibiPreferiti[i]);
}

//CIBO PREFERITO TOP E CIBO PREFERITO ULTIMO E CON CIBI PREFERITI A META' CLASSIFICA (MEDIANI)

Console.WriteLine("-----CLASSIFICA CIBI PREFERITI CON CIBI PREFERITI-----");

Console.WriteLine("Primo in classifica: " + cibiPreferiti[0]);
Console.WriteLine("Ultimo in classifica: " + cibiPreferiti[cibiPreferiti.Length-1]);



/*for (int i = 0; i < cibiPreferiti.Length; i++)
{
    if (cibiPreferiti[i] == cibiPreferiti[4])
    {
        Console.WriteLine(cibiPreferiti[4]);

    }

}*/

int posizioneMedio = cibiPreferiti.Length / 2;

if (cibiPreferiti.Length % 2 == 0)
{
    Console.WriteLine("cibo posizione media è: " + cibiPreferiti[posizioneMedio] + 
        cibiPreferiti[posizioneMedio - 1]);
} 
else
{
    Console.WriteLine("posizione media è: " + cibiPreferiti[posizioneMedio]);
}








