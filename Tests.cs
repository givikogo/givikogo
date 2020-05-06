using System;
using static System.Console;
public class Programm
{
    public static void Main()
    {
        WriteLine(F(1, 0));
        WriteLine(F(4, 2));
        WriteLine(F(8, 3));

        ReadLine();
    }
    public static bool F(int x,int k)
    {
        int sum = k;
        int sum2 = x;
        string orobiti = "";
        string orobitiX = "";

        while (sum >= 1)
        {

            if (sum % 2 == 0)
            {

                sum = sum / 2;
                orobiti = "0"+orobiti;

            }
            else
            {

                sum = sum / 2;
                orobiti = "1" + orobiti;

            }
        }

        while (sum2 >= 1)
        { 
           
            if (sum2 % 2 == 0)
            {

                sum2 = sum2 / 2;
                orobitiX = "0" + orobitiX;

            }

            else
           {

                sum2 = sum2 / 2;
                orobitiX = "1" + orobitiX;

            }
        }


        int Nullpluss = 0;
        int HowNullcnt = k;
        for (int j = 0; j <= orobiti.Length; j++)
        {

            Nullpluss = HowNullcnt-orobiti.Length;
            
            if(Nullpluss >= 0)
            {
                
                orobiti = orobiti+"0";

            }
       
        }
       
        bool ans;
        bool a = true, b = false;
        if (orobitiX.Length == orobiti.Length)
        {

            ans = a;
       
        }
        else ans = b;

     
        return ans;
    }

}
