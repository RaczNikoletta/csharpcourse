using System;
public static class DifferenceOfSquares
{
    public static int CalculateSquareOfSum(int max)
    {
        int sum = 0;
        for(int i=0;i<=max;i++)
        {
            sum+=i;
        }
        return sum*sum;
    }
    public static int CalculateSumOfSquares(int max)
    {
        int sum= 0;
        int sq = 0;
        for(int i=0;i<=max;i++)
        {
          sq = i*i;
          sum += sq;
        }
        return sum;
    }
    public static int CalculateDifferenceOfSquares(int max)
    {
       return CalculateSquareOfSum(max)-CalculateSumOfSquares(max);
    }
}
