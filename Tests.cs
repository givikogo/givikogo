using System;
public class Programm
{
    public static void Main()
    {

        Console.WriteLine(AssertAreEqual(1, Binary(0)));
        Console.WriteLine(AssertAreEqual(4, Binary(2)));
        Console.WriteLine(AssertAreEqual(8, Binary(3)));
    }
    
    public static string Binary(int n)
    {
        int sum = n;
        string binary = "";
        while (sum >= 1)
        {
            if (sum % 2 == 0)
            {
                sum = sum / 2;
                binary = "0" + binary;
            }
            else
            {
                sum = sum / 2;
                binary = "1" + binary;
            }
        }
        int Nullpluss = 0;
        int HowNullcnt = n;
        for (int k = 0; k <= binary.Length; k++)
        {
            Nullpluss = HowNullcnt - binary.Length;
            if (Nullpluss >= 0)
            {
                binary = binary + "0";
            }
        }
 ///დაბრუნებს a-ს რომელსაც ორობით წარმოდგენაში, k-აურ ადგილზე ექნება 1-იანი დანარჩენი ყველა 0-ები
        string a = "";
        a += "1";
        for (int k = 1; k < n + 1; k++)
        {
            a += "0";
        }
        return a;
    }
    
    public static bool AssertAreEqual(int x, string y)
    {
        int sum = x;
        string Xbinary = "";
           
        while (sum >= 1)
        {
            if (sum % 2 == 0)
            {
                sum = sum / 2;
                Xbinary = "0" + Xbinary;
            }
            else
            {
                sum = sum / 2;
                Xbinary = "1" + Xbinary;
            }
        }
        bool ans;
        
        if (Xbinary == y)
        {
            ans = true;
        }
        else
        {
            ans = false;
        }
        return ans;
    }
}
