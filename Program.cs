class Program
{
    static void Main()
    {
        PrimeNumber primeNumber = new PrimeNumber();
        List<int> primeNumbers = primeNumber.GeneratePrimes(105000);
        Console.WriteLine(primeNumbers[10000]);
        

       /* SumSquareDifference sumSquare = new SumSquareDifference();
        Console.WriteLine(sumSquare.Difference());*/

        /*SmallestMultiple smallestMultiple = new SmallestMultiple();
        Console.WriteLine(smallestMultiple.FindSmallestMultiple());

        /*PalindromicNumber palindromicNumber = new PalindromicNumber();
        Console.WriteLine(palindromicNumber.LargestPalindromeProduct());

       /* LargestPrimeFactor largestPrimeFactor = new LargestPrimeFactor();
        largestPrimeFactor.Factorize(600851475143);*/

       /* EvenFibonacciNumbers fibonacciNumbers = new EvenFibonacciNumbers();
        Console.WriteLine("Even fibonacci Numbers");
        Console.WriteLine(fibonacciNumbers.FindFibonacciTerms());


        Multiples multiples = new Multiples();
        Console.WriteLine("Multiples exercise");
        Console.WriteLine(multiples.SumMultiples());*/
    }
}
