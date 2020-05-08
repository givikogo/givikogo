using System;
public class Programm
{
    public static void Main()
    {

        Assert_AreEqual(1, F(0));
        Assert_AreEqual(4, F(2));
        Assert_AreEqual(8, F(3));
    }
    
    public static string F(int n)
    {
        int sum = n;
        string orobiti = "";
        while (sum >= 1)
        {
            if (sum % 2 == 0)
            {
                sum = sum / 2;
                orobiti = "0" + orobiti;
            }
            else
            {
                sum = sum / 2;
                orobiti = "1" + orobiti;
            }
        }
        int Nullpluss = 0;
        int HowNullcnt = n;
        for (int k = 0; k <= orobiti.Length; k++)
        {
            Nullpluss = HowNullcnt - orobiti.Length;
            if (Nullpluss >= 0)
            {
                orobiti = orobiti + "0";
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
    
    public static void Assert_AreEqual(int mosalodneli_atobitshi, string pasuxi_orobitshi)
    {
        int sum = mosalodneli_atobitshi;
        string mosalodneli_orobitishi = "";
           
        while (sum >= 1)
        {
            if (sum % 2 == 0)
            {
                sum = sum / 2;
                mosalodneli_orobitishi = "0" + mosalodneli_orobitishi;
            }
            else
            {
                sum = sum / 2;
                mosalodneli_orobitishi = "1" + mosalodneli_orobitishi;
            }
        }
        
        if (mosalodneli_orobitishi == pasuxi_orobitshi)
        {
            Console.WriteLine("true");
        }
        else
        {
            Console.WriteLine("false");
        }
        
    }
}
