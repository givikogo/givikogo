using System;
using static System.Console;
public class Programm
{
    public static void Main()
    {

        Assert_AreEqual(1, F(0));
        Assert_AreEqual(4, F(2));
        Assert_AreEqual(8, F(3));

        ReadLine();
    }
    public static string F(int k)
    {
        int sum = k;

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
        int HowNullcnt = k;
        for (int j = 0; j <= orobiti.Length; j++)
        {

            Nullpluss = HowNullcnt - orobiti.Length;

            if (Nullpluss >= 0)
            {

                orobiti = orobiti + "0";

            }

        }

        string a = "";
        a += "1";

        for (int i = 1; i < k + 1; i++)
        {
            a += "0";
        }

        return a;
    }
    public static void Assert_AreEqual(int mosalodneli_atobitshi, string pasuxi_orobitshi)
    {
        int sum = mosalodneli_atobitshi;

        string Mosalodneli_orobitishi = "";


        while (sum >= 1)
        {

            if (sum % 2 == 0)
            {

                sum = sum / 2;
                Mosalodneli_orobitishi = "0" + Mosalodneli_orobitishi;

            }
            else
            {

                sum = sum / 2;
                Mosalodneli_orobitishi = "1" + Mosalodneli_orobitishi;

            }
        }
        string ans = "";
        
        if (Mosalodneli_orobitishi == pasuxi_orobitshi)
        {
            WriteLine("true");
        }
        else
        {
            WriteLine("false");
        }
        
    }
}



      



      
