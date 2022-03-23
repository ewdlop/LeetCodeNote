namespace LeetCodeNote;

public partial interface ISolution
{
    public void Rotate(int[][] matrix)
    {
        int n = matrix.Length;
        for (int i = 0; i < (n + 1) / 2; i++)
        {
            for (int j = 0; j < n / 2; j++)
            {
                int temp = matrix[n - 1 - j][i];
                matrix[n - 1 - j][i] = matrix[n - 1 - i][n - j - 1];
                matrix[n - 1 - i][n - j - 1] = matrix[j][n - 1 - i];
                matrix[j][n - 1 - i] = matrix[i][j];
                matrix[i][j] = temp;
            }
        }
    }

    public void RotateBy90Degree(int[][] matrix)
    {
        int n = matrix.Length;
        for (int i = 0; i < (n + 1) / 2; i++)
        {
            for (int j = 0; j < n / 2; j++)
            {
                (matrix[n - j - 1][i], matrix[n - i - 1][n - j - 1], matrix[j][n - i - 1], matrix[i][j]) = (
                    matrix[n - i - 1][n - j - 1],
                    matrix[j][n - i - 1],
                    matrix[i][j],
                    matrix[n - 1 - j][i]
                );
            }
        }
    }
}

public static partial class IntegerArrayExtension
{
    public static void RotateBy90Degree(this int[][] matrix)
    {
        int n = matrix.Length;
        for (int i = 0; i < (n + 1) / 2; i++)
        {
            for (int j = 0; j < n / 2; j++)
            {
                (matrix[n - j - 1][i], matrix[n - i - 1][n - j - 1], matrix[j][n - i - 1], matrix[i][j]) = (
                    matrix[n - i - 1][n - j - 1],
                    matrix[j][n - i - 1],
                    matrix[i][j],
                    matrix[n - 1 - j][i]
                );
            }
        }
    }
}