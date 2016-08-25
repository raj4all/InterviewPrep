using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
class Pangram
{
    public void PangramCheck(string inputString)
    {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
        //string s = Console.ReadLine();

        int[] asciis = new int[26];
        int j = 0;
        for (int i = 0; i < inputString.Length; i++)
        {
            byte[] ASCIIValues = Encoding.ASCII.GetBytes(inputString[i].ToString().ToLower());
            foreach (byte b in ASCIIValues)
            {
                //if (((65 <= b) && (b <= 90)) || ((97 <= b) && (b <= 122)))
                if (97 <= b && b <= 122)
                    if (!AlreadyExist(asciis, b))
                    {
                        asciis[j] = b;
                        j++;
                    }
            }

            //Console.WriteLine(char.GetNumericValue(s[i]));
        }
        Console.WriteLine(asciis.Length);
        if (j == 26)
            Console.WriteLine("pangram");
        else
            Console.WriteLine("not pangram");
    }
    bool AlreadyExist(int[] asciis, int b)
    {
        foreach (int i in asciis)
        {
            if (b == i)
                return true;
        }
        return false;
    }
}