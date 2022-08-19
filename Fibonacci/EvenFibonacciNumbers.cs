class EvenFibonacciNumbers
{

    public long FindFibonacciTerms()
    {
        long sum = 2;

        long previousTerm = 1;
        long currentTerm = 2;
        long nextTerm = 0;
        
        while(nextTerm < 4000000)
        {
            nextTerm = previousTerm + currentTerm;
            previousTerm = currentTerm;
            currentTerm = nextTerm;

            if(nextTerm % 2 == 0)
                sum += nextTerm;
        }

        return sum;
    }
}