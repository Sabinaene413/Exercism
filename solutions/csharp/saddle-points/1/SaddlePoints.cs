public static class SaddlePoints
{
    public static IEnumerable<(int, int)> Calculate(int[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);

        for (int i = 0; i < rows; i++)
        {
            int rowMax = int.MinValue;
            for (int j = 0; j < cols; j++)
            {
                if (matrix[i, j] > rowMax)
                {
                    rowMax = matrix[i, j];
                }
            }

            for (int j = 0; j < cols; j++)
            {
                if (matrix[i, j] == rowMax)
                {
                    if (IsSmallestInColumn(matrix, j, rowMax, rows))
                    {
                        yield return (i + 1, j + 1);
                    }
                }
            }
        }
    }

    private static bool IsSmallestInColumn(int[,] matrix, int colIndex, int value, int rowCount)
    {
        for (int i = 0; i < rowCount; i++)
        {
            if (matrix[i, colIndex] < value)
            {
                return false; 
            }
        }
        return true;
    }
}
