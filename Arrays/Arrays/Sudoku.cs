namespace Arrays.Arrays
{
    public class Sudoku
    {
        public bool IsValidSudoku(char[][] board)
        {
            HashSet<string> seen = new HashSet<string>(); // HashSet to keep track of seen numbers in rows, columns, and boxes

            for (int i = 0; i < 9; i++) // Iterate over each row
            {
                for (int j = 0; j < 9; j++) // Iterate over each column
                {
                    char c = board[i][j]; // Get the current cell value

                    if (c == '.') continue; // Skip empty cells

                    // Check if the number has already been seen in the current row, column, or 3x3 box
                    if (!seen.Add($"row {i} contains {c}") || // Check row
                        !seen.Add($"row {j} contains {c}") || // Check column (BUG: should be column, not row)
                        !seen.Add($"box {i / 3}-{j / 3} contains {c}")) // Check 3x3 box
                    {
                        return false; // If duplicate found, board is invalid
                    }
                }
            }
            return true; // If no duplicates found, board is valid
        }
    }
}
