class LargestPrimeFactor
{
    public int primeFactor = 2;

    public void Factorize(long number)
    {
        while(number > 1)
        {
            if(number%primeFactor == 0)
                number = number/primeFactor;
            
            else
                ChangePrimeFactor();
        }

        Console.WriteLine(primeFactor);
    }
    void ChangePrimeFactor()
    {
        int nextnp = primeFactor;
        int counter = 0;

        do
        {
            counter = 0;
            nextnp = nextnp + 1;

            for(int i = nextnp; i >= 1; i--)
            {
                if(nextnp % i == 0)
                    counter++;    
            }

        }while(counter != 2);

        primeFactor = nextnp;
    }
}