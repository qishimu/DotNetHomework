using System;
//托普利茨矩阵：左上到右下对角线的元素都相同，但有时候对角线并不明显该如何判断 
namespace Four
{
    class Program
    {
        static void Main(string[] args)
        {
           
        }
    }
}
public class Solution//略微借鉴了上网上，开始对角线理解错误
{
    public bool IsToeplitzMatrix(int[][] matrix)
    {
        //每个元素都与左上角的数字比较
        for (var i = 0; i < matrix.Length; i++)
        {
            for (var j = 0; j < matrix[i].Length; j++)
            {
                if (i != 0 && j != 0 && matrix[i][j] != matrix[i - 1][j - 1])
                {
                    return false;
                }
            }
        }
        return true;
    }
}
