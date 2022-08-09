using System;

class Character
{
    public static bool IsLower(char c)
    {
        for (char alphabet = 'a'; alphabet <= 'z'; alphabet++)
        {
            if (alphabet == c)
            {
                return True;
            }
        }
        return False;
    }
}