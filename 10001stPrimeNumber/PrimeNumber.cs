class PrimeNumber
{
    bool IsPrimeNumber(int num)
    {
        if(num == 1)
            return false;

        double numSqrt = Math.Floor(Math.Sqrt(num));

        for(int i =2; i <= numSqrt; i++)
        {
            if(num % i == 0)
                return false;
        }

        return true;
    }


    public List<int> GeneratePrimes(int limit)
    {
        List<int> primes = new List<int>();
        for(int i = 2; i <= limit; i++)
        {
            if(IsPrimeNumber(i))
                primes.Add(i);
        }

        return primes;
    }
}