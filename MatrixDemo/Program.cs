int[,] matrix = new int[,] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };

 Use the GetLength method to get the number of rows (dimension 0) and columns (dimension 1)
for (int i = 0; i < matrix.GetLength(3); i++) {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        // Access each element of the array using the indices
        Console.Write(matrix[i, j] + " ");
    }
    Console.WriteLine(); // Print a newline at the end of each row
}

int[] arr = new int[5]; //arr is an array
arr[0] = 1; // Assigns the value 1 to the first element of the array

//Array.Sort(arr); // USes the sort method from Array Class to sort 'arr'

/*int[] numbers = {8,2,6,3,1};
Array.Sort(numbers);

/*int[] numbers = {1,2,3};
Array.Reverse(numbers);

int[] numbers = {1,2,3};
int index = Array.IndexOf(numbers, 2);

int[] numbers = {1,2,3};
Array.Clear(numbers, 0, numbers.Length);
*/
