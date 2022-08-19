class SmallestMultiple
{
    int smallestMultiple = 2520;
    
    public int FindSmallestMultiple()
    {
        bool found = false;
        while(!found)
        {
            smallestMultiple++;
            for(int i = 1; i <= 20; i++)
            {
                if(smallestMultiple % i == 0)
                {
                    found = (i == 20) ? true : false;
                }
                else 
                    break;
            }
        }
        return smallestMultiple;
    }
}