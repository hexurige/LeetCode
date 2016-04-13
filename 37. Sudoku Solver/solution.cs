public class Solution
{
    public void SolveSudoku(char[,] board)
    {
        var width = board.GetLength(0);
        var height = board.GetLength(1);

        for (int i = 0; i < width; i++)
        {
            for (int j = 0; j < height; j++)
            {
                //exclude row
                //exclude column
                //exclude 3x3
            }
        }
    }
}