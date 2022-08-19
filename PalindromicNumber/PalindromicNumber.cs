class PalindromicNumber
{
    public int MakePalindrome(int firstHalf)
    {
        char[] reversed = firstHalf.ToString().Reverse().ToArray();
        return Convert.ToInt32(firstHalf + new string(reversed));
    }

    public int LargestPalindromeProduct()
    {
        bool found = false;
        int firstHalf = 998;
        int palindrome = 0;

        while(!found)
        {
            firstHalf--;
            palindrome = MakePalindrome(firstHalf);
            for(int i = 999; i > 99; i--)
            {
                if((palindrome /i) > 999 || i * i < palindrome )
                {
                    break;
                }

                if((palindrome % i) == 0)
                {
                    found = true;
                    break;
                }
            }
        }
        return palindrome;
    }
}