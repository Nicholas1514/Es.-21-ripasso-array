using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Es._21_ripasso_array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[5];
            int nel; //numero elementi utilizzati
            int dim = 0;
            int scelta = 0;
            int ncerca;

            //struttura del menù
            do
            {
                //stampa delle opzioni
                Console.Clear();
                Console.WriteLine("1 - aggiunta elemento");
                Console.WriteLine("2 - stampa elementi");
                Console.WriteLine("3 - cerca elemento");
                Console.WriteLine("4 - aggiunta elemento posizione");
                Console.WriteLine("0 - uscita");
                //scelta opzione
                Console.WriteLine("Inserisci la scelta ");
                scelta = int.Parse(Console.ReadLine());

                //esecuzione dell'opzione
                switch (scelta)
                {
                    case 1:
                        Console.WriteLine("Inserisci elemento");
                        int ele = int.Parse(Console.ReadLine());
                        if (addArray(array, ele, ref dim) == true)
                        {
                            Console.WriteLine("Elemento inserito corettamente");
                        }
                        else
                        {
                            Console.WriteLine("Array pieno");
                        }
                        break;

                    case 2:
                        for (int i = 0; i < dim; i++)
                        {
                            Console.WriteLine(array[i]);
                        }
                        break;
                    case 3:
                        Console.WriteLine("Inserisci l'elemento che vuoi cercare");
                        ncerca = int.Parse(Console.ReadLine());
                        Cerca(array,ref ncerca,dim);
                        break;
                    case 4:
                        Console.WriteLine("Inserisci elemento");
                        int n = int.Parse(Console.ReadLine());
                        Console.WriteLine("Inserisci la posizione dell'elemento");
                        int pos = int.Parse(Console.ReadLine());
                        break;

                }
                Console.ReadLine();
            }
            while (scelta != 0);


        }

        //funzione aggiungi --> aumentare dimensione utilizzata, aggiungere elemento array, controllare la dimensione massima
        static bool addArray(int[] a, int e, ref int index)
        {
            //controllare se abbiamo raggiunto la dimensione massima
            bool inserito = true;
            if (index < a.Length)
            {
                //aggiungere l'elemento
                a[index] = e;
                //incrementare l'indice
                index++;
            }
            else
                inserito = false;
            return inserito;

        }
        static void Cerca(int[]array,ref int ncerca,int dim)
        {
            for(int i = 0; i < dim; i++)
            {
                if(ncerca == array[i])
                {
                    Console.WriteLine("La posizione dell'elemento è: " + i);
                }
                else
                {
                    Console.WriteLine("- 1");
                }
               
               
            }
           
          
        }
 

    }
}


