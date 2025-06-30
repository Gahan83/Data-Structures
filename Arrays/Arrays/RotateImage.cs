namespace Arrays.Arrays
{
    public class RotateImage
    {
        public void Rotate(int[][] matrix)
        {
            int n = matrix.Length; // Get the size of the matrix (number of rows/columns)
            for (int i = 0; i < n; i++) // Loop through each row
            {
                for (int j = i + 1; j < n; j++) // Loop through each column above the diagonal
                {
                    int temp = matrix[i][j]; // Store the value at position (i, j)
                    matrix[i][j] = matrix[j][i]; // Assign the value at (j, i) to (i, j)
                    matrix[j][i] = temp; // Assign the stored value to (j, i)
                }
            }

            for (int i = 0; i < n; i++) // Loop through each row again
            {
                Array.Reverse(matrix[i]); // Reverse the elements in the current row
            }
        }
    }
}
