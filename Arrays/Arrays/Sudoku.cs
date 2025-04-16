namespace Arrays.Arrays
{
    public class Sudoku
    {
        public bool IsValidSudoku(char[][] board)
        {
            HashSet<string> seen = new HashSet<string>();

            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    char c = board[i][j];

                    if (c == '.') continue;

                    if (!seen.Add($"row {i} contains {c}") ||
                        !seen.Add($"row {j} contains {c}") ||
                        !seen.Add($"box {i/3}-{j/3} contains {c}"))
                    {
                        return false;
                    }
                }
            }
            return true;
        }
    }
}
