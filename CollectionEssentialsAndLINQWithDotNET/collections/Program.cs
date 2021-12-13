using System;
using collections.Helper;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayNumbers = new int[12] {1, 4, 5, 12, 15, 52, 4, 45, 5, 18, 12, 45};

            var sum = arrayNumbers.Sum();
            var distinct = arrayNumbers.Distinct().ToArray();

            var min = arrayNumbers.Min();
            var max = arrayNumbers.Max();
            var average = arrayNumbers.Average();
            System.Console.WriteLine($"minimo: {min}\nmaximo: {max}\naverage: {average}");

            System.Console.WriteLine($"total sum:{sum}");
            System.Console.WriteLine($"original array: {string.Join(", ", arrayNumbers)}");
            System.Console.WriteLine($"array distinct: {string.Join(", ", distinct)}");
        //LINQ
            // int[] arrayNumbers = new int[5] {1, 4, 8, 12, 15};

            // var numbersPairsQuery = 
            //     from num in arrayNumbers
            //     where num % 2 == 0
            //     orderby num
            //     select num;
            // var numbersPairsMethod = arrayNumbers.Where(x => x % 2 == 0).OrderBy(x => x).ToList();

            // System.Console.WriteLine("numbers pairs query: " + string.Join(", ", numbersPairsQuery));
            // System.Console.WriteLine("numbers pairs method: " + string.Join(", ", numbersPairsMethod));
            
        //dictionary
            // Dictionary<string, string> estados = new Dictionary<string, string>();

            // estados.Add("SP", "São Paulo");
            // estados.Add("PE", "Pernambuco");
            // estados.Add("AL", "Alagoas");

            // foreach(KeyValuePair<string, string> item in estados)
            // {
            //     System.Console.WriteLine($"Key: {item.Key}, Value: {item.Value}");
            // }

            // string valueSearched = "SP";
            // //var test = estados["SC"];

            // if(estados.TryGetValue(valueSearched, out string valueFinded))
            // {
            //     System.Console.WriteLine(valueFinded);
            // }
            // else
            // {
            //     System.Console.WriteLine($"Key doesn't exist in the dictionary: {valueSearched}");
            // }
            // System.Console.WriteLine($"removing the value: {valueSearched}");
            // estados.Remove(valueSearched);

            // foreach(KeyValuePair<string, string> item in estados)
            // {
            //     System.Console.WriteLine($"Key: {item.Key}, Value: {item.Value}");
            // }

            

            // System.Console.WriteLine($"the original value: ");
            // System.Console.WriteLine(estados[valueSearched]);

            // estados[valueSearched] = "SP - São Paulo";

            // System.Console.WriteLine("the updated value:");
            // System.Console.WriteLine(estados[valueSearched]);

        //pilha - LIFO
            // Stack<string> pilhaBooks = new Stack<string>();

            // pilhaBooks.Push("A menina que roubava livros");
            // pilhaBooks.Push("Harry Potter e a pedra filosofal");
            // pilhaBooks.Push("O Hobbit");

            // System.Console.WriteLine($"books to read {pilhaBooks.Count}");
            
            // while (pilhaBooks.Count > 0)
            // {
            //     System.Console.WriteLine($"next book to read is : {pilhaBooks.Peek()}");
            //     System.Console.WriteLine($"{pilhaBooks.Pop()} is read with the sucess");
            // }
            // System.Console.WriteLine($"there is {pilhaBooks.Count} to read");

        //fila - FIFO
            // Queue<string> fila = new Queue<string>();
            // fila.Enqueue("Jorge");
            // fila.Enqueue("Ana");
            // fila.Enqueue("Maria");
            // fila.Enqueue("Leandro");

            // while(fila.Count > 0)
            // {
            //     System.Console.WriteLine("instead of: " + fila.Peek());
            //     System.Console.WriteLine($"{fila.Dequeue()} answered ");
            // }
            // System.Console.WriteLine($"people in the queue: " + fila.Count());


        //add a element in the list
            // OperationsList opList = new OperationsList();
            // List<string> estados = new List<string>() {"SP"};
            // string[] estadosArray = new string[2] {"SC", "MS"};

            // estados.Add("PE");
            // estados.Add("PB");
            // estados.Add("MG");

            // System.Console.WriteLine($"number of list elements: {estados.Count} \n");

            // opList.PrintListString(estados);

            // estados.Insert(1, "RJ");

            // estados.AddRange(estadosArray);
            // opList.PrintListString(estados);

        //i remove a element from the list    
            // estados.Remove("MG");

            // System.Console.WriteLine("i removing the elements: " + estados.Count);

            // opList.PrintListString(estados);

            // foreach (string item in estados)
            // {
            //     System.Console.WriteLine(item);
            // }

            // for(int i = 0; i < estados.Count; i++)
            // {
            //     System.Console.WriteLine($"index: {i} and the value: {estados[i]}");
            // }

        //studying array
            // ArrayOperators op = new ArrayOperators();
            // int[] array = new int[10] {5, 43, 27, 39, 26, 15, 13, 52, 24, 37};
            // int[] arrayCopy = new int[15];
            // string[] arrayString = op.ConvertingtoStringArray(array);

            // int valueSearched = 52;

            // System.Console.WriteLine($"Size of the array: {array.Length}");
            // op.Resize(ref array, array.Length * 2);

            // System.Console.WriteLine($"Resize of the array: {array.Length}");

            // int index = op.ObtainIndex(array, valueSearched);

            // if(index > -1)
            // {
            //     System.Console.WriteLine("the index {0} of the element is: {1}", valueSearched, index);
            // }
            // else
            // {
            //     System.Console.WriteLine("the value isn't exist in the array");
            // }

            // int valueFinded = op.ObtainedValue(array, valueSearched);

            // if(valueFinded > 0)
            // {
            //     System.Console.WriteLine("value is finded: {0}", valueSearched);
            // }
            // else
            // {
            //     System.Console.WriteLine("i don't find the value: {0}", valueSearched);
            // }


            // bool allBigThan = op.BigThan(array, valueSearched);

            // if(allBigThan)
            // {
            //     System.Console.WriteLine("all the values are bigger than: {0}", valueSearched);
            // }
            // else
            // {
            //     System.Console.WriteLine("exist values aren't bigger than: {0}", valueSearched);
            // }

            // bool exist = op.Exists(array, valueSearched);

            // if(exist)
            // {
            //     System.Console.WriteLine("i find the value: {0}", valueSearched);
            // }
            // else
            // {
            //     System.Console.WriteLine("i don't find the value: {0}", valueSearched);
            // }


            // System.Console.WriteLine("the original array is: ");
            // op.PritArray(array);

            // op.OrderBubbleSort(ref array);
            // op.Order(ref array);

            // System.Console.WriteLine("Array is odered: ");
            // op.PritArray(array);

            // System.Console.WriteLine("Array before the copy: ");
            // op.PritArray(arrayCopy);

            // op.Copy(ref array, ref arrayCopy);
            // System.Console.WriteLine("Array after the copy: ");
            // op.PritArray(arrayCopy);


        //studying matrix
            // int[,] nameOfMatrix = new int[3, 2]
            // {//linha{column0, column1}
            //     { 8, 8},//0{0, 1}
            //     {10,20},//1{0, 1}
            //     {50,100}//2{0, 1}
            // };

            // for (int i = 0; i < nameOfMatrix.GetLength(0); i++)//for to line
            // {
            //     for (int j = 0; j < nameOfMatrix.GetLength(1); j++)//for to column
            //     {
            //         System.Console.WriteLine(nameOfMatrix[i, j]);
            //     }
            // }

            
        //studying array
            //   int[] nameOfArray = new int[3];
            //   nameOfArray[0] = 10;
            //   nameOfArray[1] = 20;
            //   nameOfArray[2] = int.Parse("30");
            //   nameOfArray[3] = 40;        

            //   for (int i = 0; i < nameOfArray.Length; i++)//usando for
            //   {
            //       System.Console.WriteLine("i'm using the for loop");
            //       System.Console.WriteLine(nameOfArray[i]);
            //   }
            //   foreach ( int item in nameOfArray)//usando foreach
            //   {
            //       System.Console.WriteLine("i'm using the foreach loop");
            //       System.Console.WriteLine(item);
            //   }  
        }
    }
}