namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 1


            //    Console.Write("Enter the size of the identity matrix (n): ");
            //int.TryParse(Console.ReadLine(), out int n);

            //    Console.WriteLine($"Identity Matrix of size {n} x {n}:");
            //for (int i = 0; i < n; i++)
            //{
            //    for (int j = 0; j < n; j++)
            //    {
            //        if (i == j)
            //        {
            //            Console.Write("*");
            //        }
            //        else
            //        {
            //            Console.Write("*");
            //        }
            //    }
            //    Console.WriteLine();
            //}
            #endregion


            #region 2
            //int[] array = { 1, 2, 3, 4, 5, 6, 7, 8 };
            //int sum = 0;
            //for (int i = 0; i < array.Length; i++)
            //{
            //    sum += array[i]; 

            //}
            //Console.WriteLine(sum);
            #endregion

            #region 3
            //int[] array2 = { 1, 2, 3, 4, 5, 6, 7, 8 };
            //int[] array3 = { 1, 4, 3, 2, 14 };

            //Array.Sort(array2);
            //foreach (var item in array2)
            //{
            //    Console.WriteLine(item);
            //}





            #endregion

            #region 4
            //int count = 0;
            //int[] arr = { 1, 2, 3 };
            //for (int i = 0; i < arr.Length; i++) { 
            //    count++;    
            //}
            //Console.WriteLine(count);
            #endregion


            #region 5
            //int[] arr01 = { 1, 2, 3 };
            //int max = arr01[0];
            //int min = arr01[0];
            //for (int i = 0; i < arr01.Length; i++)
            //{ if (arr01[i] > max) 
            //    { max = arr01[i]; } 
            //    if (arr01[i] < min) 
            //    { min = arr01[i];
            //    } }
            //Console.WriteLine($"maximum number is{max}");
            //Console.WriteLine($"minimum number is{min}");
            #endregion

            #region 6



            //int[] array = { 3, 2, 4, 53, 74, 89 };


            //int largest = int.MinValue;
            //int secondLargest = int.MinValue;

            //for (int i = 0; i < array.Length; i++)
            //{
            //    if (array[i] > largest)
            //    {
            //        secondLargest = largest;
            //        largest = array[i];
            //    }
            //    else if (array[i] > secondLargest && array[i] != largest)
            //    {
            //        secondLargest = array[i];
            //    }
            //}


            //if (secondLargest == int.MinValue)
            //{
            //    Console.WriteLine("There is no second largest element in the array.");
            //}
            //else
            //{
            //    Console.WriteLine($"The second largest element in the array is: {secondLargest}");
            //}



            #endregion
            #region 7
            //int[] arraay = { 7, 0, 0, 0, 0, 5, 6, 7, 5, 0, 7, 5, 3 };



            #endregion

            #region 8
            /////
            #endregion

            #region 9



            //string[] words = { "mazen" };


            //Array.Reverse(words);



            //foreach (var item in words)
            //{
            //    Console.WriteLine($"Reversed order: {item}");
            //}


            #endregion

            #region 10



            //    Console.Write("Enter the number of rows: ");
            //    int rows = Convert.ToInt32(Console.ReadLine());
            //    Console.Write("Enter the number of columns: ");
            //    int columns = Convert.ToInt32(Console.ReadLine());


            //    int[,] array1 = new int[rows, columns];


            //    Console.WriteLine("Enter the elements of the first array:");
            //    for (int i = 0; i < rows; i++)
            //    {
            //        for (int j = 0; j < columns; j++)
            //        {
            //            Console.Write($"Element [{i},{j}]: ");
            //            array1[i, j] = Convert.ToInt32(Console.ReadLine());
            //        }
            //    }


            //    int[,] array2 = new int[rows, columns];


            //    for (int i = 0; i < rows; i++)
            //    {
            //        for (int j = 0; j < columns; j++)
            //        {
            //            array2[i, j] = array1[i, j];
            //        }
            //    }


            //    Console.WriteLine("The elements of the second array are:");
            //for (int i = 0; i < rows; i++)
            //{
            //    for (int j = 0; j < columns; j++)
            //    {
            //        Console.Write(array2[i, j] + " ");
            //    }
            //    Console.WriteLine();

            //}
            #endregion

            #region 11



            //Console.Write("Enter the number of elements in the array: ");
            //int n = int.Parse(Console.ReadLine());


            //int[] array = new int[n];


            //Console.WriteLine("Enter the elements of the array:");
            //for (int i = 0; i < n; i++)
            //{
            //    array[i] = int.Parse(Console.ReadLine());
            //}


            //Console.WriteLine("Array in reverse order:");
            //for (int i = n - 1; i >= 0; i--)
            //{
            //    Console.Write(array[i] + " ");
            //}
            //Console.WriteLine();


            #endregion
        }
    }
}


