//--------- INIZIO ESERCIZIO --- main



int[] arrayDiNumeri = { 1, 6, 9, 10 };
StampaArray(arrayDiNumeri);
int[] copiaArray = ElevaArrayAlQuadrato(arrayDiNumeri);
StampaArray(copiaArray);


int sum = SommaElementiArray(arrayDiNumeri);
Console.WriteLine("La somma di tutti i numeri è: " + sum);

int sumAlQuadrato = SommaElementiArray(ElevaArrayAlQuadrato(arrayDiNumeri));
Console.WriteLine("La somma di tutti elevati al quadrato è: " + sumAlQuadrato);










// INT ARRAY --- corpo
void StampaArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i == array.Length - 1)
        {
            Console.Write(array[i]);
        }
        else
        {
            Console.Write(array[i] + ", ");
        }

    }
    Console.Write("]");

}


int Quadrato(int numero)
{
    int risultato = 0;
    risultato = numero * numero;
    return risultato;
}







int [] ElevaArrayAlQuadrato(int[] array)
{
        
    int[] copiaArray = (int[])array.Clone();
    
    for (int i = 0; i < copiaArray.Length; i++)
    {
        copiaArray[i] = Quadrato(array[i]);
    } 
    
    return copiaArray;


}

int SommaElementiArray(int[] array)
{
    int[] copiaArray = (int[])array.Clone();
    int somma = 0;

for (int i = 0; i < array.Length; i++)
    {
        somma += copiaArray[i];
    }
    return somma;
}























