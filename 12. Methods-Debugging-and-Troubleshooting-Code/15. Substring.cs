using System;

public class Substring_broken
{
    public static void Main()
    {
        string text = Console.ReadLine();
        int jump = int.Parse(Console.ReadLine());

        bool hasMatch = false;

        for (int i = 0; i < text.Length; i++)
        {
            if (text[i] == 'p')
            {
                hasMatch = true;
                string matchedString = null;

                int endIndex = i + jump + 1;

                if (endIndex < text.Length)
                {
                    matchedString = text.Substring(i, jump + 1);
                }
                else
                {
                    matchedString = text.Substring(i, text.Length - i);
                }
                Console.WriteLine(matchedString);

                i += jump;
            }
        }

        if (!hasMatch)
        {
            Console.WriteLine("no");
        }
    }
}