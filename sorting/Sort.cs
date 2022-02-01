using System;

namespace aula.sorting
{
    public class Sort
    {

        public static int[] Iniciar(int[] elementos, bool search) {
            Console.ReadLine();

            Console.WriteLine("Ordenação...");            

            Console.WriteLine("Escolha uma das opções...");
            Console.WriteLine("1. Insertion Sort...");
            Console.WriteLine("2. Quick Sort...");
            Console.WriteLine("3. Merge Sort");
            Console.WriteLine("4. Bubble Sort");
            Console.WriteLine("5. Shell Sort");
            Console.Write("Opção: ");

            switch (Console.Read())
            {
                case '1':
                    Console.ReadLine();

                    var elementosInsertionSort = InsertionSort.insertionSort(elementos);
                    
                    if(!search)
                    {
                        Console.WriteLine("Valores ordenados...");
                        for(int i=0;i < elementosInsertionSort.Length; i++) {
                        Console.WriteLine("Numero da posição {0} - {1}", i, elementosInsertionSort[i]);
                        }
                    }
                    
                    return elementosInsertionSort;
                case '2':
                    Console.ReadLine();

                    var elementosQuickSort = QuickSort.Quicksort(elementos, 0, elementos.Length - 1);
                    
                    if(!search)
                    {
                        Console.WriteLine("Valores ordenados...");
                        for(int i=0;i < elementosQuickSort.Length; i++) {
                            Console.WriteLine("Numero da posição {0} - {1}", i, elementosQuickSort[i]);
                        }
                    }

                    return elementosQuickSort;
                case '3':
                    Console.ReadLine();

                    var elementosMergeSort = MergeSort.MergeSort_Recursive(elementos, 0, elementos.Length - 1);

                    if(!search)
                    {
                        Console.WriteLine("Valores ordenados...");
                        for(int i=0;i < elementosMergeSort.Length; i++) {
                            Console.WriteLine("Numero da posição {0} - {1}", i, elementosMergeSort[i]);
                        }
                    }

                    return elementosMergeSort;
                case '4':
                    Console.ReadLine();

                    var elementosBubbleSort = BubbleSort.BubbleSorting(elementos);

                    if(!search)
                    {
                        Console.WriteLine("Valores ordenados...");
                        for(int i=0;i < elementosBubbleSort.Length; i++) {
                            Console.WriteLine("Numero da posição {0} - {1}", i, elementosBubbleSort[i]);
                        }
                    }
                    
                    return elementosBubbleSort;
                case '5':
                    Console.ReadLine();

                    var elementosShellSort = ShellSort.ShellSorting(elementos);
                    
                    if(!search)
                    {
                        Console.WriteLine("Valores ordenados...");
                        for(int i=0;i < elementosShellSort.Length; i++) {
                            Console.WriteLine("Numero da posição {0} - {1}", i, elementosShellSort[i]);
                        }
                    }
                    
                    return elementosShellSort;
                default:
                    Console.WriteLine("Opção invalida, tente novamente...");
                    return elementos;
            }
            //Iniciar(elementos, false); //?
        }
    }
} 