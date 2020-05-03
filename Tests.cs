using System;
using static System.Console;        

public class Program
{
    public static void Main()
    {
        //Test2();
        //Test3();
    
        //Test6();
        //Test7();
        //Test8();
        //Test9();
        //Test10();
    }
////////// Test2   
    public static void Test2()
    {
        IsEqual(
            @"Welcome Friends! 
Have a nice day!", 
            Welcome()
        );
        
        IsEqual(
            @"Welcome friend John !
Have a nice day!", 
            WelcomeFriend("John")
        );
    
        IsEqual(
            @"Welcome friend Jubiko !
Have a nice day!", 
            WelcomeFriend("Jubiko")
        );
        
    }

/// Solutions Test2
    
    public static string WelcomeFriend(string name) 
    {
        return @$"Welcome friend {name} !
Have a nice day!";
    }
    
    public static string Welcome()
    {
        return @"Welcome Friends! 
Have a nice day!!";
    }

////////////////Test3    
    public static void Test3() 
    {
        IsEqual(
            31, 
            Sum(15, 16)
        );
        
        IsEqual(
            10, 
            Sum(7, 3)
        );
        
        IsEqual(
            11, 
            Sum(8, 3)
        );
    }
    
/// Solution Test3
    
    public static int Sum(int a, int b) 
    {
        return a + b;
    }


////////////// Test6
    public static void Test6(){
        isEqual6(
           Tuple.Create(2, 1), 
            FirstSecond(1, 2)
        );
    
    }
    public static Tuple<int, int> FirstSecond(int a, int b) 
        { 
            int k; 
            if(a < b) 
            { 
                k = a + b; 
                a = k - a; 
                b = k - a; 
 
                return Tuple.Create(a, b); 
            } 
            else 
            { 
                if(a != b) 
                { 
                    return Tuple.Create(a, b); 
                } 
            } 
 
            return Tuple.Create(a, b); 
        } 
 
///////////Solution Test6
        public static void isEqual6(Tuple<int, int> mosalodneli, Tuple<int, int> pasuxebi) 
        { 
            if(mosalodneli.Item1 == pasuxebi.Item1 && mosalodneli.Item2 == pasuxebi.Item2) 
            { 
                WriteLine("true"); 
            } 
            else 
            { 
                WriteLine("false"); 
            } 
        }
    

/////// Test7
 public static void Test7()
 {
        isEqual7(
            5,
            Kvdr(2, 2)
        );
     isEqual7(
            4,
            Kvdr(2, 2)
        );
    }
    
    public static int Kvdr(int a,int b)
    {
    int ans=a;
        for(int k=1; k<b; k++)
        {
        ans=ans*a;
                
        }
        return ans;
}
///////Solution Test7
        public static void isEqual7(int mosalodneli, int pasuxi)
        {
        if(mosalodneli==pasuxi)
        {
            WriteLine("true");
        }
        else
        {
            WriteLine("false");
        }
    } 

////////////////Test8 Fiboonaco
    public static void Test8(){
    Fibo(7);
        
    }
    public static int Fibo(int a)
    {
    int num1 = 0;
    int num2 = 1;
    
    for (int i = 0; i < a; i++)
    {
        int cnt = num1;
        num1 = num2;
        num2 = cnt + num2;
        WriteLine(cnt);
    }
    return num1;
    }

/////////Test 9
    public static void Test9(){
   isEqual9(
       12,
       Prime(13)
   );
        
    
   }
    public static int Prime(int a)
    {
        
        if(a > 1 && a % 1 == 0 && a / a == 1 && (a % 3 != 0 && a % 2 != 0))
        {
            WriteLine(a + " is prime number");
            return a;
        }
            else 
        {
            WriteLine(a + " is unprime number");
            return a;
        }
    }   
////Solution Test9    
    public static void isEqual9(int mosalodneli, int pasuxi)
    {
        if(mosalodneli==pasuxi)
        {
            WriteLine("true");
        }
        else
        {
            WriteLine("false");
        }

    }
    
/////////////////////// Test10
    public static void Test10(){
        summ(6);
    }

    public static void summ(int a)
    {
        int cnt=0;
    for(int k=1; k<=a; k++)
    {
    cnt=cnt+k;
        
    }
        WriteLine(cnt);
}

    


    //////////////////////////
    
    public static void IsEqual(int excepted, int actual)
    {
        IsEqual(excepted.ToString(), actual.ToString());
    }
    
    public static void IsEqual(string excepted, string actual) 
    {
        if (excepted == actual)
        {
            WriteLine(@$"Result: {true}
                      
Excepted: 
{excepted}
                      
Actual:
{actual}");
        }
        else 
        {
            WriteLine(@$"Result: {false}
                      
Excepted: 
{excepted} 
                      
Actual:
{actual}");
        }
        WriteLine();
    }
}
