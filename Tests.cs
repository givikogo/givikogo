using System;
using static System.Console;        

public class Program
{
    public static void Main()
    {
        //Test2();
        //Test3();
        //Test4();
        //Test6();
        //Test8();
        //Test9();
        //Test10();
    }
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

    
    ////////////////////////////////
    public static void Test6(){
    FirstSecond(2,2);
    
    }
    public static void FirstSecond(int a,int b){
        int k;
        if(a<b && a!=b){
            k=a+b;
        a=k-a;
        b=k-a;
            WriteLine("1st number is :" + a);
            WriteLine("2st number is :" + b);
        }
        else if(a!=b){WriteLine("1st number is :" + a);
        WriteLine("2st number is :" + b);
             }
        if(a==b) WriteLine("1st number is :" + a);
             }
    /////////////////////////
             public static void Test8(){
    Fibo(5);
        
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
    
    public static void Test9(){
    Prime(29);
    
    }
    public static void Prime(int a){
        if(a>1 && a%1==0 && a/a==1 && (a%3!=0 && a%2!=0))WriteLine("prime");
        else WriteLine("unprime");
    }
    
/////////////////////// 
    public static void Test10(){
        summ(6);
    }
    public static void summ(int a)
    {
        int cnt=0;
    for(int k=1; k<=a; k++){
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
