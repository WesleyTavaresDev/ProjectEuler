class SumSquareDifference
{

    public int Difference() => SquareOfSum() - SumOfSquares(); 

    int SumOfSquares()
    {
        int result = 0;
        for(int i = 1; i <= 100; i ++)
            result += i * i;
        return result;
    }

    int SquareOfSum()
    {
        int sum = ((1 + 100) * 100) / 2;
        return sum * sum;
    }
}