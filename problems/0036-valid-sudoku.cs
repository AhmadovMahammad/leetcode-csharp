public class Solution
{
    public bool IsValidSudoku(char[][] board)
    {
        int bs = 3;
        int bl = board.Length;
        HashSet<int> set = new HashSet<int>();
        
        for(int i = 0; i < bs; i++)
        {
            for(int j = 0; j < bs; j++)
            {
                for(int k = 0; k < bs; k++)
                {
                    for(int n = 0; n < bs; n++)
                    {
                        char c = board[i * bs + k][j * bs + n];
                        if(c != . && !set.Add(c))
                        {
                            return false;
                        }
                    }
                }

                set.Clear();
            }
        }

        for(int i = 0; i < bl; i++)
        {
            for(int j = 0; j < bl; j++)
            {
                char c = board[i][j];
                if(c != . && !set.Add(c))
                {
                    return false;
                }
            }

            set.Clear();
        }

        for(int i = 0; i < bl; i++)
        {
            for(int j = 0; j < bl; j++)
            {
                char c = board[j][i];
                if(c != . && !set.Add(c))
                {
                    return false;
                }
            }

            set.Clear();
        }

        return true;
    }
}

// int bs = 3;
        
// for(int i = 0; i < bs; i++)
// {
//     for(int j = 0; j < bs; j++)
//     {
//         Console.WriteLine($"BLOCK : {i * bs + j + 1}");
        
//         for(int k = 0; k < bs; k++)
//         {
//             for(int n = 0; n < bs; n++)
//             {
//                 Console.Write(board[i * bs + k][j * bs + n]);
//             }
            
//             Console.WriteLine();
//         }
        
//         Console.WriteLine();
//     }
// }
